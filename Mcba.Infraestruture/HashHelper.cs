using System;
using System.Security.Cryptography;
using System.Text;

namespace Mcba.Infraestruture
{
    public static class HashHelper
    {
        public static string Crypt(string word, string salt)
        {
            var sb = new StringBuilder();
            using (var md5 = MD5.Create())
            {
                var encoding = new ASCIIEncoding();
                byte[] stream = null;
                stream = md5.ComputeHash(encoding.GetBytes($"{word}{salt}"));
                for (var i = 0; i < stream.Length; i++)
                {
                    sb.AppendFormat("{0:x2}", i);
                }

                return sb.ToString();
            }
        }

        public static string Base64Encode(string word)
        {
            byte[] byt = Encoding.UTF8.GetBytes(word);
            return Convert.ToBase64String(byt);
        }

        public static string Base64Decode(string word)
        {
            byte[] b = Convert.FromBase64String(word);
            return Encoding.UTF8.GetString(b);
        }
    }
}
