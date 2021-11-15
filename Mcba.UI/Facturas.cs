using System;
using System.Text;
using Mcba.Bll.Helpers;

namespace Mcba.UI
{
    public partial class Facturas : ViewBase
    {
        private int idFactura { set; get; }

        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
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
            idFactura = 0;
            txtRazónSocial.Text = string.Empty;
        }

        private void ControlsEnabled(bool enable)
        {
            txtRazónSocial.Enabled = enable;
        }

        protected internal override void Save()
        {
            if (!Valida())
            {
                return;
            }

            int.TryParse(txtRazónSocial.Text, out var dni);

            LoadGrid();
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();

            if (txtRazónSocial.Text == string.Empty)
            {
                mess.Append("Debe ingreasr DNI.");
                ret = false;
            }

            if (!int.TryParse(txtRazónSocial.Text, out var _))
            {
                mess.Append("Valor para DNI no válido.");
                ret = false;
            }

            return ret;
        }
    }
}