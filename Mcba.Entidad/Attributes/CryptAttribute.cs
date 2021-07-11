using System;

namespace Mcba.Entidad.Attributes
{
    public class CryptMethodAttribute : Attribute
    {
        public CryptMethodEnum CryptMethod { get; set; }

        public CryptMethodAttribute(CryptMethodEnum cryptMethod)
        {
            CryptMethod = cryptMethod;
        }
    }
}