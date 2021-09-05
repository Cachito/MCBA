using System;
using System.Text;
using Mcba.Entidad;
using Mcba.Entidad.Attributes;

namespace Mcba.Seguridad
{
    public static class DvhHelper<T>
    {
        public static string GetDvhString(T instancia, out long dvValue)
        {
            var ret = string.Empty;

            var dvhString = new StringBuilder();

            var props = instancia.GetType().GetProperties();

            for (var i = 0; i < props.Length; i++)
            {
                var value = props[i].GetValue(instancia, null);
                var attr = props[i].GetCustomAttributes(typeof(CryptMethodAttribute), false);

                var cryptMethod = GetCryptMethod(attr);
                if (cryptMethod == CryptMethodEnum.Ignore)
                {
                    continue;
                }

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

                var cryptString = HashHelper.GetCryptString(stringValue, cryptMethod);

                dvhString.Append(cryptString);
            }

            dvValue = DvValue.GetDvValue(dvhString.ToString());

            ret = HashHelper.GetCryptString(dvValue.ToString(), CryptMethodEnum.Sha1);

            return ret;
        }

        private static CryptMethodEnum GetCryptMethod(object[] attr)
        {
            var ret = CryptMethodEnum.None;

            if (attr.Length > 0)
            {
                switch (((CryptMethodAttribute)attr[0]).CryptMethod)
                {
                    case CryptMethodEnum.Base64:
                        ret = CryptMethodEnum.Base64;
                        break;

                    case CryptMethodEnum.Aes:
                        ret = CryptMethodEnum.Aes;
                        break;

                    case CryptMethodEnum.Sha1:
                        ret = CryptMethodEnum.Sha1;
                        break;

                    case CryptMethodEnum.Ignore:
                        ret = CryptMethodEnum.Ignore;
                        break;
                }
            }

            return ret;
        }
    }
}