using System;

namespace Mcba.Entidad.Enums
{
    [Flags]
    public enum TipoPermisoEnum
    {
        SinAcceso = 0,
        Lectura = 2,
        Impresion = 4,
        Edicion = 8,
        Creacion = 16,
    }
}