using Mcba.Infraestruture;
using NUnit.Framework;

namespace Mcba.Testing
{
    [TestFixture]
    public class HashTest
    {
        private const string SALT = "Cacho";

        [Test, Explicit("Solo manual")]
        public void CompareMda5()
        {
            var longText = "encriptar es cambiar el aspecto de un mensaje para que no lo entienda alguien que no es el receptor. lo mismo que cifrar. dos técnicas reversibles y no reversibles. reversibles: simétricos y asimétricos. simétrico: usa la misma clave o semilla para encriptar o desencriptar. (word, winrar). asimétrico: las claves o semillas son distintas. (clave pública y clave privada). se usa en la transmisión y mensajes por internet, por ejemplo.";
            var shortText = "encriptar";

            var longHash = HashHelper.Crypt(longText, SALT);
            var shortHash = HashHelper.Crypt(shortText, SALT);

            Assert.AreEqual(longHash.Length, shortHash.Length);
        }

        [Test, Explicit("Solo manual")]
        public void GetMda5()
        {
            var longText = "encriptar es cambiar el aspecto de un mensaje para que no lo entienda alguien que no es el receptor. lo mismo que cifrar. dos técnicas reversibles y no reversibles. reversibles: simétricos y asimétricos. simétrico: usa la misma clave o semilla para encriptar o desencriptar. (word, winrar). asimétrico: las claves o semillas son distintas. (clave pública y clave privada). se usa en la transmisión y mensajes por internet, por ejemplo.";

            var longHash1 = HashHelper.Crypt(longText, SALT);
            var longHash2 = HashHelper.Crypt(longText, SALT);

            Assert.AreEqual(longHash1, longHash2);
        }

        [Test, Explicit("Solo manual")]
        public void GetBase64()
        {
            var longText = "encriptar es cambiar el aspecto de un mensaje para que no lo entienda alguien que no es el receptor. lo mismo que cifrar. dos técnicas reversibles y no reversibles. reversibles: simétricos y asimétricos. simétrico: usa la misma clave o semilla para encriptar o desencriptar. (word, winrar). asimétrico: las claves o semillas son distintas. (clave pública y clave privada). se usa en la transmisión y mensajes por internet, por ejemplo.";

            var longHash = HashHelper.Base64Encode(longText);
            var longDecode = HashHelper.Base64Decode(longHash);

            Assert.AreEqual(longText, longDecode);
        }
    }
}
