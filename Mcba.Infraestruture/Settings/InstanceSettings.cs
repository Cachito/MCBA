using Mcba.Infraestruture.Enums;

namespace Mcba.Infraestruture.Settings
{
    public class InstanceSettings
    {
        public string Key { set; get; }
        public string Salt { set; get; }
        public string CnnString { set; get; }
        public LanguageEnum Language { set; get; }
        public string MessageTitle { set; get; }
    }
}