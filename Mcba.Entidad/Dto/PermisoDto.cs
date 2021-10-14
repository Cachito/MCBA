using Mcba.Entidad.Enums;

namespace Mcba.Entidad.Dto
{
    public class PermisoDto
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public TipoPermisoEnum TipoPermiso { set; get; }
    }
}
