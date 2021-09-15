using System;
using System.Text.RegularExpressions;
using Mcba.Dal;
using Mcba.Infraestruture.Settings;

namespace Mcba.Bll
{
    public static class UserNameGenerator
    {
        private static int suffix;

        public static string GetUsername(string name, string surname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                return string.Empty;
            }

            var userDal = new UserDal(McbaSettings.CnnString);
            suffix = 0;

            try
            {
                var loop = 1;
                var userName = GenerateLogin(name, surname, loop);

//#if DEBUG
//                Random r = new Random();
//                int rInt = r.Next(0, 100);
//                while (loop < rInt)
//                {
//                    loop++;
//                    userName = GenerateLogin(name, surname, loop);
//                }
//#else
                while (userDal.LoginExists(userName))
                {
                    loop++;

                    GenerateLogin(name, surname, loop);
                }
//#endif                
                return userName;
            }
            catch
            {
                return string.Empty;
            }
        }

        private static string GenerateLogin(string name, string surname, int loop)
        {
            var names = Regex.Replace(name, @"\s", "");
            var surnames = surname.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (loop > names.Length)
            {
                loop = names.Length;
                suffix++;
            }

            var userNameStart = names.Substring(0, loop);
            var userNameEnd = surnames[0];

            var ret = $"{userNameStart}{userNameEnd}{(suffix > 0 ? suffix.ToString("000") : string.Empty)}".ToLower();
            return ret;
        }
    }
}
