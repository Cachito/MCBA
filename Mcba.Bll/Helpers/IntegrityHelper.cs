using System;
using Mcba.Dal;
using Mcba.Entidad;
using Mcba.Entidad.Enums;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.Bll.Helpers
{
    public static class IntegrityHelper
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

                case "usuariofamilia":
                    return CheckUsuarioFamilia(table.DV);

                case "usuariopermiso":
                    return CheckUsuarioPermiso(table.DV);

                default:
                    return true;
            }
        }

        private static bool CheckUsuarioPermiso(string dvv)
        {
            var permisoBll = new PermisoBll();
            var usuarioPermisos = permisoBll.GetUsuarioPermisos();

            long dvvTotal = 0;
            foreach (var up in usuarioPermisos)
            {
                var dvhString = DvhCalculator<UsuarioPermiso>.GetDvhString(up, out var dvhValue);
                dvvTotal += dvhValue;
                if (dvhString != up.DV)
                {
                    return false;
                }
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var usuarioPermisoDvv = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            if (usuarioPermisoDvv != dvv)
            {
                return false;
            }

            return true;
        }

        private static bool CheckUsuarioFamilia(string dvv)
        {
            var familiaBll = new FamiliaBll();
            var usuarioFamilias = familiaBll.GetUsuarioFamilias();

            long dvvTotal = 0;
            foreach (var uf in usuarioFamilias)
            {
                var dvhString = DvhCalculator<UsuarioFamilia>.GetDvhString(uf, out var dvhValue);
                dvvTotal += dvhValue;
                if (dvhString != uf.DV)
                {
                    return false;
                }
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var usuarioFamiliaDvv = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            if (usuarioFamiliaDvv != dvv)
            {
                return false;
            }

            return true;
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

        public static bool RepareIntegrity()
        {
            var ret = true;
            var integrityDal = new IntegrityDal(McbaSettings.CnnString);

            var tables = integrityDal.GetTables();
            foreach (var table in tables)
            {
                ret &= Repare(table);
            }

            return ret;
        }

        private static bool Repare(Integrity table)
        {
            switch (table.Tabla.ToLower())
            {
                case "usuario":
                    return RepareUser();

                default:
                    return true;
            }
        }

        private static bool RepareUser()
        {
            return new UserDal(McbaSettings.CnnString).RepareIntegrity();
        }
    }
}
