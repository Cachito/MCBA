using System.Collections.Generic;
using Mcba.Entidad.Enums;

namespace Mcba.Entidad
{
    public abstract class Permiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoPermisoEnum TipoPermiso { get; set; }
        public CriticidadEnum Criticidad { get; set; }

        public abstract IList<Permiso> Permisos { get; }
        public abstract void AgregarPermiso(Permiso permiso);
        public abstract void QuitarPermisos();

        public override string ToString()
        {
            return Nombre;
        }
    }
}
