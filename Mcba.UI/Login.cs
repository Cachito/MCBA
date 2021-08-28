using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Enums;
using Mcba.Infraestruture.Helpers;
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
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            
            SetCaptions();

            cmbLanguages.SelectedIndexChanged -= cmbLanguages_SelectedIndexChanged;
            LoadLanguages();
            cmbLanguages.SelectedIndexChanged += cmbLanguages_SelectedIndexChanged;

            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void LoadLanguages()
        {
            var languages = new LanguageBll().GetLanguages().ToList();
            cmbLanguages.DataSource = null;
            cmbLanguages.DataSource = languages;
            cmbLanguages.DisplayMember = "Descripcion";
            cmbLanguages.ValueMember = "Id";

            cmbLanguages.SelectedValue = (int)McbaSettings.Language;
        }

        private void SetCaptions()
        {
            var caps = LanguageHelper.GetCaptions(Name);
            LanguageHelper.SetCaptions(caps, this);
        }

        private void CheckMail()
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            var mcbaBll = new UserBll();
            var email = mcbaBll.GetEmailByLogin(txtUsuario.Text);

            txtEmail.Text = email;

            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void CheckUser()
        {
            var mcbaBll = new UserBll();
            var ok = mcbaBll.UserOk(txtUsuario.Text, txtPassword.Text);

            if (ok)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                this.ShowMessage("Usuario o clave incorrecta.", McbaSettings.MessageTitle);
            }
        }

        private void cmbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguages.SelectedValue == null)
            {
                return;
            }

            McbaSettings.Language = (LanguageEnum) (int) cmbLanguages.SelectedValue;
            SetCaptions();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            CheckMail();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            timer.Stop();
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            timer.Start();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CheckUser();
        }
    }
}
