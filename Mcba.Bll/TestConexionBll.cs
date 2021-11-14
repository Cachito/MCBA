using Mcba.Dal;

namespace Mcba.Bll
{
    public class TestConexionBll
    {
        public bool TestConexion(string cnnString)
        {
            return new TestConexionDal(cnnString).TestConexion();
        }
    }
}
