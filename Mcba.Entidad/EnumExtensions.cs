using System;
using System.Data;

namespace Mcba.Entidad
{
    public static class EnumExtensions
    {
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
