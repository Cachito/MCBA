using System.Collections.Generic;
using Mcba.Seguridad.Enums;

namespace Mcba.Seguridad
{
    public abstract class Permiso
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        public abstract IList<Permiso> Permisos { get; }
        public abstract void AgregarPermiso(Permiso permiso);
        public abstract void QuitarPermisos();
        public TipoPermisoEnum TipoPermiso { get; set; }
        public CriticidadEnum Criticidad { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
