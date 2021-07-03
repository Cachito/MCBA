using System.Collections.Generic;
using System.Linq;

namespace Mcba.Seguridad
{
    public class Familia : Permiso
    {
        private IList<Permiso> permisos;

        public Familia()
        {
            permisos = new List<Permiso>();
        }

        public override IList<Permiso> Permisos => permisos.ToArray();

        public override void QuitarPermisos()
        {
            permisos = new List<Permiso>();
        }

        public override void AgregarPermiso(Permiso permiso)
        {
            permisos.Add(permiso);
        }
    }
}