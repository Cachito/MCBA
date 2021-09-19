using System.Collections.Generic;
using System.Data;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;

namespace Mcba.Dal
{
    public class IntegrityDal
    {
        private const string QRY_INTEGRITY = @"
            SELECT 
                Id
                , Tabla
                , DV
            FROM Integridad
            ";

        private const string QRY_UPDATE_INTEGRITY = @"
            UPDATE Integridad SET
                DV = @Dv
            WHERE Tabla = @Tabla
            ";

        private readonly string connectionString;

        public IntegrityDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<Integrity> GetTables()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<Integrity>(QRY_INTEGRITY);
            }
        }

        public static void UpdateIntegryty(string tabla, string dvvString, IDbConnection db, IDbTransaction tr)
        {
            db.Execute(QRY_UPDATE_INTEGRITY, new {Dv = dvvString, Tabla = tabla}, tr);
        }
    }
}
