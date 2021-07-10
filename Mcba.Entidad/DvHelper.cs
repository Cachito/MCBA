using System;
using System.Text;

namespace Mcba.Infraestruture
{
    public static class DvHelper<T>
    {
        public static string GetDvString(T instancia)
        {
            var ret = new StringBuilder();

            var props = instancia.GetType().GetProperties();
            for (var i = 0; i < props.Length; i++)
            {
                var value = props[i].GetValue(instancia, null);
                switch (props[i].PropertyType.Name)
                {
                    case "DateTime":
                        ret.Append($"{(DateTime) value:yyyyMMddHHmmss.fffffff}");
                        continue;

                    case "Boolean":
                        ret.Append($"{((bool) value ? "true" : "false")}");
                        continue;

                    case "Single":
                    case "Double":
                    case "Decimal":
                        ret.Append($"{value:#.00000000}");
                        continue;

                    default:
                        ret.Append($"{value}");
                        break;
                }
            }

            return ret.ToString();
        }
    }
}