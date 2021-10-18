using Mcba.Data;
using Dapper;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using System;
using Mcba.Entidad.Enums;
using Mcba.Seguridad;

namespace Mcba.Dal
{
    public class FamiliaDal
    {
        private const string QRY_FAMILIA_COUNT = @"
            SELECT COUNT(Id)
            FROM Familia
            ";

        private const string QRY_GET_FAMILIA_BY_ID = @"
            SELECT 
                Id
                , Nombre
                , Activo
            FROM Familia
            WHERE Id = @Id
            ";

        private const string QRY_INSERT_FAMILIA = @"
            INSERT INTO Familia(Nombre, Activo)
                VALUES(@Nombre, @Activo)
            ";

        private const string QRY_UPDATE_FAMILIA = @"
            UPDATE Familia SET 
                Nombre = @Nombre
                , Activo = @Activo
            WHERE Id = @Id
            ";

        private const string QRY_FIND_FAMILIAS_BY_PAGE = @"
            SELECT 
                Id
                , Nombre
                , Activo
            FROM Familia
            WHERE Nombre LIKE @Nombre
            ORDER BY Nombre
            OFFSET @Skip ROWS
            FETCH NEXT @Take ROWS ONLY
            ";

        private const string QRY_GET_ALL_FAMILIAS = @"
            SELECT 
                Id
                , Nombre
                , Activo
            FROM Familia
            ";

        private const string QRY_FAMILIAS_DISPONIBLES_BY_USER = @"
            SELECT 
                Id
                , Nombre
                , Activo
            FROM Familia
            WHERE 
                Activo = 1
                AND Id NOT IN(
                    SELECT IdFamilia
                    FROM UsuarioFamilia
                    WHERE IdUsuario = @IdUsuario
                    )
            ORDER BY Nombre
            ";

        //private const string QRY_FAMILIAS_ASIGNADAS_BY_USER = @"
        //    SELECT 
        //        Id
        //        , Nombre
        //        , Activo
        //    FROM Familia
        //    WHERE 
        //        Activo = 1
        //        AND Id IN(
        //            SELECT IdFamilia
        //            FROM UsuarioFamilia
        //            WHERE IdUsuario = @IdUsuario
        //            )
        //    ";

        //private const string QRY_USUARIO_FAMILIAS_BY_USER = @"
        //    SELECT 
        //        IdUsuario
        //        , IdFamilia
        //        , DV
        //    FROM UsuarioFamilia
        //    WHERE 
        //        IdUsuario = @IdUsuario
        //    ";

        private const string QRY_USUARIO_FAMILIAS = @"
            SELECT 
                IdUsuario
                , IdFamilia
                , DV
            FROM UsuarioFamilia
            ";

        private const string QRY_PERMISOS_ASIGNADOS_BY_FAMILIA = @"
            SELECT 
                P.Id
                , P.Nombre
                , P.Modulo
                , P.Criticidad
                , UP.IdTipoPermiso
            FROM Permiso P
            JOIN FamiliaPermiso FP ON
                P.Id = PP.IdPermiso
            WHERE FP.IdFamilia = @IdFamilia
            ";

        private const string QRY_PERMISOS_DISPONIBLES_BY_FAMILIA = @"
            SELECT 
                P.Id
                , P.Nombre
                , P.Modulo
                , P.Criticidad
                , UP.IdTipoPermiso
            FROM Permiso P
            WHERE FP.IdFamilia = @IdFamilia
                AND P.Id NOT IN (
                    SELECT PermisoId
                    FROM FamiliaPermiso
                    WHERE IdFamilia = @IdFamilia
                    )
            ";

        private const string QRY_USUARIOS_BY_FAMILIA = @"
            SELECT 
                U.Id
                , U.Nombre
                , U.Apellido
                , U.Email
                , U.Activo
            FROM Usuario
            JOIN UsuarioFamilia UF ON
                UF.IdUsuario = U.IdUsuario
            WHERE UF.IdFamilia = @IdFamilia
            ";

        private const string QRY_USUARIOS_DISPONIBLES_BY_FAMILIA = @"
            SELECT 
                Id
                , Nombre
                , Apellido
                , Email
                , Activo
            FROM Usuario
            WHERE Activo = 1
                AND Id NOT IN(
                SELECT UsuarioId
                FROM UsuariosFamilia
                WHERE FamiliaId = @FamiliaId
                )
            ";

        private const string QRY_FAMILIAS_BY_ACTIVO = @"
            SELECT 
                Id
                , Nombre
                , Activo
            FROM Familia
            WHERE Activo = @Activo
            ";

        private const string QRY_DELETE_ALL_USUARIOS = @"
            DELETE UsuarioFamilia
            WHERE IdFamilia = @IdFamilia
            ";

        private const string QRY_ASIGNA_USUARIO = @"
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
            DELETE FamiliaPermiso
            WHERE IdFamilia = @IdFamilia
            ";

        private const string QRY_ASIGNA_PERMISO = @"
            INSERT INTO FamiliaPermiso(IdFamilia, IdPermiso, IdTipoPermiso, DV)
                VALUES(@IdFamilia, @IdPermiso, @IdTipoPermiso, '')
            ";

        private const string QRY_UPDATE_FAMILIA_PERMISO_DV = @"
            UPDATE FamiliaPermiso SET
                DV = @Dv
            WHERE IdFamilia = @IdFamilia
                AND IdPermiso = @IdPermiso
            ";

        private readonly string connectionString;

        public FamiliaDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Save(FamiliaDto familia)
        {
            bool ret;

            if (familia.Id == 0)
            {
                using (var db = new DataAccess(connectionString).GetOpenConnection())
                {
                    using (var tr = db.BeginTransaction())
                    {
                        try
                        {
                            var ok = db.Execute(QRY_INSERT_FAMILIA,
                                new
                                {
                                    Nombre = familia.Nombre,
                                    Activo = familia.Activo
                                }, transaction: tr);

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
                            var ok = db.Execute(QRY_UPDATE_FAMILIA,
                                new
                                {
                                    Nombre = familia.Nombre,
                                    Activo = familia.Activo,
                                    Id = familia.Id
                                }, tr);

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

        public FamiliaDto GetFamiliaById(int id)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<FamiliaDto>(QRY_GET_FAMILIA_BY_ID, new {Id = id}).FirstOrDefault();
            }
        }

        public int GetUsersCount()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                var ret = db.ExecuteScalar<int>(QRY_FAMILIA_COUNT);
                return ret;
            }
        }

        public IEnumerable<FamiliaDto> FindPage(string searchText, int page, int take)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                var nombre = $"%{searchText}%";

                return db.Query<FamiliaDto>(QRY_FIND_FAMILIAS_BY_PAGE,
                    new {Nombre = nombre, Skip = page * take, Take = take});
            }
        }

        public IEnumerable<FamiliaDto> GetAll(int page, int take)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<FamiliaDto>(QRY_GET_ALL_FAMILIAS);
            }
        }

        public IEnumerable<FamiliaDto> GetDisponibles(int userId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<FamiliaDto>(QRY_FAMILIAS_DISPONIBLES_BY_USER, new { IdUsuario = userId });
            }
        }

        //public IEnumerable<FamiliaDto> GetAsignadas(int userId)
        //{
        //    using (var db = new DataAccess(connectionString).GetOpenConnection())
        //    {
        //        return db.Query<FamiliaDto>(QRY_FAMILIAS_ASIGNADAS_BY_USER, new { IdUsuario = userId });
        //    }
        //}

        //public IEnumerable<UsuarioFamilia> GetAsignadas(int userId, IDbConnection db, IDbTransaction tr)
        //{
        //    return db.Query<UsuarioFamilia>(QRY_USUARIO_FAMILIAS_BY_USER, new {IdUsuario = userId}, transaction: tr);
        //}

        public IEnumerable<UsuarioFamilia> GetUsuarioFamilias()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<UsuarioFamilia>(QRY_USUARIO_FAMILIAS);
            }
        }

        public IEnumerable<UsuarioFamilia> GetUsuarioFamilias(IDbConnection db, IDbTransaction tr)
        {
            return db.Query<UsuarioFamilia>(QRY_USUARIO_FAMILIAS, transaction: tr);
        }

        public IEnumerable<PermisoDto> GetPermisos(int familiaId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<PermisoDto>(QRY_PERMISOS_ASIGNADOS_BY_FAMILIA, new {IdFamilia = familiaId});
            }
        }

        public IEnumerable<PermisoDto> GetPermisosDisponibles(int familiaId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<PermisoDto>(QRY_PERMISOS_DISPONIBLES_BY_FAMILIA, new { IdFamilia = familiaId });
            }
        }

        public IEnumerable<UserDto> GetUsuarios(int familiaId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<UserDto>(QRY_USUARIOS_BY_FAMILIA, new { IdFamilia = familiaId });
            }
        }

        public IEnumerable<UserDto> GetUsuariosDisponibles(int familiaId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<UserDto>(QRY_USUARIOS_DISPONIBLES_BY_FAMILIA, new { IdFamilia = familiaId });
            }
        }

        public IEnumerable<FamiliaDto> GetByActivo(bool activo)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<FamiliaDto>(QRY_FAMILIAS_BY_ACTIVO, new { Activo = activo});
            }
        }

        public void AsignarUsuarios(int familiaId, List<int> usuarios)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        db.Execute(QRY_DELETE_ALL_USUARIOS, new { IdFAmilia = familiaId }, transaction: tr);

                        foreach (var uId in usuarios)
                        {
                            db.Execute(QRY_ASIGNA_USUARIO, new { IdUsuario = uId, IdFamilia = familiaId}, transaction: tr);
                        }

                        var asignados = GetUsuarioFamilias(db, tr);

                        long dvvTotal = 0;
                        foreach (var ua in asignados)
                        {
                            var dvhString = DvhCalculator<UsuarioFamilia>.GetDvhString(ua, out var dvhValue);
                            db.Execute(QRY_UPDATE_USUARIO_FAMILIA_DV,
                                new { Dv = dvhString, IdFamilia = familiaId, IdUsuario = ua.IdUsuario}, tr);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty("UsuarioFamilia", dvvString, db, tr);

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

        public void AsignarPermisos(int familiaId, Dictionary<int, int> permisos)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        db.Execute(QRY_DELETE_ALL_PERMISOS, new { IdFamilia = familiaId }, transaction: tr);

                        foreach (var p in permisos)
                        {
                            db.Execute(QRY_ASIGNA_PERMISO,
                                new { IdFamilia = familiaId, IdPermiso = p.Key, IdTipoPermiso = p.Value }, transaction: tr);
                        }

                        var asignados = new PermisoDal(connectionString).GetFamiliaPermisos(db, tr);

                        long dvvTotal = 0;
                        foreach (var pa in asignados)
                        {
                            var dvhString = DvhCalculator<FamiliaPermiso>.GetDvhString(pa, out var dvhValue);
                            db.Execute(QRY_UPDATE_FAMILIA_PERMISO_DV,
                                new { Dv = dvhString, IdFamilia = familiaId, IdPermiso = pa.IdPermiso }, tr);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty("UsuarioPermiso", dvvString, db, tr);

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
    }
}