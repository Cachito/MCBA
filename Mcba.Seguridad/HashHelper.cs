using System;
using System.Security.Cryptography;
using System.Text;

namespace Mcba.Seguridad
{
    public static class HashHelper
    {
        public static string Crypt(string word, string salt = "Cacho")
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

        public static string Base64Encode(string word, string salt = "Cacho", bool useSalt = true)
        {
            var toEncode = useSalt ? $"{word}{salt}" : word;
            byte[] byt = Encoding.UTF8.GetBytes(toEncode);
            
            return Convert.ToBase64String(byt);
        }

        public static string Base64Decode(string word, string salt = "Cacho", bool useSalt = true)
        {
            var b = Convert.FromBase64String($"{word}");
            var decode = Encoding.UTF8.GetString(b);

            decode = useSalt ? decode.Remove(decode.Length - salt.Length) : decode;

            return decode;
        }
    }
}
