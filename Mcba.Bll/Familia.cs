﻿using System.Collections.Generic;
using Mcba.Bll.Composite;

namespace Mcba.Bll
{
    public class Familia : Componente
    {
        public bool Activo { set; get; }

        private List<Componente> Permisos { set; get; }

        public Familia()
        {
            Permisos = new List<Componente>();
        }

        public void ClearPermisos()
        {
            Permisos = new List<Componente>();
        }

        public void Remove(Componente permiso)
        {
            Permisos.Remove(permiso);
        }

        public void Add(Componente permiso)
        {
            Permisos.Add(permiso);
        }
    }
}