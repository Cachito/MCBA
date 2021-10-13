using System.Collections.Generic;

namespace Mcba.Entidad.Dto
{
    public class UserLogged
    {
        private static UserLogged instance;

        private UserLogged()
        {
            Permisos = new List<Permiso>();
        }

        public static UserLogged GetInstance()
        {
            return instance ?? (instance = new UserLogged());
        }

        public List<Permiso> Permisos { set; get; }
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Login { set; get; }
        public string Email { set; get; }
        public int IdIdioma { set; get; }
    }
}
