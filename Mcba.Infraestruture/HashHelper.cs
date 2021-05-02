using System;
using System.Text;
using System.Security.Cryptography;

namespace Mcba.Infraestruture
{
    public static class HashHelper
    {
        public static string MD5(string word)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(word));
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }

            return sb.ToString();
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
