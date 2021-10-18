using System.Collections.Generic;
using Mcba.Bll.Composite;

namespace Mcba.Bll
{
    public class UserLogged
    {
        private static UserLogged instance;

        private UserLogged()
        {
            Permisos = new List<Componente>();
        }

        public static UserLogged GetInstance()
        {
            return instance ?? (instance = new UserLogged());
        }

        public List<Componente> Permisos { set; get; }
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Login { set; get; }
        public string Email { set; get; }
        public int IdIdioma { set; get; }

        public void SetAuthorization()
        {
            var userBll = new UserBll();
            var permisos = userBll.GetPermisos(Id);

            foreach (var p in permisos)
            {
                Permisos.Add(new Permiso
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    TipoPermiso = p.IdTipoPermiso,
                    Criticidad = p.Criticidad,
                    Modulo = p.Modulo,
                    EsCompuesto = false
                });
            }

            var familias = userBll.GetFamilias(Id);
            foreach (var f in familias)
            {
                Permisos.Add(new Familia
                {
                    Id = f.Id,
                    Nombre =  f.Nombre,
                    EsCompuesto = true
                });
            }
        }
    }
}
