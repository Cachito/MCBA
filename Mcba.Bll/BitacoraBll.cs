using System.Collections.Generic;
using System.Linq;
using Mcba.Dal;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.Bll
{
    public class BitacoraBll
    {
        public IEnumerable<Bitacora> GetBitacoras()
        {
            return new BitacoraDal(McbaSettings.CnnString).GetBitacoras();
        }

        public IEnumerable<BitacoraDto> GetBitacoras(int idUsuario, int criticidad)
        {
            var bitacoras = new BitacoraDal(McbaSettings.CnnString).GetBitacoras(idUsuario, criticidad).ToList();

            foreach (var bitacora in bitacoras)
            {
                var descripcion = HashCalculator.Decrypt(bitacora.Descripcion, McbaSettings.Key, McbaSettings.Salt);
                var patente = string.Empty;
                if (!string.IsNullOrWhiteSpace(bitacora.Patente))
                {
                    patente = HashCalculator.Decrypt(bitacora.Patente, McbaSettings.Key, McbaSettings.Salt);
                }

                bitacora.Descripcion = descripcion;
                bitacora.Patente = patente;
            }

            return bitacoras;
        }

        public void Registrar(Bitacora bitacora)
        {
            BitacoraDal bitacoraDal = new BitacoraDal(McbaSettings.CnnString);
            bitacoraDal.Registrar(bitacora);
        }
    }
}