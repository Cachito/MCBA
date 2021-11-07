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

            var longHash = HashCalculator.Crypt(longText, SALT_SISTEMA);
            var shortHash = HashCalculator.Crypt(shortText, SALT_SISTEMA);

            Assert.AreEqual(longHash.Length, shortHash.Length);
        }

        [Test, Explicit("Solo manual")]
        public void TestSha1()
        {
            var text = "Administrador";

            var hash = HashCalculator.Crypt(text, SALT_SISTEMA);
        }

        [Test, Explicit("Solo manual")]
        public void TestAes()
        {
            var text = "{\"Key\":\"0909b1f91cbb4459acab466ae8f0eaf5\",\"Salt\":\"LuisCarroTfi\",\"CnnString\":\"Integrated Security=SSPI;Persist Security Info False;Initial Catalog=Mcba;Data Source=DESKTOP-M95JCSK\\\\SQLEXPRESS;\",\"MessageTitle\":\"Boungiorno S.A.\"}";

            var hash1 = HashCalculator.Encrypt(text, KEY_SISTEMA, SALT_SISTEMA);
            var original = HashCalculator.Decrypt(hash1, KEY_SISTEMA, SALT_SISTEMA);

            Assert.AreEqual(text, original);
        }

        [Test, Explicit("Solo manual")]
        public void GetBase64()
        {
            var fileName =  "Data.json";
            var fileText= "{\"Key\":\"0909b1f91cbb4459acab466ae8f0eaf5\",\"Salt\":\"LuisCarroTfi\",\"CnnString\":\"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Mcba;Data Source=DESKTOP-M95JCSK\\\\SQLEXPRESS;\",\"MessageTitle\":\"Boungiorno S.A.\",\"MaxLoginAttemps\":3,\"RandomPassLength\":10,\"NumberOfNonAlphanumericCharacters\":3,\"EmailFrom\":\"luis.carro@gmail.com\",\"EmailPort\":587,\"EmailHost\":\"smtp.gmail.com\",\"EmailSsl\":true,\"EmailPass\":\"Jav13r1n\",\"TempFolder\":\"C:\\\\TMP\",\"DataPagination\":50,\"SinTraduccion\":\"No hay traducción disponible\",\"MasterCnnString\":\"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=DESKTOP-M95JCSK\\\\SQLEXPRESS;\",\"VolumenesBackup\":2,\"Path7Zip\":\"7z.exe\",\"Command7Zip\":\"\\\"{0}\\\" a \\\"{1}\\\" \\\"{2}\\\" -v{3}k\"}";

            var hashFileName = HashCalculator.Base64Encode(fileName);
            var decodeFileName = HashCalculator.Base64Decode(hashFileName);

            var hashText = HashCalculator.Base64Encode(fileText);
            var decodeText = HashCalculator.Base64Decode(hashText);
        }
    }
}