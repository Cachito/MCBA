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
        public string CryptLogin { set; get; }
        public string Email { set; get; }
        public int IdIdioma { set; get; }
        public bool Activo { set; get; }

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

        public void SetPermissions(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is MenuStrip menuStrip)
                {
                    SetPermissions(menuStrip);
                }
            }
        }

        public void SetPermissions(MenuStrip menuStrip)
        {
            foreach (ToolStripMenuItem menuItem in menuStrip.Items)
            {
                var acceso = TipoPermisoEnum.SinAcceso;

                if (menuItem.DropDownItems.Count > 0)
                {
                    SetPermissions(menuItem.DropDownItems);
                }

                if (menuItem.DropDownItems.Cast<ToolStripMenuItem>().Any(dropItem => dropItem.Enabled))
                {
                    acceso = TipoPermisoEnum.Gestion;
                }

                if (acceso == TipoPermisoEnum.SinAcceso)
                {
                    acceso = GetPermiso(menuItem.Tag.ToString(), Permisos)?.TipoPermiso ?? TipoPermisoEnum.SinAcceso;
                }

                menuItem.Enabled = acceso != TipoPermisoEnum.SinAcceso;
            }
        }

        public void SetPermissions(ToolStripItemCollection dropDownItems)
        {
            foreach (ToolStripMenuItem menuItem in dropDownItems)
            {
                var acceso = TipoPermisoEnum.SinAcceso;

                if (menuItem.DropDownItems.Count > 0)
                {
                    SetPermissions(menuItem.DropDownItems);
                }

                if (menuItem.DropDownItems.Cast<ToolStripMenuItem>().Any(dropItem => dropItem.Enabled))
                {
                    acceso = TipoPermisoEnum.Gestion;
                }

                if (acceso == TipoPermisoEnum.SinAcceso)
                {
                    acceso = GetPermiso(menuItem.Tag.ToString()).TipoPermiso;
                }

                menuItem.Enabled = acceso != TipoPermisoEnum.SinAcceso;
            }
        }

        public Permiso GetPermiso(string modulo)
        {
            var ret = new Permiso();

            foreach (var p in Permisos)
            {
                if (p is Permiso permiso && permiso.Modulo == modulo)
                {
                    ret = permiso;
                    break;
                }

                if (p is Familia familia)
                {
                    ret = GetPermiso(modulo, familia.GetPermisos());
                }
            }

            return ret;
        }

        public Permiso GetPermiso(string modulo, List<Componente> permisos)
        {
            var ret = new Permiso();

            foreach (var p in permisos)
            {
                if (p is Permiso permiso && permiso.Modulo == modulo)
                {
                    ret = permiso;
                    break;
                }

                if (p is Familia familia)
                {
                    ret = GetPermiso(modulo, familia.GetPermisos());
                }
            }

            return ret;
        }
    }
}