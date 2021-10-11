using System;
using Mcba.Entidad.Attributes;
using Mcba.Entidad.Enums;

namespace Mcba.Entidad
{
    public class Bitacora
    {
        public int Id { set; get; }
        public DateTime FechaHora { set; get; }
        public string Patente { set; get; }
        public string Descripcion { set; get; }
        public int Criticidad { set; get; }
        [CryptMethod(CryptMethodEnum.Aes)]
        public string Login { set; get; }
        [CryptMethod(CryptMethodEnum.Ignore)]
        public string DV { set; get; }
    }
}