using System.Collections.Generic;
using Mcba.Dal;
using Mcba.Infraestruture.Settings;

namespace Mcba.Infraestruture
{
    public class Captions
    {
        public static string GetCaption(int idLanguage, string module, string tag)
        {
            var captionsDal = new CaptionDal(McbaSettings.CnnString);
            return captionsDal.GetCaption(idLanguage, module, tag);
        }

        public static Dictionary<string, string> GetCaptions(int idLanguage, string module)
        {
            var captionsDal = new CaptionDal(McbaSettings.CnnString);
            return captionsDal.GetCaptions(idLanguage, module);
        }
    }
}