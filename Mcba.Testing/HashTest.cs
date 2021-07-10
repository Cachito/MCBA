using Mcba.Seguridad;
using NUnit.Framework;

namespace Mcba.Testing
{
    [TestFixture]
    public class HashTest
    {
        private const string SALT_SISTEMA = "LuisCarro";

        [Test, Explicit("Solo manual")]
        public void CompareMda5()
        {
            var longText =
                "encriptar es cambiar el aspecto de un mensaje para que no lo entienda alguien que no es el receptor. lo mismo que cifrar. dos técnicas reversibles y no reversibles. reversibles: simétricos y asimétricos. simétrico: usa la misma clave o semilla para encriptar o desencriptar. (word, winrar). asimétrico: las claves o semillas son distintas. (clave pública y clave privada). se usa en la transmisión y mensajes por internet, por ejemplo.";
            var shortText = "encriptar";

            var longHash = HashHelper.Crypt(longText);
            var shortHash = HashHelper.Crypt(shortText, SALT_SISTEMA);

            Assert.AreEqual(longHash.Length, shortHash.Length);
        }

        [Test, Explicit("Solo manual")]
        public void GetMda5()
        {
            var text = "0";

            // con salt sistema
            var hash1 = HashHelper.Crypt(text, SALT_SISTEMA);
            var hash2 = HashHelper.Crypt(text, SALT_SISTEMA);

            // sin salt sistema (default)
            //var hash1 = HashHelper.Crypt(text);
            //var hash2 = HashHelper.Crypt(text);

            Assert.AreEqual(hash1, hash2);
        }

        [Test, Explicit("Solo manual")]
        public void GetBase64()
        {
            var text =  "Data.json";
            //var text =  "{\"Salt\":\"LuisCarro\",\"ConnectionString\":\"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Mcba;Data Source=DESKTOP-M95JCSK\\\\SQLEXPRESS;\"}";

            var hash = HashHelper.Base64Encode(text);
            var decode = HashHelper.Base64Decode(hash);

            Assert.AreEqual(text, decode);
        }

        [Test, Explicit("Solo manual")]
        public void CompareBase64()
        {
            var longText =
                "encriptar es cambiar el aspecto de un mensaje para que no lo entienda alguien que no es el receptor. lo mismo que cifrar. dos técnicas reversibles y no reversibles. reversibles: simétricos y asimétricos. simétrico: usa la misma clave o semilla para encriptar o desencriptar. (word, winrar). asimétrico: las claves o semillas son distintas. (clave pública y clave privada). se usa en la transmisión y mensajes por internet, por ejemplo.";
            var shortText = "encriptar";

            var longHash = HashHelper.Base64Encode(longText);
            var shortHash = HashHelper.Base64Encode(shortText);

            var longLength = longHash.Length;
            var shortLength = shortHash.Length;
        }
    }
}