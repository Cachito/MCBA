using System;
using System.Data;
using System.Reflection;
using Mcba.Entidad.Attributes;

namespace Mcba.Entidad
{
    public static class EnumExtensions
    {
        public static string GetStringValue(this Enum value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // Get the stringvalue attributes
            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];

            // Return the first if there was a match.
            return attribs?.Length > 0 ? attribs[0].StringValue : null;
        }

        public static DataTable EnumToDataTable(this Type enumType)
        {
            DataTable table = new DataTable();

            //Column that contains the Captions/Keys of Enum        
            table.Columns.Add("Desc", typeof(string));
            //Get the type of ENUM for DataColumn
            table.Columns.Add("Id", Enum.GetUnderlyingType(enumType));
            //Add the items from the enum:
            foreach (var name in Enum.GetNames(enumType))
            {
                //Replace underscores with space from caption/key and add item to collection:
                table.Rows.Add(name.Replace('_', ' '), Enum.Parse(enumType, name));
            }

            return table;
        }
    }
}
