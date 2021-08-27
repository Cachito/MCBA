using Mcba.Dal;
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
            var cryptLogin = HashHelper.Crypt(login, McbaSettings.Salt);
            var cryptPass = HashHelper.Crypt(password, McbaSettings.Salt);

            return new UserDal(McbaSettings.CnnString).UserOk(cryptLogin, cryptPass);
        }
    }
}