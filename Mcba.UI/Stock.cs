using System;
using System.Text;
using Mcba.Bll.Helpers;

namespace Mcba.UI
{
    public partial class Stock : ViewBase
    {
        private int idStock { set; get; }

        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
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
            idStock = 0;
            txtLote.Text = string.Empty;
        }

        private void ControlsEnabled(bool enable)
        {
            txtLote.Enabled = enable;
        }

        protected internal override void Save()
        {
            if (!Valida())
            {
                return;
            }


            LoadGrid();
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();

            if (txtLote.Text == string.Empty)
            {
                mess.Append("Debe ingreasr Nombre.");
                ret = false;
            }

            return ret;
        }
    }
}