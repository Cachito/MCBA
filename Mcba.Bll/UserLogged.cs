using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mcba.Bll.Composite;
using Mcba.Entidad.Enums;

namespace Mcba.Bll
{
    public class UserLogged
    {
        private static UserLogged instance;

        private UserLogged()
        {
            Permisos = new List<Componente>();
        }

        public static UserLogged GetInstance()
        {
            return instance ?? (instance = new UserLogged());
        }

        public List<Componente> Permisos { set; get; }
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Login { set; get; }
        public string Email { set; get; }
        public int IdIdioma { set; get; }

        public void SetAuthorization()
        {
            var userBll = new UserBll();
            var usuarioPermisos = userBll.GetPermisos(Id);

            foreach (var up in usuarioPermisos)
            {
                Permisos.Add(new Permiso
                {
                    Id = up.Id,
                    Nombre = up.Nombre,
                    TipoPermiso = up.IdTipoPermiso,
                    Criticidad = up.Criticidad,
                    Modulo = up.Modulo,
                    EsCompuesto = false
                });
            }

            var familiaBll = new FamiliaBll();
            var familiasUsuario = userBll.GetFamilias(Id);
            foreach (var fu in familiasUsuario)
            {
                var familia = new Familia
                {
                    Id = fu.Id,
                    Nombre = fu.Nombre,
                    EsCompuesto = true
                };

                var permisosFamilia = familiaBll.GetPermisos(fu.Id);
                foreach (var pf in permisosFamilia)
                {
                    familia.AddPermiso(new Permiso
                    {
                        Id = pf.Id,
                        Nombre = pf.Nombre,
                        TipoPermiso = pf.IdTipoPermiso,
                        Criticidad = pf.Criticidad,
                        Modulo = pf.Modulo,
                        EsCompuesto = false
                    });
                }

                Permisos.Add(familia);
            }
        }

        /// <summary>
        /// Los permisos se aplican a manues y botones
        /// </summary>
        /// <param name="form"></param>
        /// <param name="userLoggedPermisos"></param>
        /// <param name="permisos"></param>
        public static void SetPermissions(Form form, List<Componente> permisos)
        {
            foreach (Control control in form.Controls)
            {
                if (control is MenuStrip menu)
                {
                    SetPermissions(menu, permisos);
                }

            }
        }

        private static void SetPermissions(MenuStrip menu, List<Componente> permisos)
        {
            foreach (ToolStripMenuItem menuItem in menu.Items)
            {
                var acceso = TipoPermisoEnum.SinAcceso;

                if (menuItem.DropDownItems.Count > 0)
                {
                    SetPermissions(menuItem.DropDownItems, permisos);
                }

                if (menuItem.DropDownItems.Cast<ToolStripMenuItem>().Any(dropItem => dropItem.Enabled))
                {
                    acceso = TipoPermisoEnum.Gestion;
                }

                if (string.IsNullOrWhiteSpace(menuItem.Tag.ToString()))
                {
                    continue;
                }

                if (acceso == TipoPermisoEnum.SinAcceso)
                {
                    acceso = GetAcceso(menuItem.Tag.ToString(), permisos);
                }

                menuItem.Enabled = acceso != TipoPermisoEnum.SinAcceso;
            }
        }

        private static void SetPermissions(ToolStripItemCollection dropDownItems, List<Componente> permisos)
        {
            foreach (ToolStripMenuItem menuItem in dropDownItems)
            {
                var acceso = TipoPermisoEnum.SinAcceso;

                if (menuItem.DropDownItems.Count > 0)
                {
                    SetPermissions(menuItem.DropDownItems, permisos);
                }

                if (menuItem.DropDownItems.Cast<ToolStripMenuItem>().Any(dropItem => dropItem.Enabled))
                {
                    acceso = TipoPermisoEnum.Gestion;
                }

                if (acceso == TipoPermisoEnum.SinAcceso)
                {
                    acceso = GetAcceso(menuItem.Tag.ToString(), permisos);
                }

                menuItem.Enabled = acceso != TipoPermisoEnum.SinAcceso;
            }
        }

        private static TipoPermisoEnum GetAcceso(string tag, List<Componente> permisos)
        {
            TipoPermisoEnum ret = TipoPermisoEnum.SinAcceso;

            foreach (var p in permisos)
            {
                if (p is Permiso permiso && permiso.Modulo == tag)
                {
                    ret = permiso.TipoPermiso;
                    break;
                }

                if (p is Familia familia)
                {
                    ret = GetAcceso(tag, familia.GetPermisos());
                }
            }

            return ret;
        }
    }
}