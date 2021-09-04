using System.Collections.Generic;
using System.Linq;
using Dapper;
using Mcba.Data;

namespace Mcba.Dal
{
    public class CaptionDal
    {
        private const string QRY_CAPTION = @"
            SELECT Leyenda
            FROM Leyendas
            WHERE IdIdioma = @IdIdioma
                AND Modulo = @Modulo
                AND Tag = @Tag
            ";

        private const string QRY_MODULE_CAPTIONS = @"
            SELECT Tag, Leyenda
            FROM Leyendas
            WHERE IdIdioma = @IdIdioma
                AND Modulo = @Modulo
            ";

        private readonly string connectionString;

        public CaptionDal(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public string GetCaption(int idLanguage, string module, string tag)
        {
            string ret;

            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                ret = db.Query<string>(QRY_CAPTION, new {IdIdioma = idLanguage, Modulo = module, Tag = tag})
                    .FirstOrDefault();
            }

            return ret;
        }

        public Dictionary<string, string> GetCaptions(int idLanguage, string module)
        {
            var ret = new Dictionary<string, string>();

            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                ret = db.Query(QRY_MODULE_CAPTIONS, new {IdIdioma = idLanguage, Modulo = module}).ToDictionary(
                    row => (string) row.Tag,
                    row => (string) row.Leyenda);
            }

            return ret;
        }
    }
}