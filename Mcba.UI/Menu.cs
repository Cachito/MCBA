using System;
using System.Reflection;
using System.Windows.Forms;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SetCaptions()
        {
            var caps = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(caps, this);

            caps.TryGetValue(Name, out var caption);
            Text = string.Format(caption ?? McbaSettings.SinTraduccion, McbaSettings.MessageTitle, UserLogged.Nombre,
                UserLogged.Apellido);
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
            Localidades frm = new Localidades()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiBancos_Click(object sender, EventArgs e)
        {
            Bancos frm = new Bancos()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiTiposCuenta_Click(object sender, EventArgs e)
        {
            TiposCuenta frm = new TiposCuenta()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiUnidades_Click(object sender, EventArgs e)
        {
            Unidades frm = new Unidades()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiRemitentes_Click(object sender, EventArgs e)
        {
            Remitentes frm = new Remitentes()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiProductos_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiStock_Click(object sender, EventArgs e)
        {
            Stock frm = new Stock()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiVentas_Click(object sender, EventArgs e)
        {
            Facturas frm = new Facturas()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiLiquidaciones_Click(object sender, EventArgs e)
        {
            Liquidacion frm = new Liquidacion()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiPermisos_Click(object sender, EventArgs e)
        {
            Permisos frm = new Permisos()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiBackup_Click(object sender, EventArgs e)
        {
            Backup frm = new Backup()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiBitacora_Click(object sender, EventArgs e)
        {
            Bitacora frm = new Bitacora()
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiCambioContra_Click(object sender, EventArgs e)
        {
            CambioPassword frm = new CambioPassword()
            {
                MdiParent = this
            };

            frm.Show();
        }
    }
}