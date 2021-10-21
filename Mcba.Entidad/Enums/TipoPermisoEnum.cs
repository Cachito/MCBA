using System;
using Mcba.Entidad.Attributes;

namespace Mcba.Entidad.Enums
{
    [Flags]
    public enum TipoPermisoEnum
    {
        [StringValue("Sin Acceso")]
        SinAcceso = 0,
        [StringValue("Consulta")]
        Consulta = 2,
        [StringValue("Gestión")]
        Gestion = 4
    }
}