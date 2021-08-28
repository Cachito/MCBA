using System;
using System.Collections.Generic;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;

namespace Mcba.Dal
{
    public class UserDal : DataAccess
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
                )
            BEGIN
                SELECT 1
            END
            ELSE
            BEGIN
                SELECT 0
            END
            ";

        public UserDal(string connectionString) : base(connectionString)
        {
        }

        public string GetEmailByLogin(string login)
        {
            string ret;

            using (var db = GetOpenConnection())
            {
                ret = db.ExecuteScalar<string>(QRY_EMAIL_BY_LOGIN, new {Login = login});
            }

            return ret;
        }

        public bool UserOk(string login, string password)
        {
            int ret;

            using (var db = GetOpenConnection())
            {
                ret = db.ExecuteScalar<int>(QRY_USER_CREDENTIALS, new { Login = login, Password = password });
            }

            return ret == 1;
        }
    }
}
