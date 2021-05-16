using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

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

        public static byte[] EncryptCsp(string data)
        {
            // Create a new DESCryptoServiceProvider object
            // to generate a key and initialization vector (IV).
            DESCryptoServiceProvider cryptProvider = new DESCryptoServiceProvider();
            byte[] key = cryptProvider.Key;
            byte[] iv = cryptProvider.IV;

            byte[] ret;

            // Create a MemoryStream.
            using (MemoryStream mStream = new MemoryStream())
            {
                // Create a CryptoStream using the MemoryStream
                // and the passed key and initialization vector (IV).
                using (CryptoStream cStream = new CryptoStream(mStream, new DESCryptoServiceProvider().CreateEncryptor(key, iv), CryptoStreamMode.Write))
                {
                    // Convert the passed string to a byte array.
                    byte[] toEncrypt = new ASCIIEncoding().GetBytes(data);

                    // Write the byte array to the crypto stream and flush it.
                    cStream.Write(toEncrypt, 0, toEncrypt.Length);
                    cStream.FlushFinalBlock();

                    // Get an array of bytes from the
                    // MemoryStream that holds the
                    // encrypted data.
                    ret = mStream.ToArray();

                    // Close the streams.
                    cStream.Close();
                    mStream.Close();
                }
            }

            // Return the encrypted buffer.
            return ret;
        }

        public static string DecryptCsp(byte[] data, byte[] key, byte[] iv)
        {
            // Create a new MemoryStream using the passed
            // array of encrypted data.
            using (MemoryStream msDecrypt = new MemoryStream(data))
            {
                // Create a CryptoStream using the MemoryStream
                // and the passed key and initialization vector (IV).
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, new DESCryptoServiceProvider().CreateDecryptor(key, iv), CryptoStreamMode.Read))
                {
                    // Create buffer to hold the decrypted data.
                    byte[] fromEncrypt = new byte[data.Length];

                    // Read the decrypted data out of the crypto stream
                    // and place it into the temporary buffer.
                    csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

                    //Convert the buffer into a string and return it.
                    return new ASCIIEncoding().GetString(fromEncrypt);
                }
            }
        }
    }
}
