using System.Collections.Generic;
using System.Web.Security;
using Mcba.Dal;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
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

            return randomPass;
        }

        public IEnumerable<UserDto> Get(int offsetRows)
        {
            return new UserDal(McbaSettings.CnnString).GetAll(offsetRows);
        }

        public User GetUser(int id)
        {
            return new UserDal(McbaSettings.CnnString).GetUserById(id);
        }

        public bool Save(User user, out string newPassword)
        {
            newPassword = string.Empty;

            if (user.Id == 0)
            {
                user.Login = HashHelper.Crypt(user.Login, McbaSettings.Salt);

                newPassword =
                    Membership.GeneratePassword(McbaSettings.RandomPassLength, McbaSettings.NumberOfNonAlphanumericCharacters);
                user.Password = HashHelper.Crypt(newPassword, McbaSettings.Salt);
            }

            var userDal = new UserDal(McbaSettings.CnnString);

            return userDal.Save(user);
        }
    }
}