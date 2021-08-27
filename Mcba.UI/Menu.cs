using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SetCaptions(int idLanguage)
        {
            var caps = Captions.GetCaptions(idLanguage, Name);

            foreach (KeyValuePair<string, string> cap in caps)
            {
                var c = Controls.Find(cap.Key, true);
                if (c.Any())
                {
                    c[0].Text = cap.Value;
                }
            }
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiVehiculos_Click(object sender, EventArgs e)
        {
            StockBuscar frm = new StockBuscar
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiChoferes_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            SetCaptions((int)McbaSettings.Language);

            Cursor = Cursors.Default;
            Application.DoEvents();
        }
    }
}