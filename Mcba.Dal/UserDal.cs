using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using Mcba.Entidad.Enums;
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

        private const string QRY_GET_USER_BY_ID = @"
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
            WHERE Id = @Id
            ";

        private const string QRY_UPDATE_DV_BY_LOGIN = @"
            UPDATE Usuario SET
                DV = @Dv
            WHERE Login = @Login
            ";

        private const string QRY_GET_ALL_USERS_BY_PAGE = @"
            SELECT 
                Id
                , Nombre
                , Apellido
                , Email
                , Activo
            FROM Usuario
            ORDER BY Nombre
            OFFSET @Skip ROWS
            FETCH NEXT @Take ROWS ONLY
            ";

        private const string QRY_INSERT_USER = @"
            INSERT INTO Usuario(Nombre, Apellido, Login, Password, Email, IdIdioma, Activo, Intentos, DV)
                VALUES(@Nombre, @Apellido, @Login, @Password, @Email, @IdIdioma, @Activo, 0, 0)
            ";

        private const string QRY_UPDATE_USER = @"
            UPDATE Usuario SET 
                Nombre = @Nombre
                , Apellido = @Apellido
                , Email = @Email
                , IdIdioma = @IdIdioma
                , Activo = @Activo
            WHERE Id = @Id
            ";

        private const string QRY_EMAIL_EXISTS = @"
            SELECT TOP 1 1
            FROM Usuario
            WHERE Email = @Email
                AND Id <> @IdUsuario
            ";

        private const string QRY_USERS_COUNT = @"
            SELECT COUNT(Id)
            FROM Usuario
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
                db.Execute(QRY_UPDATE_DV_BY_LOGIN, new {Dv = dvString, Login = login});
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
                        var dvhString = DvhCalculator<User>.GetDvhString(changeUser, out var _);
                        db.Execute(QRY_UPDATE_DV_BY_LOGIN, new {Dv = dvhString, Login = login});

                        var users = db.Query<User>(QRY_GET_ALL_USERS);
                        long dvvTotal = 0;
                        foreach (var user in users)
                        {
                            DvhCalculator<User>.GetDvhString(user, out var dvhValue);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty("Usuario", dvvString, db, tr);

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

        public User GetUserByLogin(string login, IDbConnection db, IDbTransaction tr)
        {
            return db.Query<User>(QRY_GET_USER_BY_LOGIN, new {Login = login}, transaction: tr).FirstOrDefault();
        }

        public IEnumerable<User> GetAll()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<User>(QRY_GET_ALL_USERS);
            }
        }

        public IEnumerable<UserDto> GetAll(int page, int take)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<UserDto>(QRY_GET_ALL_USERS_BY_PAGE, new {Skip = page * take, Take = take});
            }
        }

        public User GetUserById(int id)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<User>(QRY_GET_USER_BY_ID, new {Id = id}).FirstOrDefault();
            }
        }

        public bool Save(User user)
        {
            bool ret;

            if (user.Id == 0)
            {
                using (var db = new DataAccess(connectionString).GetOpenConnection())
                {
                    using (var tr = db.BeginTransaction())
                    {
                        try
                        {
                            var ok = db.Execute(QRY_INSERT_USER,
                                new
                                {
                                    Nombre = user.Nombre, Apellido = user.Apellido, Login = user.Login,
                                    Password = user.Password, Email = user.Email, IdIdioma = user.IdIdioma,
                                    Activo = user.Activo
                                }, transaction: tr);
                            var newUser = GetUserByLogin(user.Login, db, tr);
                            var dvhString = DvhCalculator<User>.GetDvhString(newUser, out _);
                            db.Execute(QRY_UPDATE_DV_BY_LOGIN, new {Dv = dvhString, Login = newUser.Login},
                                transaction: tr);

                            var users = db.Query<User>(QRY_GET_ALL_USERS, transaction: tr);
                            long dvvTotal = 0;
                            foreach (var u in users)
                            {
                                DvhCalculator<User>.GetDvhString(u, out var dvhValue);
                                dvvTotal += dvhValue;
                            }

                            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                            var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);
                            IntegrityDal.UpdateIntegryty("Usuario", dvvString, db, tr);

                            tr.Commit();

                            ret = ok > 0;
                        }
                        catch
                        {
                            tr.Rollback();
                            throw;
                        }
                    }
                }
            }
            else // update
            {
                using (var db = new DataAccess(connectionString).GetOpenConnection())
                {
                    using (var tr = db.BeginTransaction())
                    {
                        try
                        {
                            var ok = db.Execute(QRY_UPDATE_USER,
                                new
                                {
                                    Nombre = user.Nombre, Apellido = user.Apellido, Email = user.Email, IdIdioma = user.IdIdioma,
                                    Activo = user.Activo, Id = user.Id
                                }, transaction: tr);

                            var updatedUser = GetUserByLogin(user.Login, db, tr);
                            var dvhString = DvhCalculator<User>.GetDvhString(updatedUser, out _);
                            db.Execute(QRY_UPDATE_DV_BY_LOGIN, new {Dv = dvhString, Login = updatedUser.Login}, transaction:tr);

                            var users = db.Query<User>(QRY_GET_ALL_USERS, transaction: tr);
                            long dvvTotal = 0;
                            foreach (var u in users)
                            {
                                DvhCalculator<User>.GetDvhString(u, out var dvhValue);
                                dvvTotal += dvhValue;
                            }

                            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                            var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);
                            IntegrityDal.UpdateIntegryty("Usuario", dvvString, db, tr);

                            ret = ok > 0;

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

            return ret;
        }

        public bool LoginExists(string login)
        {
            return GetUserByLogin(login) != null;
        }

        public bool EmailExist(string email, int idUsuario)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                var ret = db.ExecuteScalar<int>(QRY_EMAIL_EXISTS, new {Email = email, IdUsuario = idUsuario});
                return ret == 1;
            }
        }

        public int GetUsersCount()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                var ret = db.ExecuteScalar<int>(QRY_USERS_COUNT);
                return ret;
            }
        }
    }
}