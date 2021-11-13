using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private const string QRY_USUARIO_FAMILIA = @"
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

        private const string QRY_PERMISOS_BY_ID_USUARIO = @"
            SELECT P.Id 
            FROM Permiso P
            WHERE P.Id IN(
                SELECT UP.IdPermiso
                FROM UsuarioPermiso UP
                WHERE UP.IdUsuario = @IdUsuario
                )
            ";

        private const string QRY_PERMISOS_BY_ID_FAMILIA = @"
            SELECT FP.IdPermiso
            FROM FamiliaPermiso FP
            WHERE FP.IdFamilia = @IdFamilia
            ";


        private const string QRY_PERMISO_OTRO_USUARIO_GESTION = @"
            SELECT UP.IdPermiso
            FROM UsuarioPermiso UP
            WHERE 
                UP.IdUsuario <> @IdUsuario
                AND UP.IdPermiso = @IdPermiso
                AND UP.IdTipoPermiso = @IdTipoPermiso     
        ";

        private const string QRY_PERMISO_UNA_FAMILIA_GESTION = @"
            SELECT FP.IdPermiso
            FROM FamiliaPermiso FP
            WHERE FP.IdFamilia IN(
                SELECT UP.IdFamilia
                FROM UsuarioFamilia UP
                WHERE UP.IdUsuario = @IdUsuario
                )
                AND FP.IdPermiso = @IdPermiso
                AND FP.IdTipoPermiso = @IdTipoPermiso  
        ";

        private const string QRY_PERMISO_OTRA_FAMILIA_GESTION = @"
            SELECT FP.IdPermiso
            FROM FamiliaPermiso FP
            WHERE 
                FP.IdFamilia <> @IdFamilia
                AND FP.IdPermiso = @IdPermiso
                AND FP.IdTipoPermiso = @IdTipoPermiso  
                AND (
                    SELECT COUNT(IdUsuario)
                    FROM UsuarioFamilia UF
                    WHERE UF.IdFamilia = FP.IdFamilia
                ) > 0
        ";

        private const string QRY_PERMISO_UN_USUARIO_GESTION = @"
            SELECT UP.IdPermiso
            FROM UsuarioPermiso UP
            WHERE UP.IdUsuario IN(
                SELECT IdUsuario
                FROM UsuarioFamilia UF
                WHERE UF.IdFamilia = @IdFamilia
                )
                AND UP.IdPermiso = @IdPermiso
                AND UP.IdTipoPermiso = @IdTipoPermiso  
        ";

        private const string QRY_PERMISO_USUARIO_GESTION = @"
            SELECT UP.IdPermiso
            FROM UsuarioPermiso UP
            WHERE UP.IdPermiso = @IdPermiso
                AND UP.IdTipoPermiso = @IdTipoPermiso  
        ";

        private const string QRY_OTROS_USUARIOS_FAMILIA = @"
            SELECT UF.IdUsuario
            FROM UsuarioFamilia UF
            WHERE UF.IdFamilia = @IdFamilia
                AND UF.IdUsuario <> @IdUsuario
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

                        IntegrityDal.UpdateIntegrity(TablaIntegridadEnum.UsuarioPermiso, dvvString, db, tr);

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

                        IntegrityDal.UpdateIntegrity(TablaIntegridadEnum.FamiliaPermiso, dvvString, db, tr);

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

                        IntegrityDal.UpdateIntegrity(TablaIntegridadEnum.UsuarioFamilia, dvvString, db, tr);

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

        public bool DejaPermisosHerfanos(int idUsuario)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                var permisosUsuario = db.Query<int>(QRY_PERMISOS_BY_ID_USUARIO, new {IdUsuario = idUsuario}).ToList();

                foreach (var pu in permisosUsuario)
                {
                    // no hay otro usuario con este permiso como gestión
                    var puOtroGestion = db.Query<int>(QRY_PERMISO_OTRO_USUARIO_GESTION,
                            new {IdUsuario = idUsuario, IdPermiso = pu, IdTipoPermiso = (int)TipoPermisoEnum.Gestion})
                        .ToList();
                    if (!puOtroGestion.Any())
                    {
                        return true;
                    }

                    // no hay una familia con otros usuarios con este permiso como gestión
                    //var puOtraFamiliaGestion = db.Query<int>(QRY_PERMISO_OTRA_FAMILIA_GESTION,
                    //        new {IdPermiso = pu, IdTipoPermiso = (int)TipoPermisoEnum.Gestion, IdUsuario = idUsuario})
                    //    .ToList();
                    //if (!puOtraFamiliaGestion.Any())
                    //{
                    //    return true;
                    //}
                }
            }

            return false;
        }

        public bool ValidarRemovePermisoUsuario(int idUsuario, int idPermiso)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                // otro usuario con este permiso como gestión
                var otroGestion = db.Query<int>(QRY_PERMISO_OTRO_USUARIO_GESTION,
                        new
                        {
                            IdUsuario = idUsuario,
                            IdPermiso = idPermiso,
                            IdTipoPermiso = (int)TipoPermisoEnum.Gestion
                        })
                    .ToList();

                // una familia a la que pertenece este usuario que tiene permiso de gestión
                var familiaGestion = db.Query<int>(QRY_PERMISO_UNA_FAMILIA_GESTION,
                        new
                        {
                            IdUsuario = idUsuario,
                            IdPermiso = idPermiso,
                            IdTipoPermiso = (int)TipoPermisoEnum.Gestion
                        })
                    .ToList();

                if (!otroGestion.Any() && !familiaGestion.Any())
                {
                    return false;
                }

                return true;
            }
        }

        public bool ValidarRemovePermisoFamilia(int idFamilia, int idPermiso)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                // otra familia con este permiso como gestión
                var otraGestion = db.Query<int>(QRY_PERMISO_OTRA_FAMILIA_GESTION,
                        new
                        {
                            IdFamilia = idFamilia,
                            IdPermiso = idPermiso,
                            IdTipoPermiso = (int)TipoPermisoEnum.Gestion
                        })
                    .ToList();

                // un usuario tiene permiso de gestión
                var usuarioGestion = db.Query<int>(QRY_PERMISO_USUARIO_GESTION,
                        new
                        {
                            IdPermiso = idPermiso,
                            IdTipoPermiso = (int)TipoPermisoEnum.Gestion
                        })
                    .ToList();

                if (!otraGestion.Any() && !usuarioGestion.Any())
                {
                    return false;
                }

                return true;
            }
        }

        public bool ValidarRemoveUsuarioFamilia(int idFamilia, int idUsuario)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                // ¿La familia tiene otros usuarios?
                var usf = db.Query<int>(QRY_OTROS_USUARIOS_FAMILIA,
                        new
                        {
                            IdFamilia = idFamilia,
                            IdUsuario = idUsuario
                        })
                    .ToList();

                if (usf.Any())
                {
                    return true;
                }

                bool hayAlguienMasConPermiso = true;

                // ¿qué permisos tiene la familia?
                var pfs = db.Query<int>(QRY_PERMISOS_BY_ID_FAMILIA,
                        new
                        {
                            IdFamilia = idFamilia
                        })
                    .ToList();

                foreach (var pf in pfs)
                {
                    // otra familia con este permiso como gestión
                    var pfg = db.Query<int>(QRY_PERMISO_OTRA_FAMILIA_GESTION,
                            new
                            {
                                IdFamilia = idFamilia,
                                IdPermiso = pf,
                                IdTipoPermiso = (int)TipoPermisoEnum.Gestion
                            })
                        .ToList();

                    // un usuario con este permiso de gestión
                    var upg = db.Query<int>(QRY_PERMISO_USUARIO_GESTION,
                            new
                            {
                                IdPermiso = pf,
                                IdTipoPermiso = (int)TipoPermisoEnum.Gestion
                            })
                        .ToList();

                    if (!pfg.Any() && !upg.Any())
                    {
                        hayAlguienMasConPermiso = false;
                        break;
                    }
                }

                if (!hayAlguienMasConPermiso)
                {
                    return false;
                }
            }

            return true;
        }

        public bool ValidarDeleteFamilia(int idFamilia)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                bool hayAlguienMasConPermiso = true;

                // ¿qué permisos tiene la familia?
                var pfs = db.Query<int>(QRY_PERMISOS_BY_ID_FAMILIA,
                        new
                        {
                            IdFamilia = idFamilia
                        })
                    .ToList();

                foreach (var pf in pfs)
                {
                    // otra familia con este permiso como gestión
                    var pfg = db.Query<int>(QRY_PERMISO_OTRA_FAMILIA_GESTION,
                            new
                            {
                                IdFamilia = idFamilia,
                                IdPermiso = pf,
                                IdTipoPermiso = (int)TipoPermisoEnum.Gestion
                            })
                        .ToList();

                    // un usuario con este permiso de gestión
                    var upg = db.Query<int>(QRY_PERMISO_USUARIO_GESTION,
                            new
                            {
                                IdPermiso = pf,
                                IdTipoPermiso = (int)TipoPermisoEnum.Gestion
                            })
                        .ToList();

                    if (!pfg.Any() && !upg.Any())
                    {
                        hayAlguienMasConPermiso = false;
                        break;
                    }
                }

                if (!hayAlguienMasConPermiso)
                {
                    return false;
                }
            }

            return true;
        }
    }
}