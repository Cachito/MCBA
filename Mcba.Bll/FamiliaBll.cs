﻿using System.Collections.Generic;
using Mcba.Dal;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using Mcba.Infraestruture.Settings;

namespace Mcba.Bll
{
    public class FamiliaBll
    {
        public int GetFamiliasCount()
        {
            return new FamiliaDal(McbaSettings.CnnString).GetUsersCount();
        }

        public FamiliaDto GetFamilia(int id)
        {
            return new FamiliaDal(McbaSettings.CnnString).GetFamiliaById(id);
        }

        public bool Save(FamiliaDto familia)
        {
            var familiaDal = new FamiliaDal(McbaSettings.CnnString);

            return familiaDal.Save(familia);
        }

        public IEnumerable<FamiliaDto> FindPage(string searchText, int page)
        {
            return new FamiliaDal(McbaSettings.CnnString).FindPage(searchText, page, McbaSettings.DataPagination);
        }

        public IEnumerable<FamiliaDto> GetPage(int page)
        {
            return new FamiliaDal(McbaSettings.CnnString).GetAll(page, McbaSettings.DataPagination);
        }

        public IEnumerable<FamiliaDto> GetDisponibles(int userId)
        {
            return new FamiliaDal(McbaSettings.CnnString).GetDisponibles(userId);
        }

        public IEnumerable<FamiliaDto> GetAsignadas(int userId)
        {
            return new FamiliaDal(McbaSettings.CnnString).GetAsignadas(userId);
        }

        public IEnumerable<UsuarioFamilia> GetUsuarioFamilias()
        {
            return new FamiliaDal(McbaSettings.CnnString).GetUsuarioFamilias();
        }
    }
}
