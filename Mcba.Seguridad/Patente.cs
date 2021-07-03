using System.Collections.Generic;

namespace Mcba.Seguridad
{
    public class Patente : Permiso
    {
        public override IList<Permiso> Permisos => new List<Permiso>();

        public override void AgregarPermiso(Permiso permiso)
        {
        }

        public override void QuitarPermisos()
        {
        }
    }
}