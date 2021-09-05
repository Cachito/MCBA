using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;
using Mcba.Seguridad;

namespace Mcba.Dal
{
    public class UserDal
    {
        private const string QRY_EMAIL_BY_LOGIN = @"
            SELECT 
                Email
            FROM Usuario
            WHERE Login = @Login
            ";

        private const string QRY_USER_CREDENTIALS = @"
            IF EXISTS(
                SELECT TOP 1 1
                FROM Usuario
                WHERE 
                    Login = @Login
                    AND Password = @Password
                    AND Intentos < @MaxIntentos
                )
            BEGIN
                SELECT 1
            END
            ELSE
            BEGIN
                SELECT 0
            END
            ";

        private const string QRY_UPDATE_ATTEMP_BY_LOGIN = @"
            UPDATE Usuario SET
                Intentos = Intentos + 1
            WHERE Login = @Login
            ";

        private const string QRY_RESTORE_BY_LOGIN = @"
            UPDATE Usuario SET
                Password = @Password,
                Intentos = 0
            WHERE Login = @Login
            ";

        private const string QRY_GET_ATTEMP_BY_LOGIN = @"
            SELECT 
                Intentos
            FROM Usuario
            WHERE Login = @Login
            ";

        private const string QRY_GET_ALL_USERS = @"
            SELECT 
                Id
                , Nombre
                , Apellido
                , Login
                , Password
                , Email
                , IdIdioma
                , Activo 
                , Intentos
                , DV
            FROM Usuario
            ";

        private const string QRY_GET_USER_BY_LOGIN = @"
            SELECT 
                Id
                , Nombre
                , Apellido
                , Login
                , Password
                , Email
                , IdIdioma
                , Activo 
                , Intentos
            FROM Usuario
            WHERE Login = @Login
            ";

        private const string QRY_UPDATE_DV_BY_LOGIN = @"
            UPDATE Usuario SET
                DV = @Dv
            WHERE Login = @Login
            ";

        private readonly string connectionString;

        public UserDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void UpdateDvh(string login, string dvString)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                db.Execute(QRY_UPDATE_DV_BY_LOGIN, new { Dv = dvString, Login = login });
            }
        }

        public string GetEmailByLogin(string login)
        {
            string ret;

            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                ret = db.ExecuteScalar<string>(QRY_EMAIL_BY_LOGIN, new {Login = login});
            }

            return ret;
        }

        public bool UserOk(string login, string password, int maxAttemps)
        {
            int ret;

            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                ret = db.ExecuteScalar<int>(QRY_USER_CREDENTIALS,
                    new {Login = login, Password = password, MaxIntentos = maxAttemps});
            }

            return ret == 1;
        }

        public void UpdateFailedAttempt(string login)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                db.Execute(QRY_UPDATE_ATTEMP_BY_LOGIN, new {Login = login});
            }
        }

        public int GetAttemps(string login)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.ExecuteScalar<int>(QRY_GET_ATTEMP_BY_LOGIN, new {Login = login});
            }
        }

        public void RestorePassword(string login, string password)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        db.Execute(QRY_RESTORE_BY_LOGIN, new {Login = login, Password = password});
                        var changeUser = GetUserByLogin(login);
                        var dvhString = DvhHelper<User>.GetDvhString(changeUser, out var _);
                        db.Execute(QRY_UPDATE_DV_BY_LOGIN, new {Dv = dvhString, Login = login});
                        
                        var users = db.Query<User>(QRY_GET_ALL_USERS);
                        long dvvTotal = 0;
                        foreach (var user in users)
                        {
                            DvhHelper<User>.GetDvhString(user, out var dvhValue);
                            dvvTotal += dvhValue;
                        }

                        var dvvString = DvValue.GetDvValue(dvvTotal.ToString());

                        new IntegrityDal(connectionString).UpdateIntegryty("Usuario", db, tr);

                        tr.Commit();
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        public User GetUserByLogin(string login)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<User>(QRY_GET_USER_BY_LOGIN, new {Login = login}).FirstOrDefault();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<User>(QRY_GET_ALL_USERS);
            }
        }
    }
}