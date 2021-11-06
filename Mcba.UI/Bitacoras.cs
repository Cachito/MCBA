using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;

namespace Mcba.UI
{
    public partial class Bitacoras : Form
    {
        private Dictionary<string, string> captions = new Dictionary<string, string>();
        private readonly UserLogged userLogged = UserLogged.GetInstance();

        public Bitacoras()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {

        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            SetCaptions();
            SetPermissions();
            LoadGrid();
        }

        private void SetPermissions()
        {
            userLogged.SetPermissions(this);
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }

        private void LoadGrid()
        {

        }


        private void Clean()
        {
            
        }

        private void ControlsEnabled(bool enable)
        {
        }
    }
}