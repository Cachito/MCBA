using System;

namespace Mcba.Entidad.Enums
{
    [Flags]
    public enum TipoPermisoEnum
    {
        None = 0,
        Read = 2,
        Write = 4,
        Print = 8
    }
}