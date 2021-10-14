using Mcba.Bll.Composite;
using Mcba.Entidad.Enums;

namespace Mcba.Bll
{
    public abstract class Permiso : Componente
    {
        public string Modulo { get; set; }
        public TipoPermisoEnum TipoPermiso { get; set; }
        public CriticidadEnum Criticidad { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}