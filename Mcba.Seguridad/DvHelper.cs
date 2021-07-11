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
            var ret = new StringBuilder();

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

                ret.Append(GetCryptString(stringValue, attr));
            }

            return ret.ToString();
        }

        private static string GetCryptString(string cadena, object[] attr)
        {
            var ret = cadena;

            var crypt = false;
            var cryptMethod = CryptMethodEnum.Base64;

            if (attr.Length > 0)
            {
                crypt = true;
                
                if (((CryptMethodAttribute)attr[0]).CryptMethod == CryptMethodEnum.Base64)
                {
                    cryptMethod = CryptMethodEnum.Base64;
                }

                if (((CryptMethodAttribute)attr[0]).CryptMethod == CryptMethodEnum.Md5)
                {
                    cryptMethod = CryptMethodEnum.Md5;
                }
            }

            if (!crypt)
            {
                ret = cadena;
            }

            if (crypt && cryptMethod == CryptMethodEnum.Base64)
            {
                ret = HashHelper.Base64Encode(cadena, McbaSettings.Salt);
            }

            if (crypt && cryptMethod == CryptMethodEnum.Md5)
            {
                ret = HashHelper.Crypt(cadena, McbaSettings.Salt);
            }

            return ret;
        }
    }
}