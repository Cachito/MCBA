using System;
using System.Collections.Generic;
using Mcba.Dal;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using Mcba.Infraestruture.Settings;

namespace Mcba.Bll
{
    public class PermisoBll
    {
        //public IEnumerable<PermisoDto> GetDisponibles(int userId)
        //{
        //    return new PermisoDal(McbaSettings.CnnString).GetDisponibles(userId);
        //}

        //public IEnumerable<PermisoDto> GetAsignados(int userId)
        //{
        //    return new PermisoDal(McbaSettings.CnnString).GetAsignados(userId);
        //}

        public IEnumerable<UsuarioPermiso> GetUsuarioPermisos()
        {
            return new PermisoDal(McbaSettings.CnnString).GetUsuarioPermisos();
        }
    }
}