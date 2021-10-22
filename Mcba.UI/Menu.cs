using System;
using System.Linq;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Helpers;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Menu : Form
    {
        private readonly UserLogged userLogged = UserLogged.GetInstance();

        public Menu()
        {
            InitializeComponent();
        }

        private void SetCaptions()
        {
            var caps = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(caps, this);

            caps.TryGetValue(Name, out var caption);
            Text = string.Format(caption ?? McbaSettings.SinTraduccion, McbaSettings.MessageTitle, userLogged.Nombre,
                userLogged.Apellido);
        }

        private void SetPermissions()
        {
            userLogged.SetPermissions(this);
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiVehiculos_Click(object sender, EventArgs e)
        {

        }

        private void tsmiChoferes_Click(object sender, EventArgs e)
        {
            Choferes frm = new Choferes()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            SetCaptions();
            SetPermissions();

            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void tsmiCondicionesIva_Click(object sender, EventArgs e)
        {
            CondicionesIva frm = new CondicionesIva
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiProvincias_Click(object sender, EventArgs e)
        {
            Provincias frm = new Provincias
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiLocalidades_Click(object sender, EventArgs e)
        {
            Localidades frm = new Localidades
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiBancos_Click(object sender, EventArgs e)
        {
            Bancos frm = new Bancos
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiTiposCuenta_Click(object sender, EventArgs e)
        {
            TiposCuenta frm = new TiposCuenta
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiUnidades_Click(object sender, EventArgs e)
        {
            Unidades frm = new Unidades
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiRemitentes_Click(object sender, EventArgs e)
        {
            Remitentes frm = new Remitentes
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiProductos_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiStock_Click(object sender, EventArgs e)
        {
            Stock frm = new Stock
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiVentas_Click(object sender, EventArgs e)
        {
            Facturas frm = new Facturas
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiLiquidaciones_Click(object sender, EventArgs e)
        {
            Liquidacion frm = new Liquidacion
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios
            {
                MdiParent = this
            };

            if (OpenFormsHelper.CheckIfFormIsOpen(frm.Name))
            {
                frm = (Usuarios)Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.Name == frm.Name);
            }

            frm.Show();
            frm.BringToFront();
        }

        private void tsmiPermisosFamilias_Click(object sender, EventArgs e)
        {
            PermisosFamilias frm = new PermisosFamilias
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiPermisosUsuarios_Click(object sender, EventArgs e)
        {
            PermisosUsuarios frm = new PermisosUsuarios
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiBackup_Click(object sender, EventArgs e)
        {
            Backup frm = new Backup
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiBitacoras_Click(object sender, EventArgs e)
        {
            Bitacoras frm = new Bitacoras
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiFamilias_Click(object sender, EventArgs e)
        {
            Familias frm = new Familias
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiCambioContra_Click(object sender, EventArgs e)
        {
            var userBll = new UserBll();
            var userChange = userBll.GetUser(userLogged.Id);

            var frm = new CambioPassword();

            if (OpenFormsHelper.CheckIfFormIsOpen(frm.Name))
            {
                var frmExists = OpenFormsHelper.GetOpened(frm.Name);
                frmExists.Dispose();
            }

            frm = new CambioPassword
            {
                MdiParent = this,
                UserChange = userChange
            };

            frm.Show();
            frm.BringToFront();
        }
    }
}