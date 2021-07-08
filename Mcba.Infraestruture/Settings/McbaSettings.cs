namespace Mcba.Infraestruture.Settings
{
    public static class McbaSettings
    {
        public static string Salt { set; get; }
        public static string ConnectionString { set; get; }

        public static void MapSettings(InstanceSettings settings)
        {
            Salt = settings.Salt;
            ConnectionString = settings.ConnectionString;
        }
    }
}