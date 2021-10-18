using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;
using Mcba.Entidad.Dto;

namespace Mcba.Dal
{
    public class PermisoDal
    {
        private const string QRY_PERMISOS_DISPONIBLES_BY_USER = @"
            SELECT 
                Id
                , Nombre
                , [TipoPermiso] = 0
            FROM Permiso
            WHERE Id NOT IN(
                SELECT IdPermiso
                FROM UsuarioPermiso
                WHERE IdUsuario = @IdUsuario
                )
            ORDER BY Nombre
            ";

        //private const string QRY_PERMISOS_ASIGNADOS_BY_USER = @"
        //    SELECT 
        //        P.Id
        //        , P.Nombre
        //        , P.Modulo
        //        , P.Criticidad
        //        , UP.IdTipoPermiso
        //    FROM Permiso P
        //    JOIN UsuarioPermiso UP ON
        //        P.Id = UP.IdPermiso
        //    WHERE UP.IdUsuario = @IdUsuario
        //    ";

        //private const string QRY_USUARIO_PERMISOS_BY_USER = @"
        //    SELECT 
        //        IdUsuario
        //        , IdPermiso
        //        , IdTipoPermiso
        //        , DV
        //    FROM UsuarioPermiso
        //    WHERE 
        //        IdUsuario = @IdUsuario
        //    ";

        private const string QRY_USUARIO_PERMISOS = @"
            SELECT 
                IdUsuario
                , IdPermiso
                , IdTipoPermiso
                , DV
            FROM UsuarioPermiso
            ";

        private readonly string connectionString;

        public PermisoDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<PermisoDto> GetDisponibles(int userId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<PermisoDto>(QRY_PERMISOS_DISPONIBLES_BY_USER, new { IdUsuario = userId});
            }
        }

        //public IEnumerable<PermisoDto> GetAsignados(int userId)
        //{
        //    using (var db = new DataAccess(connectionString).GetOpenConnection())
        //    {
        //        return db.Query<PermisoDto>(QRY_PERMISOS_ASIGNADOS_BY_USER, new { IdUsuario = userId });
        //    }
        //}

        //public IEnumerable<UsuarioPermiso> GetAsignados(int userId, IDbConnection db, IDbTransaction tr)
        //{
        //    return db.Query<UsuarioPermiso>(QRY_USUARIO_PERMISOS_BY_USER, new { IdUsuario = userId }, transaction: tr);
        //}

        public IEnumerable<UsuarioPermiso> GetUsuarioPermisos()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<UsuarioPermiso>(QRY_USUARIO_PERMISOS);
            }
        }

        public IEnumerable<UsuarioPermiso> GetUsuarioPermisos(IDbConnection db, IDbTransaction tr)
        {
            return db.Query<UsuarioPermiso>(QRY_USUARIO_PERMISOS, transaction: tr);
        }

        public IEnumerable<FamiliaPermiso> GetFamiliaPermisos(IDbConnection db, IDbTransaction tr)
        {
            return db.Query<FamiliaPermiso>(QRY_USUARIO_PERMISOS, transaction: tr);
        }
    }
}
