using Mcba.Infraestruture.Enums;

namespace Mcba.Infraestruture.Settings
{
    public static class McbaSettings
    {
        public static string Key { set; get; }
        public static string Salt { set; get; }
        public static string CnnString { set; get; }
        public static LanguageEnum Language { set; get; }

        public static void MapSettings(InstanceSettings settings)
        {
            Key = settings.Key;
            Salt = settings.Salt;
            CnnString = settings.CnnString;
            Language = settings.Language;
        }
    }
}