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

        public void UpdateIntegryty(string usuario, IDbConnection db, IDbTransaction tr)
        {
            
        }
    }
}
