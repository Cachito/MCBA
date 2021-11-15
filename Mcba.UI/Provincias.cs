using System;
using System.Text;
using Mcba.Bll.Helpers;

namespace Mcba.UI
{
    public partial class Provincias : ViewBase
    {
        private int idProvincia { set; get; }

        public Provincias()
        {
            InitializeComponent();
        }

        private void Provincias_Load(object sender, EventArgs e)
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

        protected internal override void Edit()
        {
            ControlsEnabled(true);
        }

        protected internal override void New()
        {
            ControlsEnabled(true);
            Clean();
        }

        protected internal override void Clean()
        {
            idProvincia = 0;
            txtId.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void ControlsEnabled(bool enable)
        {
            txtId.Enabled = enable;
            txtDescripcion.Enabled = enable;
        }

        protected internal override void Save()
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

            if (txtId.Text == string.Empty)
            {
                mess.Append("Debe ingreasr Nombre.");
                ret = false;
            }

            return ret;
        }
    }
}