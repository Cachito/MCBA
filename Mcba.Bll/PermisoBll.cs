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
        public IEnumerable<UsuarioPermiso> GetUsuarioPermisos()
        {
            return new PermisoDal(McbaSettings.CnnString).GetUsuarioPermisos();
        }

        public IEnumerable<FamiliaPermiso> GetFamiliaPermisos()
        {
            return new PermisoDal(McbaSettings.CnnString).GetFamiliaPermisos();
        }
    }
}