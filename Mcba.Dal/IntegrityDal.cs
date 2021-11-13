using System.Collections.Generic;
using System.Data;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;
using Mcba.Entidad.Enums;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.Dal
{
    public class IntegrityDal
    {
        private const string QRY_INTEGRITY = @"
            SELECT 
                Id
                , Tabla
                , DV
            FROM Integridad
            ";

        private const string QRY_UPDATE_INTEGRITY = @"
            UPDATE Integridad SET
                DV = @Dv
            WHERE Tabla = @Tabla
            ";


        private const string QRY_UPDATE_FP_DV_BY_IDS = @"
            UPDATE FamiliaPermiso SET
                DV = @Dv
            WHERE 
                IdFamilia = @IdFamilia
                AND IdPermiso = @IdPermiso
            ";

        private const string QRY_UPDATE_UF_DV_BY_IDS = @"
            UPDATE UsuarioFamilia SET
                DV = @Dv
            WHERE 
                IdUsuario = @IdUsuario
                AND IdFamilia = @IdFamilia
            ";

        private const string QRY_UPDATE_UP_DV_BY_IDS = @"
            UPDATE UsuarioPermiso SET
                DV = @Dv
            WHERE 
                IdUsuario = @IdUsuario
                AND IdPermiso = @IdPermiso
            ";

        private readonly string connectionString;

        public IntegrityDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<Integrity> GetTables()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<Integrity>(QRY_INTEGRITY);
            }
        }

        public void RepareFamiliaPermisoIntegrity(IDbConnection db, IDbTransaction tr)
        {
            PermisoDal permisoDal = new PermisoDal(McbaSettings.CnnString);

            var fps = permisoDal.GetFamiliaPermisos(db, tr);
            long dvvTotal = 0;
            foreach (var fp in fps)
            {
                var dvhString = DvhCalculator<FamiliaPermiso>.GetDvhString(fp, out var dvhValue);
                db.Execute(QRY_UPDATE_FP_DV_BY_IDS,
                    new { Dv = dvhString, IdFamilia = fp.IdFamilia, IdPermiso = fp.IdPermiso }, tr);
                dvvTotal += dvhValue;
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            UpdateIntegrity(TablaIntegridadEnum.FamiliaPermiso, dvvString, db, tr);
        }

        public void RepareUsuarioFamiliaIntegrity(IDbConnection db, IDbTransaction tr)
        {
            PermisoDal permisoDal = new PermisoDal(McbaSettings.CnnString);

            var ufs = permisoDal.GetUsuarioFamilia(db, tr);
            long dvvTotal = 0;
            foreach (var uf in ufs)
            {
                var dvhString = DvhCalculator<UsuarioFamilia>.GetDvhString(uf, out var dvhValue);
                db.Execute(QRY_UPDATE_UF_DV_BY_IDS,
                    new { Dv = dvhString, IdUsuario = uf.IdUsuario, IdFamilia = uf.IdFamilia }, tr);
                dvvTotal += dvhValue;
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            UpdateIntegrity(TablaIntegridadEnum.UsuarioFamilia, dvvString, db, tr);
        }

        public void RepareUsuarioPermisoIntegrity(IDbConnection db, IDbTransaction tr)
        {
            PermisoDal permisoDal = new PermisoDal(McbaSettings.CnnString);

            var ups = permisoDal.GetUsuarioPermisos(db, tr);
            long dvvTotal = 0;
            foreach (var up in ups)
            {
                var dvhString = DvhCalculator<UsuarioPermiso>.GetDvhString(up, out var dvhValue);
                db.Execute(QRY_UPDATE_UP_DV_BY_IDS,
                    new { Dv = dvhString, IdUsuario = up.IdUsuario, IdPermiso = up.IdPermiso }, tr);
                dvvTotal += dvhValue;
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            UpdateIntegrity(TablaIntegridadEnum.UsuarioPermiso, dvvString, db, tr);
        }

        public static void UpdateIntegrity(TablaIntegridadEnum tabla, string dvvString, IDbConnection db, IDbTransaction tr)
        {
            db.Execute(QRY_UPDATE_INTEGRITY, new {Dv = dvvString, Tabla = tabla.GetStringValue()}, tr);
        }
    }
}
