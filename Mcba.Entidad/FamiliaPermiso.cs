using Mcba.Entidad.Attributes;
using Mcba.Entidad.Enums;

namespace Mcba.Entidad
{
    public class FamiliaPermiso
    {
        public int IdFamilia { set; get; }
        public int IdPermiso { set; get; }
        public int IdTipoPermiso { set; get; }
        [CryptMethod(CryptMethodEnum.Ignore)]
        public string DV { set; get; }
    }
}
