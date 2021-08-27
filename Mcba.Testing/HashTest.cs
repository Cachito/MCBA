using Mcba.Seguridad;
using NUnit.Framework;

namespace Mcba.Testing
{
    [TestFixture]
    public class HashTest
    {
        private const string SALT_SISTEMA = "LuisCarroTfi";
        private const string KEY_SISTEMA = "0909b1f91cbb4459acab466ae8f0eaf5";

        [Test, Explicit("Solo manual")]
        public void CompareSha1()
        {
            var longText =
                "encriptar es cambiar el aspecto de un mensaje para que no lo entienda alguien que no es el receptor. lo mismo que cifrar. dos técnicas reversibles y no reversibles. reversibles: simétricos y asimétricos. simétrico: usa la misma clave o semilla para encriptar o desencriptar. (word, winrar). asimétrico: las claves o semillas son distintas. (clave pública y clave privada). se usa en la transmisión y mensajes por internet, por ejemplo.";
            var shortText = "encriptar";

            var longHash = HashHelper.Crypt(longText, SALT_SISTEMA);
            var shortHash = HashHelper.Crypt(shortText, SALT_SISTEMA);

            Assert.AreEqual(longHash.Length, shortHash.Length);
        }

        [Test, Explicit("Solo manual")]
        public void TestSha1()
        {
            var text = "Administrador";

            var hash = HashHelper.Crypt(text, SALT_SISTEMA);
        }

        [Test, Explicit("Solo manual")]
        public void TestAes()
        {
            var text = "frase a encriptar";

            var hash1 = HashHelper.Encrypt(text, KEY_SISTEMA, SALT_SISTEMA);
            var original = HashHelper.Decrypt(hash1, KEY_SISTEMA, SALT_SISTEMA);

            Assert.AreEqual(text, original);
        }

        [Test, Explicit("Solo manual")]
        public void GetBase64()
        {
            var fileName =  "Data.json";
            var fileText= "{\"Key\":\"0909b1f91cbb4459acab466ae8f0eaf5\",\"Salt\":\"LuisCarroTfi\",\"CnnString\":\"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Mcba;Data Source=DESKTOP-M95JCSK\\\\SQLEXPRESS;\"}";

            var hashName = HashHelper.Base64Encode(fileName);
            var decodeName = HashHelper.Base64Decode(hashName);

            var hashText = HashHelper.Base64Encode(fileText);
            var decodeText = HashHelper.Base64Decode(hashText);
        }
    }
}