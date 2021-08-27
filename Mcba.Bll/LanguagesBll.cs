using Mcba.Dal;
using Mcba.Infraestruture.Settings;
using System.Collections.Generic;
using Mcba.Entidad;

namespace Mcba.Bll
{
    public class LanguageBll
    {
        public IEnumerable<Language> GetLanguages()
        {
            return new LanguageDal(McbaSettings.CnnString).GetLanguages();
        }
    }
}
