using System.Collections.Generic;
using Dapper;
using Mcba.Data;
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
    }
}
