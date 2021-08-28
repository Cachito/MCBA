using System;
using System.Text;
using System.Windows.Forms;
using Mcba.Infraestruture.Helpers;

namespace Mcba.UI
{
    public partial class FacturasItems : Form
    {
        private int idChofer { set; get; }

        public FacturasItems()
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

        private void FacturasItems_Load(object sender, EventArgs e)
        {
            SetCaptions();
            LoadGrid();
        }


        private void SetCaptions()
        {
            var caps = LanguageHelper.GetCaptions(Name);
            LanguageHelper.SetCaptions(caps, this);
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
            txtDescripcion.Text = string.Empty;
        }

        private void ControlsEnabled(bool enable)
        {
            txtDescripcion.Enabled = enable;
        }

        private void Save()
        {
            if (!Valida())
            {
                return;
            }

            int.TryParse(txtDescripcion.Text, out var dni);

            LoadGrid();
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();

            if (txtDescripcion.Text == string.Empty)
            {
                mess.Append("Debe ingreasr DNI.");
                ret = false;
            }

            if (!int.TryParse(txtDescripcion.Text, out var _))
            {
                mess.Append("Valor para DNI no válido.");
                ret = false;
            }

            return ret;
        }
    }
}