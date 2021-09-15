using System;
using Mcba.Dal;
using Mcba.Entidad;
using Mcba.Entidad.Enums;
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
            long dvvTotal = 0;
            foreach (var user in users)
            {
                var dvhString = DvhCalculator<User>.GetDvhString(user, out var dvhValue);
                dvvTotal += dvhValue;
                if (dvhString != user.DV)
                {
                    return false;
                }
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var userDvv = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            if (userDvv != dvv)
            {
                return false;
            }

            return true;
        }
    }
}
