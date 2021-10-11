namespace Mcba.Bll
{
    public class UserLogged
    {
        private static UserLogged instance;

        private UserLogged()
        {
        }

        public static UserLogged GetInstance()
        {
            return instance ?? (instance = new UserLogged());
        }

        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Login { set; get; }
        public string Email { set; get; }
        public int IdIdioma { set; get; }
    }
}
