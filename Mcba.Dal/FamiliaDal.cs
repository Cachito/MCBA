using Mcba.Data;
using Dapper;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using Mcba.Entidad;
using Mcba.Entidad.Dto;

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

        private const string QRY_USUARIO_FAMILIAS = @"
            SELECT 
                IdUsuario
                , IdFamilia
                , DV
            FROM UsuarioFamilia
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

        public IEnumerable<FamiliaDto> GetAsignadas(int userId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<FamiliaDto>(QRY_FAMILIAS_ASIGNADAS_BY_USER, new { IdUsuario = userId });
            }
        }

        public IEnumerable<UsuarioFamilia> GetAsignadas(int userId, IDbConnection db, IDbTransaction tr)
        {
            return db.Query<UsuarioFamilia>(QRY_USUARIO_FAMILIAS_BY_USER, new {IdUsuario = userId}, transaction: tr);
        }

        public IEnumerable<UsuarioFamilia> GetUsuarioFamilias()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<UsuarioFamilia>(QRY_USUARIO_FAMILIAS);
            }
        }
    }
}