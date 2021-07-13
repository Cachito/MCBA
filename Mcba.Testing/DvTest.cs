using Mcba.Entidad;
using Mcba.Seguridad;
using NUnit.Framework;

namespace Mcba.Testing
{
    [TestFixture]
    public class DvTest
    {
        [Test, Explicit("Solo manual")]
        public void GetDv()
        {
            var u = new Usuario
            {
                Nombre = "Usuario",
                Apellido = "Default",
                Login = "Administrador",
                Password = "1234",
                Email = "luis.carro@gmail.com",
                IdIdioma = 1,
                Activo = true,
                Intentos = 0
            };

            var dvString = DvHelper<Usuario>.GetDvhString(u);
        }
    }
}