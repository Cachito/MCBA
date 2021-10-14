using System;

namespace Mcba.Entidad.Enums
{
    [Flags]
    public enum TipoPermisoEnum
    {
        None = 0,
        Read = 2,
        Create = 4,
        Edit = 8,
        Print = 16
    }
}