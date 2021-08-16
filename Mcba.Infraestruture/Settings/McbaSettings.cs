namespace Mcba.Infraestruture.Settings
{
    public static class McbaSettings
    {
        public static string Key { set; get; }
        public static string Salt { set; get; }
        public static string CnnString { set; get; }

        public static void MapSettings(InstanceSettings settings)
        {
            Key = settings.Key;
            Salt = settings.Salt;
            CnnString = settings.CnnString;
        }
    }
}