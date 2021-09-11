using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Helpers;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Usuarios : Form
    {
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        private int IdUsuario { set; get; }
        private int GridPage { set; get; }

        public Usuarios()
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            GridPage = 0;
            SetCaptions();
            LoadIdiomas();
            LoadGrid();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = dgvUsuarios.Rows[e.RowIndex];
            var id = row.Cells[0].Value.ToString();
            SetUser(id);
        }

        private void tsbRestaurar_Click(object sender, EventArgs e)
        {
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

            MailHelper.SaveNewPassword(userEmail, restoreSubject,
                string.Format(restoreBody, newPassword, Environment.NewLine));

            captions.TryGetValue("RestoreSaved", out var restoreSaved);
            this.ShowMessage(string.Format(restoreSaved, McbaSettings.TempFolder), McbaSettings.MessageTitle);
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }

        private void LoadGrid()
        {
            var usersPage = new UserBll().Get(GridPage);
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usersPage;
        }

        private void LoadIdiomas()
        {
            IEnumerable<Language> idiomas = new LanguageBll().GetLanguages();
            cmbIdiomas.DataSource = null;
            cmbIdiomas.DataSource = idiomas;
            cmbIdiomas.ValueMember = "Id";
            cmbIdiomas.DisplayMember = "Descripcion";
            cmbIdiomas.SelectedIndex = -1;
        }

        private void Edit()
        {
            ControlsEnabled(true);
        }

        private void New()
        {
            Clean();
            ControlsEnabled(true);
        }

        private void Clean()
        {
            IdUsuario = 0;
            txtId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            cmbIdiomas.SelectedIndex = -1;
        }

        private void ControlsEnabled(bool enable)
        {
            txtUsuario.Enabled = enable;
            txtEmail.Enabled = enable;
            txtNombre.Enabled = enable;
            txtApellido.Enabled = enable;
            cmbIdiomas.Enabled = enable;
        }

        private void Save()
        {
            if (!Valida())
            {
                return;
            }

            var changeLogin = false;

            User user;
            if (IdUsuario == 0)
            {
                user = new User
                {
                    Login = txtUsuario.Text,
                };
            }
            else
            {
                user = new UserBll().GetUser(IdUsuario);
                if (user == null)
                {
                    captions.TryGetValue("NoEncontrado", out var caption);
                    this.ShowMessage(string.Format(caption, Environment.NewLine));
                    Clean();
                    LoadGrid();

                    return;
                }

                changeLogin = !string.IsNullOrWhiteSpace(txtUsuario.Text);
                if (changeLogin)
                {
                    user.Login = txtUsuario.Text;
                }
            }

            user.Nombre = txtNombre.Text;
            user.Apellido = txtApellido.Text;
            user.IdIdioma = (int) cmbIdiomas.SelectedValue;
            user.Email = txtEmail.Text;

            var userBll = new UserBll();

            var ok = userBll.Save(user, changeLogin, out var newPassword);
            if (!ok)
            {
                captions.TryGetValue("ErrorAlGuardar", out var caption);
                this.ShowMessage(string.Format(caption, Environment.NewLine));
            }

            if (ok && user.Id == 0)
            {
                captions.TryGetValue("RestoreSubject", out var restoreSubject);
                captions.TryGetValue("RestoreBody", out var restoreBody);
                var send = MailHelper.SendMail(user.Email, restoreSubject,
                    string.Format(restoreBody, user.Login, newPassword, Environment.NewLine));

                if (send)
                {
                    captions.TryGetValue("RestoreSent", out var restoreSent);
                    this.ShowMessage(restoreSent, McbaSettings.MessageTitle);
                    return;
                }

                MailHelper.SaveNewPassword(user.Email, restoreSubject,
                    string.Format(restoreBody, newPassword, Environment.NewLine));

                captions.TryGetValue("RestoreSaved", out var restoreSaved);
                this.ShowMessage(string.Format(restoreSaved, McbaSettings.TempFolder), McbaSettings.MessageTitle);
            }

            LoadGrid();
        }

        private bool Valida()
        {
            var ret = true;

            if (IdUsuario == 0 && txtUsuario.Text == string.Empty)
            {
                captions.TryGetValue("FaltaUsuario", out var caption);
                errorProvider.SetError(txtUsuario, caption);
                ret = false;
            }

            if (txtNombre.Text == string.Empty)
            {
                captions.TryGetValue("FaltaNombre", out var caption);
                errorProvider.SetError(txtNombre, caption);
                ret = false;
            }

            if (txtApellido.Text == string.Empty)
            {
                captions.TryGetValue("FaltaApellido", out var caption);
                errorProvider.SetError(txtApellido, caption);
                ret = false;
            }

            if (txtEmail.Text == string.Empty)
            {
                captions.TryGetValue("FaltaEmail", out var caption);
                errorProvider.SetError(txtEmail, caption);
                ret = false;
            }

            if (cmbIdiomas.SelectedIndex == -1)
            {
                captions.TryGetValue("FaltaIdioma", out var caption);
                errorProvider.SetError(cmbIdiomas, caption);
                ret = false;
            }

            if (!ret)
            {
                captions.TryGetValue("RevisarErrores", out var caption);
                this.ShowMessage(caption);
            }

            return ret;
        }

        private void SetUser(string id)
        {
            errorProvider.Clear();
            ControlsEnabled(false);

            var userId = int.Parse(id);
            var user = new UserBll().GetUser(userId);

            if (user == null)
            {
                captions.TryGetValue("NoEncontrado", out var caption);
                this.ShowMessage(string.Format(caption, Environment.NewLine));
                return;
            }

            IdUsuario = userId;
            txtId.Text = user.Id.ToString();
            txtEmail.Text = user.Email;
            txtNombre.Text = user.Nombre;
            txtApellido.Text = user.Apellido;
            cmbIdiomas.SelectedValue = user.IdIdioma;
        }
    }
}