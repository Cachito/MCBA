using System.Collections.Generic;
using Mcba.Dal;
using Mcba.Infraestruture.Enums;
using Mcba.Infraestruture.Settings;

namespace Mcba.Infraestruture
{
    public class Captions
    {
        public static string GetCaption(LanguageEnum language, string module, string tag)
        {
            var captionsDal = new CaptionDal(McbaSettings.CnnString);
            return captionsDal.GetCaption((int) language, module, tag);
        }

        public static Dictionary<string, string> GetCaptions(LanguageEnum language, string module)
        {
            var captionsDal = new CaptionDal(McbaSettings.CnnString);
            return captionsDal.GetCaptions((int)language, module);
        }
    }
}