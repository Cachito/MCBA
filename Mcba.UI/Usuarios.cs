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
        private string Login { set; get; }
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
                this.ShowMessage(string.Format(mailCaption ?? McbaSettings.SinTraduccion, txtEmail.Text, Environment.NewLine),
                    McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            captions.TryGetValue("RestoreWarning", out var restoreCaption);
            var ok = this.ShowMessage(string.Format(restoreCaption ?? McbaSettings.SinTraduccion, txtEmail.Text, Environment.NewLine), McbaSettings.MessageTitle, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ok != DialogResult.Yes)
            {
                return;
            }

            var userBll = new UserBll();
            var newPassword = userBll.RestorePassword(Login);

            var userEmail = userBll.GetEmailByLogin(Login);

            captions.TryGetValue("RestoreSubject", out var restoreSubject);
            captions.TryGetValue("RestoreBody", out var restoreBody);
            var send = MailHelper.SendMail(userEmail, restoreSubject,
                string.Format(restoreBody ?? McbaSettings.SinTraduccion, newPassword, Environment.NewLine));

            if (send)
            {
                captions.TryGetValue("RestoreSent", out var restoreSent);
                this.ShowMessage(restoreSent, McbaSettings.MessageTitle);
                return;
            }

            MailHelper.SaveToFile(userEmail, restoreSubject,
                string.Format(restoreBody ?? McbaSettings.SinTraduccion, newPassword, Environment.NewLine));

            captions.TryGetValue("RestoreSaved", out var restoreSaved);
            this.ShowMessage(string.Format(restoreSaved ?? McbaSettings.SinTraduccion, McbaSettings.TempFolder), McbaSettings.MessageTitle);
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }

        private void LoadGrid()
        {
            var usersPage = new UserBll().Get(GridPage * McbaSettings.DataPagination);
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
            chkActivo.Checked = true;
            ControlsEnabled(true);
        }

        private void Clean()
        {
            IdUsuario = 0;
            txtId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            chkActivo.Checked = false;
            cmbIdiomas.SelectedIndex = -1;
        }

        private void ControlsEnabled(bool enable)
        {
            txtEmail.Enabled = enable;
            txtNombre.Enabled = enable;
            txtApellido.Enabled = enable;
            cmbIdiomas.Enabled = enable;
            chkActivo.Enabled = enable && IdUsuario != 0;
        }

        private void Save()
        {
            if (!Valida())
            {
                return;
            }

            User user;
            if (IdUsuario == 0)
            {
                user = new User
                {
                    Login = Login
                };
            }
            else
            {
                user = new UserBll().GetUser(IdUsuario);
                if (user == null)
                {
                    captions.TryGetValue("NoEncontrado", out var caption);
                    this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));
                    Clean();
                    LoadGrid();

                    return;
                }
            }

            user.Nombre = txtNombre.Text;
            user.Apellido = txtApellido.Text;
            user.IdIdioma = (int) cmbIdiomas.SelectedValue;
            user.Email = txtEmail.Text;
            user.Activo= chkActivo.Checked;

            var userBll = new UserBll();

            var ok = userBll.Save(user, out var newPassword);
            if (!ok)
            {
                captions.TryGetValue("ErrorAlGuardar", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));
            }

            if (ok && user.Id == 0)
            {
                captions.TryGetValue("RestoreSubject", out var restoreSubject);
                captions.TryGetValue("RestoreBody", out var restoreBody);

                #region EnvioMail                
                //var send = MailHelper.SendMail(user.Email, restoreSubject,
                //    string.Format(restoreBody ?? McbaSettings.SinTraduccion, user.Login, newPassword, Environment.NewLine));

                //if (send)
                //{
                //    captions.TryGetValue("RestoreSent", out var restoreSent);
                //    this.ShowMessage(restoreSent, McbaSettings.MessageTitle);
                //    return;
                //}
                #endregion

                MailHelper.SaveToFile(user.Email, restoreSubject,
                    string.Format(restoreBody ?? McbaSettings.SinTraduccion, newPassword, Environment.NewLine));

                captions.TryGetValue("RestoreSaved", out var restoreSaved);
                this.ShowMessage(string.Format(restoreSaved ?? McbaSettings.SinTraduccion, McbaSettings.TempFolder), McbaSettings.MessageTitle);
            }

            LoadGrid();
        }

        private bool Valida()
        {
            var ret = true;

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

            if (IdUsuario == 0 )
            {
                Login = UserNameGenerator.GetUsername(txtNombre.Text, txtApellido.Text);
                if (string.IsNullOrWhiteSpace(Login))
                {
                    ret = false;
                }
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
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));
                return;
            }

            IdUsuario = userId;
            Login = user.Login;
            txtId.Text = user.Id.ToString();
            txtEmail.Text = user.Email;
            txtNombre.Text = user.Nombre;
            txtApellido.Text = user.Apellido;
            cmbIdiomas.SelectedValue = user.IdIdioma;
            chkActivo.Checked = user.Activo;
        }
    }
}