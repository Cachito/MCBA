using System.Text.RegularExpressions;
using Mcba.Infraestruture.Settings;

namespace Mcba.Infraestruture.Helpers
{
    public static class BaseDataHelper
    {
        private static readonly Regex ReBase = new Regex(@"(Initial Catalog=|Database=){1}([\w-]+)[;]?", RegexOptions.Compiled);
        private static readonly Regex ReServer = new Regex(@"(Data Source=){1}([\w-]+\\[\w-]+)[;]?", RegexOptions.Compiled);

        public static string GetString()
        {
            var nombreBase = ReBase.Match(McbaSettings.CnnString).Groups[2].Value;
            var nombreServer = ReServer.Match(McbaSettings.CnnString).Groups[2].Value;

            return $"[{nombreServer}] / [{nombreBase}]";
        }

        public static string GetDataBaseName()
        {
            var nombreBase = ReBase.Match(McbaSettings.CnnString).Groups[2].Value;

            return nombreBase;
        }

        public static string GetServerName()
        {
            var nombreServer = ReServer.Match(McbaSettings.CnnString).Groups[2].Value;

            return nombreServer;
        }
    }
}