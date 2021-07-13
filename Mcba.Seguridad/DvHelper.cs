using System;
using System.Text;
using Mcba.Entidad;
using Mcba.Entidad.Attributes;
using Mcba.Infraestruture.Settings;

namespace Mcba.Seguridad
{
    public static class DvHelper<T>
    {
        public static string GetDvhString(T instancia)
        {
            var ret = string.Empty;

            var dvBuilder = new StringBuilder();

            var props = instancia.GetType().GetProperties();

            for (var i = 0; i < props.Length; i++)
            {
                var value = props[i].GetValue(instancia, null);
                var attr = props[i].GetCustomAttributes(typeof(CryptMethodAttribute), false);

                string stringValue;
                switch (props[i].PropertyType.Name)
                {
                    case "DateTime":
                        stringValue = $"{(DateTime) value:yyyyMMddHHmmss.fffffff}";
                        break;

                    case "Boolean":
                        stringValue = $"{((bool) value ? "true" : "false")}";
                        break;

                    case "Single":
                    case "Double":
                    case "Decimal":
                        stringValue = $"{value:#.00000000}";
                        break;

                    default:
                        stringValue = $"{value}";
                        break;
                }

                var cryptMethod = GetCryptMethod(attr);

                var cryptString = GetCryptString(stringValue, cryptMethod);

                dvBuilder.Append(cryptString);
            }

            var dvValue = GetDvValue(dvBuilder.ToString());

            ret = GetCryptString(dvValue, CryptMethodEnum.Md5);

            return ret;
        }

        private static CryptMethodEnum GetCryptMethod(object[] attr)
        {
            var ret = CryptMethodEnum.None;

            if (attr.Length > 0)
            {
                if (((CryptMethodAttribute) attr[0]).CryptMethod == CryptMethodEnum.Base64)
                {
                    ret = CryptMethodEnum.Base64;
                }

                if (((CryptMethodAttribute) attr[0]).CryptMethod == CryptMethodEnum.Md5)
                {
                    ret = CryptMethodEnum.Md5;
                }
            }

            return ret;
        }

        private static string GetDvValue(string dvString)
        {
            var asciiBytes = Encoding.ASCII.GetBytes(dvString);
            var sum = 0;

            foreach (byte b in asciiBytes)
            {
                sum += b;
            }

            return sum.ToString();
        }

        private static string GetCryptString(string cadena, CryptMethodEnum cryptMethod)
        {
            var ret = cadena;

            switch (cryptMethod)
            {
                case CryptMethodEnum.None:
                    ret = cadena;
                    break;

                case CryptMethodEnum.Base64:
                    ret = HashHelper.Base64Encode(cadena, McbaSettings.Salt);
                    break;

                case CryptMethodEnum.Md5:
                    ret = HashHelper.Crypt(cadena, McbaSettings.Salt);
                    break;
            }

            return ret;
        }
    }
}