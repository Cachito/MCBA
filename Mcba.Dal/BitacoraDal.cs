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
    public class BitacoraDal
    {
        private const string QRY_INSERT_BITACORA = @"
            INSERT INTO Bitacora(FechaHora, Patente, Descripcion, Criticidad, Login, DV)
                OUTPUT INSERTED.Id
                VALUES(@FechaHora, @Patente, @Descripcion, @Criticidad, @Login, '')
            ";

        private const string QRY_GET_BITACORAS = @"
            SELECT 
                FechaHora
                , Patente
                , Descripcion
                , Criticidad  
                , Login
                , DV
            FROM Bitacora
            ";

        private const string QRY_GET_BITACORAS_BY_LOGIN_AND_CRIT = @"
            SELECT 
                FechaHora
                , Patente
                , Descripcion
                , Criticidad  
            FROM Bitacora    
            WHERE 
                Login = @Login
                AND(
                    @Criticidad = -1
                    OR
                    Criticidad = @Criticidad
                )
            ORDER BY FechaHora DESC
            ";

        private const string QRY_UPDATE_DV_BY_ID = @"
            UPDATE Bitacora SET
                DV = @Dv
            WHERE Id = @Id
            ";

        private const string QRY_GET_BITACORA_BY_ID = @"
            SELECT 
                FechaHora
                , Patente
                , Descripcion
                , Criticidad
                , Login
                , DV
            FROM Bitacora 
            WHERE Id = @Id
            ";

        private const string QRY_GET_ALL_BITACORAS = @"
            SELECT FechaHora, Patente, Descripcion, Criticidad, Login, DV
            FROM Bitacora 
            ";
        
        private readonly string connectionString;

        public BitacoraDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Registrar(Bitacora bitacora)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    Registrar(bitacora, db, tr);
                }
            }
        }

        public void Registrar(Bitacora bitacora, IDbConnection db, IDbTransaction tr)
        {
            var idBitacora = db.QuerySingle<int>(QRY_INSERT_BITACORA,
                new
                {
                    FechaHora = bitacora.FechaHora, Patente = bitacora.Patente, Descripcion = bitacora.Descripcion,
                    Criticidad = bitacora.Criticidad, Login = bitacora.Login
                }, transaction: tr);

            UpdateIntegrity(idBitacora, db, tr);
        }

        public IEnumerable<Bitacora> GetBitacoras()
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                return db.Query<Bitacora>(QRY_GET_BITACORAS);
            }
        }

        public IEnumerable<BitacoraDto> GetBitacoras(int idUsuario, int criticidad)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                using (var tr = db.BeginTransaction())
                {
                    try
                    {
                        var userDal = new UserDal(connectionString);
                        var user = userDal.GetUserById(idUsuario, db, tr);

                        return db.Query<BitacoraDto>(QRY_GET_BITACORAS_BY_LOGIN_AND_CRIT, new { Login = user.Login, Criticidad = criticidad}, transaction: tr);
                    }
                    finally
                    {
                        tr.Commit();
                    }
                }
            }
        }

        private Bitacora GetBitacora(int idBitacora, IDbConnection db, IDbTransaction tr)
        {
            return db.QuerySingle<Bitacora>(QRY_GET_BITACORA_BY_ID, new { Id = idBitacora }, transaction: tr);
        }

        private void UpdateIntegrity(int idBitacora, IDbConnection db, IDbTransaction tr)
        {
            Bitacora bitacora = GetBitacora(idBitacora, db, tr);
            var dvhString = DvhCalculator<Bitacora>.GetDvhString(bitacora, out _);
            db.Execute(QRY_UPDATE_DV_BY_ID, new {Dv = dvhString, Id = idBitacora}, tr);

            var bitacoras = db.Query<Bitacora>(QRY_GET_ALL_BITACORAS, transaction: tr);
            long dvvTotal = 0;
            foreach (var bita in bitacoras)
            {
                DvhCalculator<Bitacora>.GetDvhString(bita, out var dvhValue);
                dvvTotal += dvhValue;
            }

            var dvvValue = DvValue.GetDvValue(dvvTotal.ToString());
            var dvvString = HashCalculator.GetCryptString(dvvValue.ToString(), CryptMethodEnum.Sha1);

            IntegrityDal.UpdateIntegryty(TablaIntegridadEnum.Bitacora, dvvString, db, tr);
        }
    }
}
