using Mcba.Entidad.Enums;

namespace Mcba.Entidad.Dto
{
    public class PermisoDto
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Modulo { set; get; }
        public CriticidadEnum Criticidad { set; get; }
        public TipoPermisoEnum IdTipoPermiso { set; get; }
    }
}