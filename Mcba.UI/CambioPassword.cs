using System;
using System.Text;
using System.Windows.Forms;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Helpers;

namespace Mcba.UI
{
    public partial class CambioPassword : Form
    {
        private int idChofer { set; get; }

        public CambioPassword()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void CambioPassword_Load(object sender, EventArgs e)
        {
            SetCaptions();
            LoadGrid();
        }

        private void SetCaptions()
        {
            var caps = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(caps, this);
        }

        private void LoadGrid()
        {

        }

        private void Edit()
        {
            ControlsEnabled(true);
        }

        private void New()
        {
            ControlsEnabled(true);
            Clean();
        }

        private void Clean()
        {
            idChofer = 0;
            txtUsuario.Text = string.Empty;
            txtActual.Text = string.Empty;
        }

        private void ControlsEnabled(bool enable)
        {
            txtUsuario.Enabled = enable;
            txtActual.Enabled = enable;
        }

        private void Save()
        {
            if (!Valida())
            {
                return;
            }

            int.TryParse(txtActual.Text, out var dni);

            LoadGrid();
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();

            if (txtActual.Text == string.Empty)
            {
                mess.Append("Debe ingreasr DNI.");
                ret = false;
            }

            if (!int.TryParse(txtActual.Text, out var _))
            {
                mess.Append("Valor para DNI no válido.");
                ret = false;
            }

            if (txtUsuario.Text == string.Empty)
            {
                mess.Append("Debe ingreasr Nombre.");
                ret = false;
            }

            return ret;
        }

        private void tsbRestaurar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Esta acción restaurará su clave y enviará una nueva por correo.{Environment.NewLine}El sistema se cerrará y debe vovler a ingresar con la clave nueva.{Environment.NewLine}¿Está seguro?",
                "Boungiorno S.A.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
        }
    }
}