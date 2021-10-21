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
                    AND Activo = 1
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

        private const string QRY_GET_ATTEMP_BY_ID = @"
            SELECT 
                Intentos
            FROM Usuario
            WHERE Id = @Id
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

        private const string QRY_UPDATE_PASSWORD_BY_ID = @"
            UPDATE Usuario SET
                Password = @Password
            WHERE Id = @Id
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

        private const string QRY_LOG_USER_BY_LOGIN = @"
            UPDATE Usuario SET 
                Intentos = 0
            OUTPUT
                inserted.Id
                , inserted.Nombre
                , inserted.Apellido
                , inserted.Login
                , inserted.Password
                , inserted.Email
                , inserted.IdIdioma
                , inserted.Activo 
                , inserted.Intentos
            WHERE Login = @Login
            ";

        private const string QRY_FIND_USERS_BY_PAGE = @"
            SELECT 
                Id
                , Nombre
                , Apellido
                , Email
                , Activo
            FROM Usuario
            WHERE Nombre LIKE @Nombre
                OR Apellido LIKE @Apellido
                OR Email LIKE @Email
            ORDER BY Nombre
            OFFSET @Skip ROWS
            FETCH NEXT @Take ROWS ONLY
            ";

        private const string QRY_DELETE_ALL_FAMILIAS = @"
            DELETE UsuarioFamilia
            WHERE IdUsuario = @IdUsuario
            ";

        private const string QRY_ASIGNA_FAMILIA = @"
            INSERT INTO UsuarioFamilia(IdUsuario, IdFamilia, DV)
                VALUES(@IdUsuario, @IdFamilia, '')
            ";

        private const string QRY_UPDATE_USUARIO_FAMILIA_DV = @"
            UPDATE UsuarioFamilia SET
                DV = @Dv
            WHERE IdUsuario = @IdUsuario
                AND IdFamilia = @IdFamilia
            ";

        private const string QRY_DELETE_ALL_PERMISOS = @"
            DELETE UsuarioPermiso
            WHERE IdUsuario = @IdUsuario
            ";

        private const string QRY_ASIGNA_PERMISO = @"
            INSERT INTO UsuarioPermiso(IdUsuario, IdPermiso, IdTipoPermiso, DV)
                VALUES(@IdUsuario, @IdPermiso, @IdTipoPermiso, '')
            ";


        private const string QRY_UPDATE_USUARIO_PERMISO_DV = @"
            UPDATE UsuarioPermiso SET
                DV = @Dv
            WHERE IdUsuario = @IdUsuario
                AND IdPermiso = @IdPermiso
            ";


        private const string QRY_USUARIO_PERMISOS_BY_USER = @"
            SELECT 
                IdUsuario
                , IdPermiso
                , IdTipoPermiso
                , DV
            FROM UsuarioPermiso
            WHERE 
                IdUsuario = @IdUsuario
            ";

        private const string QRY_PERMISOS_ASIGNADOS_BY_USER = @"
            SELECT 
                P.Id
                , P.Nombre
                , P.Modulo
                , P.Criticidad
                , UP.IdTipoPermiso
            FROM Permiso P
            JOIN UsuarioPermiso UP ON
                P.Id = UP.IdPermiso
            WHERE UP.IdUsuario = @IdUsuario
            ";

        private const string QRY_FAMILIAS_ASIGNADAS_BY_USER = @"
            SELECT 
                Id
                , Nombre
                , Activo
            FROM Familia
            WHERE 
                Activo = 1
                AND Id IN(
                    SELECT IdFamilia
                    FROM UsuarioFamilia
                    WHERE IdUsuario = @IdUsuario
                    )
            ";

        private const string QRY_USUARIO_FAMILIAS_BY_USER = @"
            SELECT 
                IdUsuario
                , IdFamilia
                , DV
            FROM UsuarioFamilia
            WHERE 
                IdUsuario = @IdUsuario
            ";

        private const string QRY_PERMISOS_DISPONIBLES_BY_USER = @"
            SELECT 
                Id
                , Nombre
                , [IdTipoPermiso] = 0
            FROM Permiso
            WHERE Id NOT IN(
                SELECT IdPermiso
                FROM UsuarioPermiso
                WHERE IdUsuario = @IdUsuario
                )
            ORDER BY Nombre
            ";

        private readonly string connectionString;

        public UserDal(string connectionString)
        {
            this.connectionString = connectionString;
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
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        db.Execute(QRY_UPDATE_ATTEMP_BY_LOGIN, new {Login = login}, transaction: tr);

                        UpdateIntegrityByLogin(login, db, tr);

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

        public int GetAttemps(string login)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.ExecuteScalar<int>(QRY_GET_ATTEMP_BY_LOGIN, new {Login = login});
            }
        }

        public int GetAttemps(int idUsuario)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.ExecuteScalar<int>(QRY_GET_ATTEMP_BY_ID, new {Id = idUsuario});
            }
        }

        public int GetAttemps(string login, IDbConnection db, IDbTransaction tr)
        {
            return db.ExecuteScalar<int>(QRY_GET_ATTEMP_BY_LOGIN, new {Login = login}, tr);
        }

        public void RestorePassword(string login, string password)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        db.Execute(QRY_RESTORE_BY_LOGIN, new {Login = login, Password = password}, tr);

                        UpdateIntegrityByLogin(login, db, tr);

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

        public void SaveNewPassword(int idUsuario, string password)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        db.Execute(QRY_UPDATE_PASSWORD_BY_ID, new {Id = idUsuario, Password = password}, tr);

                        var login = GetUserById(idUsuario, db, tr).Login;

                        UpdateIntegrityByLogin(login, db, tr);

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
            return db.Query<User>(QRY_GET_USER_BY_LOGIN, new {Login = login}, tr).FirstOrDefault();
        }

        public IEnumerable<User> GetAllInTransaction(IDbConnection db, IDbTransaction tr)
        {
            return db.Query<User>(QRY_GET_ALL_USERS, transaction: tr);
        }

        public IEnumerable<UserDto> GetByActivo(bool activo)
        {
            return GetAll()
                .Where(x => x.Activo == activo)
                .OrderBy(x => x.Apellido)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Nombre = u.Nombre,
                    Apellido = u.Apellido,
                    Email = u.Email,
                    Activo = u.Activo
                })
                .ToList();
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

        private User GetUserById(int idUsuario, IDbConnection db, IDbTransaction tr)
        {
            return db.Query<User>(QRY_GET_USER_BY_ID, new {Id = idUsuario}, transaction: tr).FirstOrDefault();
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

                            UpdateIntegrityByLogin(user.Login, db, tr);

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
                                    Nombre = user.Nombre, Apellido = user.Apellido, Email = user.Email,
                                    IdIdioma = user.IdIdioma,
                                    Activo = user.Activo, Id = user.Id
                                }, tr);

                            UpdateIntegrityByLogin(user.Login, db, tr);

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

        public User LogUser(string login)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        var attemps = GetAttemps(login, db, tr);
                        var user = db.Query<User>(QRY_LOG_USER_BY_LOGIN, new {Login = login}, tr).FirstOrDefault();

                        if (attemps != user.Intentos)
                        {
                            UpdateIntegrityByLogin(login, db, tr);
                        }

                        tr.Commit();

                        return new User
                        {
                            Apellido = user.Apellido,
                            Email = user.Email,
                            Id = user.Id,
                            IdIdioma = user.IdIdioma,
                            Nombre = user.Nombre
                        };
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        private void UpdateIntegrityByLogin(string login, IDbConnection db, IDbTransaction tr)
        {
            var changedUser = GetUserByLogin(login, db, tr);
            var dvhString = DvhCalculator<User>.GetDvhString(changedUser, out _);
            db.Execute(QRY_UPDATE_DV_BY_LOGIN, new {Dv = dvhString, Login = login}, tr);

            var users = db.Query<User>(QRY_GET_ALL_USERS, transaction: tr);
            long dvvTotal = 0;
            foreach (var user in users)
            {
                DvhCalculator<User>.GetDvhString(user, out var dvhValue);
                dvvTotal += dvhValue;
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            IntegrityDal.UpdateIntegryty(TablaIntegridadEnum.Usuario, dvvString, db, tr);
        }

        public bool RepareIntegrity()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        var users = GetAllInTransaction(db, tr);
                        long dvvTotal = 0;
                        foreach (var user in users)
                        {
                            var dvhString = DvhCalculator<User>.GetDvhString(user, out var dvhValue);
                            db.Execute(QRY_UPDATE_DV_BY_LOGIN, new {Dv = dvhString, Login = user.Login}, tr);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty(TablaIntegridadEnum.Usuario, dvvString, db, tr);

                        tr.Commit();

                        return true;
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        public IEnumerable<UserDto> FindPage(string searchText, int page, int take)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                var nombre = $"%{searchText}%";
                var apellido = $"%{searchText}%";
                var email = $"%{searchText}%";

                return db.Query<UserDto>(QRY_FIND_USERS_BY_PAGE,
                    new {Nombre = nombre, Apellido = apellido, Email = email, Skip = page * take, Take = take});
            }
        }

        public void AsignarFamilias(int userId, List<int> familias)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        db.Execute(QRY_DELETE_ALL_FAMILIAS, new {IdUsuario = userId}, transaction: tr);

                        foreach (var fId in familias)
                        {
                            db.Execute(QRY_ASIGNA_FAMILIA, new {IdUsuario = userId, IdFamilia = fId}, transaction: tr);
                        }

                        var asignadas = new FamiliaDal(connectionString).GetUsuarioFamilias(db, tr);

                        long dvvTotal = 0;
                        foreach (var fa in asignadas)
                        {
                            var dvhString = DvhCalculator<UsuarioFamilia>.GetDvhString(fa, out var dvhValue);
                            db.Execute(QRY_UPDATE_USUARIO_FAMILIA_DV,
                                new {Dv = dvhString, IdUsuario = fa.IdUsuario, IdFamilia = fa.IdFamilia}, tr);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty(TablaIntegridadEnum.UsuarioFamilia, dvvString, db, tr);

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

        public void AsignarPermisos(int userId, Dictionary<int, int> permisos)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        db.Execute(QRY_DELETE_ALL_PERMISOS, new { IdUsuario = userId }, transaction: tr);

                        foreach (var p in permisos)
                        {
                            db.Execute(QRY_ASIGNA_PERMISO,
                                new {IdUsuario = userId, IdPermiso = p.Key, IdTipoPermiso = p.Value}, transaction: tr);
                        }

                        var asignados = new PermisoDal(connectionString).GetUsuarioPermisos(db, tr);

                        long dvvTotal = 0;
                        foreach (var pa in asignados)
                        {
                            var dvhString = DvhCalculator<UsuarioPermiso>.GetDvhString(pa, out var dvhValue);
                            db.Execute(QRY_UPDATE_USUARIO_PERMISO_DV,
                                new {Dv = dvhString, IdUsuario = pa.IdUsuario, IdPermiso = pa.IdPermiso}, tr);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty(TablaIntegridadEnum.UsuarioPermiso, dvvString, db, tr);

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

        public IEnumerable<PermisoDto> GetPermisos(int userId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<PermisoDto>(QRY_PERMISOS_ASIGNADOS_BY_USER, new { IdUsuario = userId });
            }
        }

        public IEnumerable<UsuarioPermiso> GetPermisos(int userId, IDbConnection db, IDbTransaction tr)
        {
            return db.Query<UsuarioPermiso>(QRY_USUARIO_PERMISOS_BY_USER, new { IdUsuario = userId }, transaction: tr);
        }

        public IEnumerable<FamiliaDto> GetFamilias(int userId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<FamiliaDto>(QRY_FAMILIAS_ASIGNADAS_BY_USER, new { IdUsuario = userId });
            }
        }

        public IEnumerable<UsuarioFamilia> GetFamilias(int userId, IDbConnection db, IDbTransaction tr)
        {
            return db.Query<UsuarioFamilia>(QRY_USUARIO_FAMILIAS_BY_USER, new { IdUsuario = userId }, transaction: tr);
        }

        public IEnumerable<PermisoDto> GetPermisosDisponibles(int userId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<PermisoDto>(QRY_PERMISOS_DISPONIBLES_BY_USER, new { IdUsuario = userId });
            }
        }
    }
}