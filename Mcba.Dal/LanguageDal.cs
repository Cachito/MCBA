using System.Collections.Generic;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;

namespace Mcba.Dal
{
    public class LanguageDal
    {
        private const string QRY_LANGUAGES = @"
            SELECT 
                Id
                , Descripcion
            FROM Idioma
            ORDER BY Descripcion
            ";

        private readonly string connectionString;

        public LanguageDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<Language> GetLanguages()
        {
            IEnumerable<Language> ret;

            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                ret = db.Query<Language>(QRY_LANGUAGES);
            }

            return ret;
        }
    }
}