using System.Linq;
using Mcba.Bll.Helpers;
using NUnit.Framework;

namespace Mcba.Testing
{
    [TestFixture]
    public class UserTest
    {
        [Test, Explicit("Solo manual")]
        public void UserNameGeneration()
        {
            var userList = new[]
            {
                new { Nombre = "Luis", Apellido = "Carro Guerrero" },
                new { Nombre = "Luis Elías", Apellido = "Carro" },
                new { Nombre = "Luciano", Apellido = "Carro" },
                new { Nombre = "Leandro Alonso", Apellido = "Carro Darino" },
                new { Nombre = "Ludmila", Apellido = "Carro" },
                new { Nombre = "Laura Sefue", Apellido = "Carro" },
                new { Nombre = "Lucas", Apellido = "Carro" },
                new { Nombre = "Luna", Apellido = "Carro Sardlanga" },
                new { Nombre = "Lucio", Apellido = "Carro" },
                new { Nombre = "Luca Prodan", Apellido = "Carro" },
                new { Nombre = "Ludovico Squirru", Apellido = "Carro" },
                new { Nombre = "Luisa Delfino", Apellido = "Carro" },
                new { Nombre = "Ludwig", Apellido = "Carro" },
            }.ToList();

            foreach (var user in userList)
            {
                var userName = UserNameGeneratorHelper.GetUsername(user.Nombre, user.Apellido);
            }
        }
    }
}
