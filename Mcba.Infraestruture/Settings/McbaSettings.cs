using Mcba.Infraestruture.Enums;

namespace Mcba.Infraestruture.Settings
{
    public static class McbaSettings
    {
        public static string Key { set; get; }
        public static string Salt { set; get; }
        public static string CnnString { set; get; }
        public static LanguageEnum Language { set; get; }
        public static string MessageTitle { set; get; }
        public static int MaxLoginAttemps { set; get; }
        public static int RandomPassLength { set; get; }
        public static int NumberOfNonAlphanumericCharacters { set; get; }
        public static string EmailFrom { set; get; }
        public static int EmailPort { set; get; }
        public static string EmailHost { set; get; }
        public static bool EmailSsl { set; get; }
        public static string EmailPass { set; get; }
        public static string TempFolder { set; get; }
        public static int DataPagination { set; get; }

        public static void MapSettings(InstanceSettings settings)
        {
            Key = settings.Key;
            Salt = settings.Salt;
            CnnString = settings.CnnString;
            Language = settings.Language;
            MessageTitle = settings.MessageTitle;
            MaxLoginAttemps = settings.MaxLoginAttemps;
            RandomPassLength = settings.RandomPassLength;
            NumberOfNonAlphanumericCharacters = settings.NumberOfNonAlphanumericCharacters;
            EmailFrom = settings.EmailFrom;
            EmailPort = settings.EmailPort;
            EmailHost = settings.EmailHost;
            EmailSsl = settings.EmailSsl;
            EmailPass = settings.EmailPass;
            TempFolder = settings.TempFolder;
            DataPagination = settings.DataPagination;
        }
    }
}