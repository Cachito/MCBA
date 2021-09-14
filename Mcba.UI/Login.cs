using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Enums;
using Mcba.Infraestruture.Helpers;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Login : Form
    {
        private Dictionary<string, string> captions = new Dictionary<string, string>();

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
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }

        private void CheckMail()
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            var mcbaBll = new UserBll();
            var fullEmail = mcbaBll.GetEmailByLogin(txtUsuario.Text);

            if (string.IsNullOrWhiteSpace(fullEmail))
            {
                txtEmail.Text = string.Empty;
                Cursor = Cursors.Default;
                Application.DoEvents();
                return;
            }

            var emailArr = fullEmail.Split('@');

            var email = emailArr[0];
            var emailLength = email.Length;

            var showEmail = email.Substring(0, 2);
            var showChars = new string('*', emailLength - 2);

            var emailText = $"{showEmail}{showChars}@{emailArr[1]}";

            txtEmail.Text = emailText;

            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void CheckUser()
        {
            var userBll = new UserBll();
            var attempCount = userBll.GetAttemps(txtUsuario.Text);

            if (attempCount >= McbaSettings.MaxLoginAttemps)
            {
                captions.TryGetValue("UsuarioBloqueado", out var caption);
                this.ShowMessage(caption, McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var ok = userBll.UserOk(txtUsuario.Text, txtPassword.Text);

            if (ok)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                captions.TryGetValue("LoginIncorrecto", out var caption);
                this.ShowMessage(caption, McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RestorePassword()
        {
            CheckMail();
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                captions.TryGetValue("MailWarning", out var mailCaption);
                this.ShowMessage(string.Format(mailCaption, txtEmail.Text, Environment.NewLine),
                    McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            captions.TryGetValue("RestoreWarning", out var restoreCaption);
            var ok = this.ShowMessage(string.Format(restoreCaption, txtEmail.Text, Environment.NewLine), McbaSettings.MessageTitle, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ok != DialogResult.Yes)
            {
                return;
            }

            var userBll = new UserBll();
            var newPassword = userBll.RestorePassword(txtUsuario.Text);

            var userEmail = userBll.GetEmailByLogin(txtUsuario.Text);

            captions.TryGetValue("RestoreSubject", out var restoreSubject);
            captions.TryGetValue("RestoreBody", out var restoreBody);
            var send = MailHelper.SendMail(userEmail, restoreSubject,
                string.Format(restoreBody, newPassword, Environment.NewLine));

            if (send)
            {
                captions.TryGetValue("RestoreSent", out var restoreSent);
                this.ShowMessage(restoreSent, McbaSettings.MessageTitle);
                return;
            }

            MailHelper.SaveToFile(userEmail, restoreSubject,
                string.Format(restoreBody, newPassword, Environment.NewLine));

            captions.TryGetValue("RestoreSaved", out var restoreSaved);
            this.ShowMessage(string.Format(restoreSaved, McbaSettings.TempFolder), McbaSettings.MessageTitle);
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

        private void btnRecuperarContra_Click(object sender, EventArgs e)
        {
            RestorePassword();
        }
    }
}
