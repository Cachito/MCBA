using Mcba.Entidad.Attributes;

namespace Mcba.Entidad.Enums
{
    public enum CriticidadEnum
    {
        [StringValue("Baja")]
        Baja = 1,
        [StringValue("Media")]
        Media,
        [StringValue("Alta")]
        Alta
    }
}