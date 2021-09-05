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
                Login = "9RGoqeqxziG1QmrXnePmBxfQL+U=",
                Password = "1a+UEGFh0FRm9VRXew8G4wZbMxk=",
                Email = "luis.carro@gmail.com",
                IdIdioma = 1,
                Activo = true,
                Intentos = 0,
                DV = "FxAoWr0zpTkb0Nk9VF5aC8/Rls0="
            };

            McbaSettings.Key = "0909b1f91cbb4459acab466ae8f0eaf5";
            McbaSettings.Salt = "LuisCarroTfi";

            var dvString = DvhHelper<User>.GetDvhString(u, out var _);
        }
    }
}