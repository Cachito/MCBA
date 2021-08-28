using Mcba.Entidad;
using Mcba.Infraestruture.Settings;
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
            var u = new User
            {
                Id = 3,
                Nombre = "Usuario",
                Apellido = "Default",
                Login = "Administrador",
                Password = "1234",
                Email = "luis.carro@gmail.com",
                IdIdioma = 1,
                Activo = true,
                Intentos = 0
            };

            McbaSettings.Key = "0909b1f91cbb4459acab466ae8f0eaf5";
            McbaSettings.Salt = "LuisCarroTfi";

            var dvString = DvHelper<User>.GetDvhString(u);
        }
    }
}