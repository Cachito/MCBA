using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Mcba.Data;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using Mcba.Entidad.Enums;
using Mcba.Seguridad;

namespace Mcba.Dal
{
    public class PermisoDal
    {
        private const string QRY_PERMISOS_DISPONIBLES_BY_USER = @"
            SELECT 
                Id
                , Nombre
                , [TipoPermiso] = 0
            FROM Permiso
            WHERE Id NOT IN(
                SELECT IdPermiso
                FROM UsuarioPermiso
                WHERE IdUsuario = @IdUsuario
                )
            ORDER BY Nombre
            ";

        private const string QRY_USUARIO_PERMISOS = @"
            SELECT 
                IdUsuario
                , IdPermiso
                , IdTipoPermiso
                , DV
            FROM UsuarioPermiso
            ";

        private const string QRY_FAMILIA_PERMISOS = @"
            SELECT 
                IdFamilia
                , IdPermiso
                , IdTipoPermiso
                , DV
            FROM FamiliaPermiso
            ";

        private const string QRY_USUARIO_FAMILIA= @"
            SELECT
                IdUsuario
                , IdFamilia
                , DV
            FROM UsuarioFamilia
            ";

        private const string QRY_UPDATE_UP_DV_BY_IDS = @"
            UPDATE UsuarioPermiso SET
                DV = @Dv
            WHERE 
                IdUsuario = @IdUsuario
                AND IdPermiso = @IdPermiso
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

        private readonly string connectionString;

        public PermisoDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<PermisoDto> GetDisponibles(int userId)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<PermisoDto>(QRY_PERMISOS_DISPONIBLES_BY_USER, new {IdUsuario = userId});
            }
        }

        public IEnumerable<UsuarioPermiso> GetUsuarioPermisos()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<UsuarioPermiso>(QRY_USUARIO_PERMISOS);
            }
        }

        public IEnumerable<UsuarioPermiso> GetUsuarioPermisos(IDbConnection db, IDbTransaction tr)
        {
            return db.Query<UsuarioPermiso>(QRY_USUARIO_PERMISOS, transaction: tr);
        }

        public IEnumerable<FamiliaPermiso> GetFamiliaPermisos(IDbConnection db, IDbTransaction tr)
        {
            return db.Query<FamiliaPermiso>(QRY_FAMILIA_PERMISOS, transaction: tr);
        }

        public IEnumerable<FamiliaPermiso> GetFamiliaPermisos()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<FamiliaPermiso>(QRY_FAMILIA_PERMISOS);
            }
        }

        public IEnumerable<UsuarioFamilia> GetUsuarioFamilia(IDbConnection db, IDbTransaction tr)
        {
            return db.Query<UsuarioFamilia>(QRY_USUARIO_FAMILIA, transaction: tr);
        }

        public bool RepareUsuarioPermisoIntegrity()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        var ups = GetUsuarioPermisos(db, tr);
                        long dvvTotal = 0;
                        foreach (var up in ups)
                        {
                            var dvhString = DvhCalculator<UsuarioPermiso>.GetDvhString(up, out var dvhValue);
                            db.Execute(QRY_UPDATE_UP_DV_BY_IDS,
                                new {Dv = dvhString, IdUsuario = up.IdUsuario, IdPermiso = up.IdPermiso}, tr);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty(TablaIntegridadEnum.UsuarioPermiso, dvvString, db, tr);

                        tr.Commit();

                        return true;
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool RepareFamiliaPermisoIntegrity()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        var fps = GetFamiliaPermisos(db, tr);
                        long dvvTotal = 0;
                        foreach (var fp in fps)
                        {
                            var dvhString = DvhCalculator<FamiliaPermiso>.GetDvhString(fp, out var dvhValue);
                            db.Execute(QRY_UPDATE_FP_DV_BY_IDS,
                                new {Dv = dvhString, IdFamilia = fp.IdFamilia, IdPermiso = fp.IdPermiso}, tr);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty(TablaIntegridadEnum.FamiliaPermiso, dvvString, db, tr);

                        tr.Commit();

                        return true;
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool RepareUsuarioFamiliaIntegrity()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        var ufs = GetUsuarioFamilia(db, tr);
                        long dvvTotal = 0;
                        foreach (var uf in ufs)
                        {
                            var dvhString = DvhCalculator<UsuarioFamilia>.GetDvhString(uf, out var dvhValue);
                            db.Execute(QRY_UPDATE_UF_DV_BY_IDS,
                                new {Dv = dvhString, IdUsuario = uf.IdUsuario, IdFamilia = uf.IdFamilia}, tr);
                            dvvTotal += dvhValue;
                        }

                        var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
                        var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

                        IntegrityDal.UpdateIntegryty(TablaIntegridadEnum.UsuarioFamilia, dvvString, db, tr);

                        tr.Commit();

                        return true;
                    }
                    catch
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}