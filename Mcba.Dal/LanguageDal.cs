using System.Collections.Generic;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;

namespace Mcba.Dal
{
    public class LanguageDal : DataAccess
    {
        private const string QRY_LANGUAGES = @"
            SELECT 
                Id
                , Descripcion
            FROM Idioma
            ORDER BY Descripcion
            ";

        public LanguageDal(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Language> GetLanguages()
        {
            IEnumerable<Language> ret;

            using (var db = GetOpenConnection())
            {
                ret = db.Query<Language>(QRY_LANGUAGES);
            }

            return ret;
        }
    }
}