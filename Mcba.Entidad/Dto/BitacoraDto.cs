using System;
using Mcba.Entidad.Enums;

namespace Mcba.Entidad.Dto
{
    public class BitacoraDto
    {
        public DateTime FechaHora { set; get; }
        public string Patente { set; get; }
        public string Descripcion { set; get; }
        public CriticidadEnum Criticidad { set; get; }
    }
}
