using System;
using System.Text;
using System.Windows.Forms;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Helpers;

namespace Mcba.UI
{
    public partial class Liquidacion : Form
    {
        private int idChofer { set; get; }

        public Liquidacion()
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
        }

        private void ControlsEnabled(bool enable)
        {
        }

        private void Save()
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