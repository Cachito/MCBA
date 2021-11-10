using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Settings;
using NUnit.Framework;

namespace Mcba.Testing
{
    [TestFixture]
    public class DvRepare
    {
        [Test, Explicit("Solo manual")]
        public void IntegrityRepare()
        {
            const string cnnString =
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Mcba;Data Source=DESKTOP-M95JCSK\\SQLEXPRESS;";
            McbaSettings.Key = "0909b1f91cbb4459acab466ae8f0eaf5";
            McbaSettings.Salt = "LuisCarroTfi";

            IntegrityHelper.RepareIntegrity(cnnString);
        }
    }
}