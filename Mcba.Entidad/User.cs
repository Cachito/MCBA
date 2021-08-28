using Mcba.Entidad.Attributes;

namespace Mcba.Entidad
{
    public class User 
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        [CryptMethod(CryptMethodEnum.Sha1)]
        public string Login { set; get; }
        [CryptMethod(CryptMethodEnum.Sha1)]
        public string Password { set; get; }
        public string Email { set; get; }
        public int IdIdioma { set; get; }
        public bool Activo { set; get; }
        public int Intentos { set; get; }
    }
}