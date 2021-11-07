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
                var desc = HashCalculator.Decrypt(bitacora.Descripcion, McbaSettings.Key, McbaSettings.Salt);
                bitacora.Descripcion = desc;
            }

            return bitacoras;
        }
    }
}