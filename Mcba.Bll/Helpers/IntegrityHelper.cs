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

                case "familiapermiso":
                    return CheckFamiliaPermiso(table.DV);

                case "bitacora":
                    return CheckBitacora(table.DV);

                default:
                    return true;
            }
        }

        private static bool CheckBitacora(string dvv)
        {
            var bitacoraBll = new BitacoraBll();
            var bitacoras = bitacoraBll.GetBitacoras();

            long dvvTotal = 0;
            foreach (var bitacora in bitacoras)
            {
                var dvhString = DvhCalculator<Bitacora>.GetDvhString(bitacora, out var dvhValue);
                dvvTotal += dvhValue;
                if (dvhString != bitacora.DV)
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

        private static bool CheckFamiliaPermiso(string dvv)
        {
            var permisoBll = new PermisoBll();
            var familiaPermisos = permisoBll.GetFamiliaPermisos();

            long dvvTotal = 0;
            foreach (var fp in familiaPermisos)
            {
                var dvhString = DvhCalculator<FamiliaPermiso>.GetDvhString(fp, out var dvhValue);
                dvvTotal += dvhValue;
                if (dvhString != fp.DV)
                {
                    return false;
                }
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var familiaPermisoDvv = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            if (familiaPermisoDvv != dvv)
            {
                return false;
            }

            return true;
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

        public static bool RepareIntegrity(string cnnString)
        {
            var ret = true;
            var integrityDal = new IntegrityDal(cnnString);

            var tables = integrityDal.GetTables();
            foreach (var table in tables)
            {
                ret &= Repare(table, cnnString);
            }

            return ret;
        }

        private static bool Repare(Integrity table, string cnnString)
        {
            switch (table.Tabla.ToLower())
            {
                case "usuario":
                    return RepareUser(cnnString);

                case "usuariofamilia":
                    return RepareUsuarioFamilia(cnnString);

                case "usuariopermiso":
                    return RepareUsuarioPermiso(cnnString);

                case "familiapermiso":
                    return RepareFamiliaPermiso(cnnString);

                case "bitacora":
                    return RepareBitacora(cnnString);

                default:
                    return true;
            }
        }

        private static bool RepareBitacora(string cnnString)
        {
            return new BitacoraDal(cnnString).RepareIntegrity();
        }

        private static bool RepareUsuarioPermiso(string cnnString)
        {
            return new PermisoDal(cnnString).RepareUsuarioPermisoIntegrity();
        }

        private static bool RepareUsuarioFamilia(string cnnString)
        {
            return new PermisoDal(cnnString).RepareUsuarioFamiliaIntegrity();
        }

        private static bool RepareFamiliaPermiso(string cnnString)
        {
            return new PermisoDal(cnnString).RepareFamiliaPermisoIntegrity();
        }

        private static bool RepareUser(string cnnString)
        {
            return new UserDal(cnnString).RepareIntegrity();
        }
    }
}
