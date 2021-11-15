using System;
using System.Text;
using Mcba.Bll.Helpers;

namespace Mcba.UI
{
    public partial class Liquidacion : ViewBase
    {
        private int idLiquidacion { set; get; }

        public Liquidacion()
        {
            InitializeComponent();
        }

        private void Liquidacion_Load(object sender, EventArgs e)
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
            idLiquidacion = 0;
        }

        private void ControlsEnabled(bool enable)
        {
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

            return ret;
        }
    }
}