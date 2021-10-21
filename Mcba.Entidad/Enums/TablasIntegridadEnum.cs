using Mcba.Entidad.Attributes;

namespace Mcba.Entidad.Enums
{
    public enum TablaIntegridadEnum
    {
        [StringValue("Bitacora")]
        Bitacora,
        [StringValue("FamiliaPermiso")]
        FamiliaPermiso,
        [StringValue("Factura")]
        Factura,
        [StringValue("FacturaItem")]
        FacturaItem,
        [StringValue("Liquidacion")]
        Liquidacion,
        [StringValue("Stock")]
        Stock,
        [StringValue("Usuario")]
        Usuario,
        [StringValue("UsuarioFamilia")]
        UsuarioFamilia,
        [StringValue("UsuarioPermiso")]
        UsuarioPermiso
    }
}