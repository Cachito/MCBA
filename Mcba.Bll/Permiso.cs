using Mcba.Bll.Composite;
using Mcba.Entidad.Enums;

namespace Mcba.Bll
{
    public class Permiso : Componente
    {
        public Permiso()
        {
            TipoPermiso = TipoPermisoEnum.SinAcceso;
        }

        public string Modulo { get; set; }
        public TipoPermisoEnum TipoPermiso { get; set; }
        public CriticidadEnum Criticidad { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}