using Mcba.Infraestruture;
using System;
using System.Text;
using System.Windows.Forms;
using Mcba.Infraestruture.Helpers;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Backup : Form
    {
        private int idChofer { set; get; }

        public Backup()
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
            SetCaptions();
            Save();
        }

        private void Backup_Load(object sender, EventArgs e)
        {

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
        }

        private void ControlsEnabled(bool enable)
        {
            this.ShowMessage("Proceso de backup finalizado", McbaSettings.MessageTitle);
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