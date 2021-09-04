using System;
using System.Web.Security;
using Mcba.Dal;
using Mcba.Entidad;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.Bll
{
    public class UserBll
    {
        public string GetEmailByLogin(string login)
        {
            var cryptLogin = HashHelper.Crypt(login, McbaSettings.Salt);

            return new UserDal(McbaSettings.CnnString).GetEmailByLogin(cryptLogin);
        }

        public bool UserOk(string login, string password)
        {
            var ret = false;

            var cryptLogin = HashHelper.Crypt(login, McbaSettings.Salt);
            var cryptPass = HashHelper.Crypt(password, McbaSettings.Salt);

            var userDal = new UserDal(McbaSettings.CnnString);

            ret = userDal.UserOk(cryptLogin, cryptPass, McbaSettings.MaxLoginAttemps);

            if (!ret)
            {
                userDal.UpdateFailedAttempt(cryptLogin);
            }

            return ret;
        }

        public int GetAttemps(string login)
        {
            var cryptLogin = HashHelper.Crypt(login, McbaSettings.Salt);

            var userDal = new UserDal(McbaSettings.CnnString);

            return userDal.GetAttemps(cryptLogin);
        }

        public string RestorePassword(string login)
        {
            var randomPass =
                Membership.GeneratePassword(McbaSettings.RandomPassLength, McbaSettings.NumberOfNonAlphanumericCharacters);

            var cryptLogin = HashHelper.Crypt(login, McbaSettings.Salt);
            var cryptPass = HashHelper.Crypt(randomPass, McbaSettings.Salt);

            var userDal = new UserDal(McbaSettings.CnnString);
            userDal.RestorePassword(cryptLogin, cryptPass);

            var user = userDal.GetUserByLogin(cryptLogin);

            var dvString = DvHelper<User>.GetDvhString(user);

            userDal.UpdateDv(user.Login, dvString);

            return randomPass;
        }
    }
}