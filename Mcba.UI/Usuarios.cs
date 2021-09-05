using System;
using System.Text;
using System.Windows.Forms;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Helpers;

namespace Mcba.UI
{
    public partial class Usuarios : Form
    {
        private int idChofer { set; get; }

        public Usuarios()
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

        private void Usuarios_Load(object sender, EventArgs e)
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
            txtId.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void ControlsEnabled(bool enable)
        {
            txtId.Enabled = enable;
            txtUsuario.Enabled = enable;
        }

        private void Save()
        {
            if (!Valida())
            {
                return;
            }

            int.TryParse(txtUsuario.Text, out var dni);

            LoadGrid();
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();

            if (txtUsuario.Text == string.Empty)
            {
                mess.Append("Debe ingreasr DNI.");
                ret = false;
            }

            if (!int.TryParse(txtUsuario.Text, out var _))
            {
                mess.Append("Valor para DNI no válido.");
                ret = false;
            }

            if (txtId.Text == string.Empty)
            {
                mess.Append("Debe ingreasr Nombre.");
                ret = false;
            }

            return ret;
        }
    }
}