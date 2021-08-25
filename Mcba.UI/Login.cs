using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetCaptions();
        }

        private void SetCaptions()
        {
            Cursor = Cursors.WaitCursor;

            var caps = Captions.GetCaptions(McbaSettings.Language, Name);

            foreach (KeyValuePair<string, string> cap in caps)
            {
                var c = Controls.Find(cap.Key, true);
                if (c.Any())
                {
                    c[0].Text = cap.Value;
                }
            }

            Cursor = Cursors.Default;
        }
    }
}
