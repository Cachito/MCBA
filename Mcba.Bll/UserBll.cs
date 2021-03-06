using System;
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
            var cryptLogin = HashCalculator.Crypt(login, McbaSettings.Salt);

            return new UserDal(McbaSettings.CnnString).GetEmailByLogin(cryptLogin);
        }

        public bool UserOk(string login, string password)
        {
            var ret = false;

            var cryptLogin = HashCalculator.Crypt(login, McbaSettings.Salt);
            var cryptPass = HashCalculator.Crypt(password, McbaSettings.Salt);

            var userDal = new UserDal(McbaSettings.CnnString);

            ret = userDal.UserOk(cryptLogin, cryptPass, McbaSettings.MaxLoginAttemps);
            var user = userDal.GetUserByLogin(cryptLogin);

            if (!ret && user != null)
            {
                userDal.UpdateFailedAttempt(cryptLogin);
            }

            return ret;
        }

        public IEnumerable<UserDto> GetByActivo(bool activo)
        {
            return new UserDal(McbaSettings.CnnString).GetByActivo(activo);
        }

        public int GetAttemps(string login)
        {
            var cryptLogin = HashCalculator.Crypt(login, McbaSettings.Salt);

            var userDal = new UserDal(McbaSettings.CnnString);

            return userDal.GetAttemps(cryptLogin);
        }

        public int GetAttemps(int idUsuario)
        {
            var userDal = new UserDal(McbaSettings.CnnString);

            return userDal.GetAttemps(idUsuario);
        }

        public void SaveNewPassword(int idUsuario, string password)
        {
            var userDal = new UserDal(McbaSettings.CnnString);
            var cryptPass = HashCalculator.Crypt(password, McbaSettings.Salt);
            userDal.SaveNewPassword(idUsuario, cryptPass);
        }

        public string RestorePassword(string login, bool encriptedLogin = false)
        {
            var randomPass =
                Membership.GeneratePassword(McbaSettings.RandomPassLength, McbaSettings.NumberOfNonAlphanumericCharacters);

            var cryptLogin = encriptedLogin ? login : HashCalculator.Crypt(login, McbaSettings.Salt);
            var cryptPass = HashCalculator.Crypt(randomPass, McbaSettings.Salt);

            var userDal = new UserDal(McbaSettings.CnnString);
            userDal.RestorePassword(cryptLogin, cryptPass);

            return randomPass;
        }

        public IEnumerable<UserDto> GetPage(int page)
        {
            return new UserDal(McbaSettings.CnnString).GetAll(page, McbaSettings.DataPagination);
        }

        public User GetUser(int id)
        {
            return new UserDal(McbaSettings.CnnString).GetUserById(id);
        }

        public void LogOffUser(string login, string message)
        {
            var cryptLogin = HashCalculator.Crypt(login, McbaSettings.Salt);

            new UserDal(McbaSettings.CnnString).LogOffUser(cryptLogin, message);
        }

        public User LogOnUser(string login, string message)
        {
            var cryptLogin = HashCalculator.Crypt(login, McbaSettings.Salt);

            return new UserDal(McbaSettings.CnnString).LogOnUser(cryptLogin, message);
        }

        public bool Save(User user, out string newPassword)
        {
            newPassword = string.Empty;

            if (user.Id == 0)
            {
                user.Login = HashCalculator.Crypt(user.Login, McbaSettings.Salt);

                newPassword =
                    Membership.GeneratePassword(McbaSettings.RandomPassLength, McbaSettings.NumberOfNonAlphanumericCharacters);
                user.Password = HashCalculator.Crypt(newPassword, McbaSettings.Salt);
            }

            var userDal = new UserDal(McbaSettings.CnnString);

            return userDal.Save(user);
        }

        public bool CheckPassword(int idUsuario, string password)
        {
            var ret = false;

            var userDal = new UserDal(McbaSettings.CnnString);
            var crypPass = HashCalculator.Crypt(password, McbaSettings.Salt);
            var actualUser = userDal.GetUserById(idUsuario);
            var actualPass = actualUser.Password;

            ret = actualPass == crypPass;

            if (!ret)
            {
                userDal.UpdateFailedAttempt(actualUser.Login);
            }

            return ret;
        }

        public bool EmailExist(string email, int idUsuario)
        {
            var userDal = new UserDal(McbaSettings.CnnString);

            return userDal.EmailExist(email, idUsuario);
        }

        public int GetUsersCount()
        {
            return new UserDal(McbaSettings.CnnString).GetUsersCount();
        }

        public IEnumerable<UserDto> FindPage(string searchText, int page)
        {
            return new UserDal(McbaSettings.CnnString).FindPage(searchText, page, McbaSettings.DataPagination);
        }

        public void AsignarFamilias(int userId, List<int> familias, Bitacora bitacora)
        {
            new UserDal(McbaSettings.CnnString).AsignarFamilias(userId, familias, bitacora);
        }

        public void AsignarPermisos(int userId, Dictionary<int, int> permisos, Bitacora bitacora)
        {
            new UserDal(McbaSettings.CnnString).AsignarPermisos(userId, permisos, bitacora);
        }

        public IEnumerable<PermisoDto> GetPermisos(int userId)
        {
            return new UserDal(McbaSettings.CnnString).GetPermisos(userId);
        }

        public IEnumerable<FamiliaDto> GetFamilias(int userId)
        {
            return new UserDal(McbaSettings.CnnString).GetFamilias(userId);
        }

        public IEnumerable<PermisoDto> GetPermisosDisponibles(int userId)
        {
            return new UserDal(McbaSettings.CnnString).GetPermisosDisponibles(userId);
        }
    }
}