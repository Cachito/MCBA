using System;
using System.Text;
using Mcba.Bll.Helpers;

namespace Mcba.UI
{
    public partial class Localidades : ViewBase
    {
        private int idLocalidad { set; get; }

        public Localidades()
        {
            InitializeComponent();
        }

        private void Localidades_Load(object sender, EventArgs e)
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
            idLocalidad = 0;
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
                mess.Append("Debe ingresar Nombre.");
                ret = false;
            }

            return ret;
        }

        //private void Localidades_HelpRequested(object sender, System.Windows.Forms.HelpEventArgs hlpevent)
        //{
        //    Help.ShowHelp(this,
        //        McbaSettings.PathManual,
        //        "localidades.htm");
        //}
    }
}