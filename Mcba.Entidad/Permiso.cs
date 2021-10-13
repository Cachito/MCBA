using Mcba.Entidad.Composite;
using Mcba.Entidad.Enums;

namespace Mcba.Entidad
{
    public abstract class Permiso : Componente
    {
        public string Nombre { get; set; }
        public TipoPermisoEnum TipoPermiso { get; set; }
        public CriticidadEnum Criticidad { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}