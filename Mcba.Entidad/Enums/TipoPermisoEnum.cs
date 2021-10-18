using System;

namespace Mcba.Entidad.Enums
{
    [Flags]
    public enum TipoPermisoEnum
    {
        SinAcceso = 0,
        Consulta = 2,
        Gestion = 4
    }
}