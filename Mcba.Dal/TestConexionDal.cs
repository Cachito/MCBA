using Dapper;
using Mcba.Data;
using Mcba.Entidad;

namespace Mcba.Dal
{
    public class TestConexionDal
    {
        private readonly string connectionString;

        public TestConexionDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool TestConexion()
        {
            try
            {
                using (var db = new DataAccess(connectionString).GetOpenConnection())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
