using System;
using Mcba.Dal;
using Mcba.Entidad;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.Bll
{
    public class IntegrityBll
    {
        public static bool CheckIntegrity()
        {
            var ret = true;
            var integrityDal = new IntegrityDal(McbaSettings.CnnString);

            var tables = integrityDal.GetTables();
            foreach (var table in tables)
            {
                ret &= Check(table);
            }

            return ret;
        }

        private static bool Check(Integrity table)
        {
            switch (table.Tabla.ToLower())
            {
                case "usuario":
                    return CheckUser(table.DV);

                default:
                    return true;
            }
        }

        private static bool CheckUser(string dvv)
        {
            var userDal = new UserDal(McbaSettings.CnnString);

            var users = userDal.GetAll();
            long dvTableValue = 0;
            foreach (var user in users)
            {
                var dvString = DvhHelper<User>.GetDvhString(user, out var dvValue);
                dvTableValue += dvValue;
                if (dvString != user.DV)
                {
                    return false;
                }
            }

            var userDvv = HashHelper.GetCryptString(dvTableValue.ToString(), CryptMethodEnum.Sha1);

            if (userDvv != dvv)
            {
                return false;
            }

            return true;
        }
    }
}
