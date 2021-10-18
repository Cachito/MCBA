using Mcba.Entidad.Attributes;
using Mcba.Entidad.Enums;

namespace Mcba.Entidad
{
    public class UsuarioFamilia
    {
        public int IdUsuario { set; get; }
        public int IdFamilia { set; get; }
        [CryptMethod(CryptMethodEnum.Ignore)]
        public string DV { set; get; }
    }
}
