using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class CambioPassword : Form
    {
        private UserLogged userLogged;
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        public CambioPassword()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void CambioPassword_Load(object sender, EventArgs e)
        {
            userLogged = UserLogged.GetInstance();
            txtUsuario.Text = $"{userLogged.Nombre} {userLogged.Apellido}";
            SetCaptions();
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }

        private void Save()
        {
            if (!Valida())
            {
                return;
            }

            if (!CheckUser())
            {
                captions.TryGetValue("ClaveIncorrecta", out var claveIncorrecta);
                this.ShowMessage($"{claveIncorrecta}{Environment.NewLine}", McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var userBll = new UserBll();
            userBll.SaveNewPassword(userLogged.Login, txtNueva.Text);

            captions.TryGetValue("PasswordChanged", out var caption);
            this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine), McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();

            if (txtActual.Text == string.Empty)
            {
                captions.TryGetValue("ClaveActual", out var claveActual);
                mess.Append($"{claveActual}{Environment.NewLine}");
                ret = false;
            }

            if (txtNueva.Text == string.Empty || txtRepiteNueva.Text == string.Empty)
            {
                captions.TryGetValue("ClaveNueva", out var claveNueva);
                mess.Append($"{claveNueva}{Environment.NewLine}");
                ret = false;
            }

            if (!string.Equals(txtNueva.Text.Trim().ToLower(), txtRepiteNueva.Text.Trim().ToLower(),
                StringComparison.Ordinal))
            {
                captions.TryGetValue("ClaveDistinta", out var claveDistinta);
                mess.Append($"{claveDistinta}{Environment.NewLine}");
                ret = false;
            }

            if (!ret)
            {
                this.ShowMessage(mess.ToString(), McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            return ret;
        }

        private bool CheckUser()
        {
            var ret = false;

            try
            {
                var userBll = new UserBll();
                ret = userBll.CheckPassword(userLogged.Id, txtActual.Text);

                if (!ret)
                {
                    var attemps = userBll.GetAttemps(userLogged.Id);

                    if (attemps >= 3)
                    {
                        captions.TryGetValue("UserBlocked", out var caption);
                        this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine),
                            McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                captions.TryGetValue("ErrorCheckPassword", out var caption);
                this.ShowMessage($"{caption}{Environment.NewLine}{ex.Message}", McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return ret;
        }
    }
}