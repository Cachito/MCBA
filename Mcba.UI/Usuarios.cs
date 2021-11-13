using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Enums;
using Mcba.Infraestruture.Helpers;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Usuarios : ViewBase
    {
        private readonly UserLogged userLogged = UserLogged.GetInstance();
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        private int IdUsuario { set; get; }
        private string Login { set; get; }
        private int GridRow { set; get; }

        private const int COL_ID = 0;
        private const int COL_ACTIVE = 4;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        protected internal override void LoadView()
        {
            base.LoadView();

            RestorePassVisible = true;
            ChangePassVisible = true;
            DeleteVisible = false;
            GridPage = 0;
            GridRow = 0;
            DataRowsCount = new UserBll().GetUsersCount();
            SetCaptions();
            LoadIdiomas();
            LoadGrid();
            SetUser();
        }

        protected internal override void Salir()
        {
            base.Salir();
            Close();
        }

        protected internal override void Undo()
        {
            base.Undo();

            ControlsEnabled(false);
            SetUser();
        }

        protected internal override void Clean()
        {
            base.Clean();

            IdUsuario = 0;
            txtId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            chkActivo.Checked = false;
            cmbIdiomas.SelectedIndex = -1;
        }

        protected internal override void New()
        {
            base.New();
            Clean();
            ControlsEnabled(true);
            chkActivo.Checked = true;
            SetToolbarStatus(ToolbarStatusEnum.New);
        }

        protected internal override void Edit()
        {
            base.Edit();
            ControlsEnabled(true);
        }

        protected internal override void Save()
        {
            base.Save();

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
                    Undo();
                    LoadGrid();

                    return;
                }
            }

            if (IdUsuario != 0 && chkActivo.Checked != user.Activo)
            {
                string caption;
                if (chkActivo.Checked)
                {
                    captions.TryGetValue("Activar", out caption);
                }
                else
                {
                    captions.TryGetValue("Desactivar", out caption);
                }

                var dr = this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine), McbaSettings.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr != DialogResult.Yes)
                {
                    Undo();
                    LoadGrid();

                    return;
                }
            }

            user.Nombre = txtNombre.Text;
            user.Apellido = txtApellido.Text;
            user.IdIdioma = (int)cmbIdiomas.SelectedValue;
            user.Email = txtEmail.Text;
            user.Activo = chkActivo.Checked;

            var userBll = new UserBll();

            var ok = userBll.Save(user, out var newPassword);
            if (!ok)
            {
                captions.TryGetValue("ErrorAlGuardar", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));
            }

            if (ok && user.Id == 0)
            {
                captions.TryGetValue("NewUserSubject", out var newUserSubject);
                captions.TryGetValue("NewUserBody", out var newUserBody);

                #region EnvioMail                
                //var send = MailHelper.SendMail(user.Email, newUserSubject,
                //    string.Format(restoreBody ?? McbaSettings.SinTraduccion, user.Login, newPassword, Environment.NewLine));

                //if (send)
                //{
                //    captions.TryGetValue("NewUserSent", out var newUserSent);
                //    this.ShowMessage(newUserSent, McbaSettings.MessageTitle);
                //    return;
                //}
                #endregion

                MailHelper.SaveToFile(user.Email, newUserSubject,
                    string.Format(newUserBody ?? McbaSettings.SinTraduccion, Login, newPassword, Environment.NewLine));

                captions.TryGetValue("NewUserSaved", out var restoreSaved);
                this.ShowMessage(string.Format(restoreSaved ?? McbaSettings.SinTraduccion, McbaSettings.TempFolder), McbaSettings.MessageTitle);
            }

            LoadGrid();
            SetUser();
        }

        protected internal override void Find(bool btnChecked)
        {
            base.Find(btnChecked);

            if (btnChecked)
            {
                Find();
            }
            else
            {
                LoadGrid();
            }
        }

        private void Find()
        {
            var searchText = string.Empty;

            using (var findFrm = new Busqueda {Titulo = Text})
            {
                if (findFrm.ShowDialog() != DialogResult.OK)
                {

                    LoadGrid();
                    return;
                }

                searchText = findFrm.TextoBuscado;
            }

            GridPage = 0;
            var result = new UserBll().FindPage(searchText, GridPage);

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = result;

            dgvUsuarios.Columns[COL_ID].Visible = false;
            dgvUsuarios.Columns[COL_ACTIVE].Visible = false;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            GridRow = e.RowIndex;
            SetUser();
        }

        protected internal override void ChangePass()
        {
            base.ChangePass();

            var userBll = new UserBll();
            var userChange = userBll.GetUser(IdUsuario);

            var frm = new CambioPassword();

            if (OpenFormsHelper.CheckIfFormIsOpen(frm.Name))
            {
                var frmExist = OpenFormsHelper.GetOpened(frm.Name);
                frmExist.Dispose();
            }

            frm = new CambioPassword
            {
                UserChange = userChange
            };

            frm.ShowDialog();
            frm.BringToFront();
        }

        protected internal override void RestorePass()
        {
            base.RestorePass();

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

            #region EnvioMail
            //var send = MailHelper.SendMail(userEmail, restoreSubject,
            //    string.Format(restoreBody ?? McbaSettings.SinTraduccion, newPassword, Environment.NewLine));

            //if (send)
            //{
            //    captions.TryGetValue("RestoreSent", out var restoreSent);
            //    this.ShowMessage(restoreSent, McbaSettings.MessageTitle);
            //    return;
            //}
            #endregion

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
            var usersPage = new UserBll().GetPage(GridPage);
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usersPage;

            dgvUsuarios.Columns[COL_ID].Visible = false;
            dgvUsuarios.Columns[COL_ACTIVE].Visible = false;

            SetToolbarStatus(ToolbarStatusEnum.Default);
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

        private void ControlsEnabled(bool enable)
        {
            txtEmail.Enabled = enable;
            txtNombre.Enabled = enable;
            txtApellido.Enabled = enable;
            cmbIdiomas.Enabled = enable;
            chkActivo.Enabled = enable && IdUsuario != 0;
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

            if (IdUsuario == 0)
            {
                Login = UserNameGeneratorHelper.GetUsername(txtNombre.Text, txtApellido.Text);
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

            if (new UserBll().EmailExist(txtEmail.Text, IdUsuario))
            {
                captions.TryGetValue("EmailExistente", out var caption);
                errorProvider.SetError(txtEmail, caption);
                ret = false;
            }

            if (cmbIdiomas.SelectedIndex == -1)
            {
                captions.TryGetValue("FaltaIdioma", out var caption);
                errorProvider.SetError(cmbIdiomas, caption);
                ret = false;
            }

            // No puedo eliminar el usuario si es el mismo que está logueado
            if (IdUsuario == userLogged.Id && !chkActivo.Checked && chkActivo.Checked != userLogged.Activo)
            {
                captions.TryGetValue("EliminarSelf", out var caption);
                this.ShowMessage(caption);
                ret = false;
            }

            // No puedo eliminar un usuario si deja permisos huérfanos
            if (IdUsuario != 0 && !chkActivo.Checked)
            {
                var userBll = new UserBll();
                var user = userBll.GetUser(IdUsuario);
                if (chkActivo.Checked != user.Activo)
                {
                    var permisoBll = new PermisoBll();
                    if (permisoBll.DejaPermisosHerfanos(IdUsuario))
                    {
                        captions.TryGetValue("PermisosHuerfanos", out var caption);
                        this.ShowMessage(string.Format(caption,
                            $"{user.Nombre} {user.Apellido} (id:{user.Id})"));
                        ret = false;
                    }
                }
            }

            if (!ret)
            {
                captions.TryGetValue("RevisarErrores", out var caption);
                this.ShowMessage(caption);
            }

            return ret;
        }

        private void SetUser()
        {
            errorProvider.Clear();

            SetToolbarStatus(ToolbarStatusEnum.None);
            ControlsEnabled(false);

            var row = dgvUsuarios.Rows[GridRow];
            var id = row.Cells[0].Value.ToString();
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

            SetToolbarStatus(ToolbarStatusEnum.Default);
        }

        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                row.DefaultCellStyle.BackColor = (bool)row.Cells[COL_ACTIVE].Value ? SystemColors.Window : Color.Red;
                row.DefaultCellStyle.ForeColor = (bool)row.Cells[COL_ACTIVE].Value ? SystemColors.ControlText : Color.White;
            }
        }
    }
}