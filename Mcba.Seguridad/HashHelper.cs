using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Mcba.Seguridad
{
    public static class HashHelper
    {
        public static string Crypt(string text, string salt)
        {
            var hasher = new SHA1CryptoServiceProvider();
            var saltedBytes = Encoding.UTF8.GetBytes(string.Concat(text, salt));
            var hashedBytes = hasher.ComputeHash(saltedBytes);
            hasher.Clear();

            return Convert.ToBase64String(hashedBytes);
        }

        public static string Encrypt(string text, string key, string salt)
        {
            var toEncode = $"{text}{salt}";

            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream =
                        new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream) cryptoStream))
                        {
                            streamWriter.Write(toEncode);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string Decrypt(string text, string key, string salt)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(text);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream =
                        new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream) cryptoStream))
                        {
                            var decode = streamReader.ReadToEnd();
                            decode = decode.Remove(decode.Length - salt.Length);

                            return decode;
                        }
                    }
                }
            }
        }

        public static string Base64Encode(string text)
        {
            var encryted = Encoding.Unicode.GetBytes(text);
            var result = Convert.ToBase64String(encryted);
            return result;
        }

        public static string Base64Decode(string text)
        {
            var decryted = Convert.FromBase64String(text);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            var result = Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}