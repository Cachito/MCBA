using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Enums;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.UI
{
    public partial class Familias : ViewBase
    {
        private readonly UserLogged userLogged = UserLogged.GetInstance();
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        private int IdFamilia { set; get; }
        private int GridRow { set; get; }

        private const int COL_ID = 0;
        private const int COL_ACTIVE = 2;

        public Familias()
        {
            InitializeComponent();
        }

        private void Familias_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        protected internal override void LoadView()
        {
            DeleteVisible = false;
            GridPage = 0;
            GridRow = 0;
            DataRowsCount = new FamiliaBll().GetFamiliasCount();
            SetCaptions();
            LoadGrid();
            SetFamilia();
            SetToolbarStatus(ToolbarStatusEnum.Default);
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
            SetFamilia();
        }

        protected internal override void Clean()
        {
            base.Clean();

            IdFamilia= 0;
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkActivo.Checked = false;
        }

        protected internal override void New()
        {
            base.New();
            Clean();
            ControlsEnabled(true);
            SetToolbarStatus(ToolbarStatusEnum.New);
        }

        protected internal override void Edit()
        {
            base.Edit();
            ControlsEnabled(true);
        }

        protected internal override void Save()
        {
            if (!Valida())
            {
                return;
            }

            base.Save();

            var bitacora = new Bitacora
            {
                Login = userLogged.CryptLogin,
                Descripcion = "Guardar Familia",
                FechaHora = DateTime.Now
            };

            FamiliaDto familia;
            if (IdFamilia == 0)
            {
                familia = new FamiliaDto();
                bitacora.Descripcion = $"{bitacora.Descripcion} nueva.";
            }
            else
            {
                familia = new FamiliaBll().GetFamilia(IdFamilia);
                bitacora.Descripcion = $"{bitacora.Descripcion} modificación.";
                if (familia == null)
                {
                    captions.TryGetValue("NoEncontrado", out var caption);
                    this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));
                    Undo();
                    LoadGrid();

                    return;
                }
            }

            if (IdFamilia != 0 && !chkActivo.Checked && familia.Activo != chkActivo.Checked)
            {
                bitacora.Descripcion = $"{bitacora.Descripcion} Desactivar.";
                captions.TryGetValue("DesactivarWarning", out var caption);
                var dr = this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine), McbaSettings.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr != DialogResult.Yes)
                {
                    Undo();
                    LoadGrid();

                    return;
                }
            }

            familia.Nombre = txtNombre.Text;
            familia.Activo = IdFamilia == 0 || chkActivo.Checked;

            var familiaBll = new FamiliaBll();

            var ok = false;
            try
            {
                var permiso = userLogged.GetPermiso($"tsmi{Name}");
                bitacora.Descripcion = HashCalculator.Encrypt(bitacora.Descripcion, McbaSettings.Key, McbaSettings.Salt);
                bitacora.Criticidad = permiso.Criticidad;
                bitacora.Patente = HashCalculator.Encrypt($"{permiso.Nombre} - {permiso.TipoPermiso.ToString()}",
                    McbaSettings.Key, McbaSettings.Salt);

                ok = familiaBll.Save(familia, bitacora);
            }
            catch (Exception ex)
            {
                this.ShowMessage(string.Format(ex.Message), McbaSettings.MessageTitle);
            }

            if (!ok)
            {
                captions.TryGetValue("ErrorAlGuardar", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine),
                    McbaSettings.MessageTitle);
            }

            LoadGrid();
            SetFamilia();
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
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

            using (var findFrm = new Busqueda { Titulo = Text })
            {
                if (findFrm.ShowDialog() != DialogResult.OK)
                {
                    LoadGrid();
                    return;
                }

                searchText = findFrm.TextoBuscado;
            }

            GridPage = 0;
            var result = new FamiliaBll().FindPage(searchText, GridPage);

            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = result;

            dgvFamilias.Columns[COL_ID].Visible = false;
            dgvFamilias.Columns[COL_ACTIVE].Visible = false;
        }

        private void dgvFamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            GridRow = e.RowIndex;
            SetFamilia();
        }

        private void LoadGrid()
        {
            var familiaPage = new FamiliaBll().GetPage(GridPage);
            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = familiaPage;

            dgvFamilias.Columns[COL_ID].Visible = false;
            dgvFamilias.Columns[COL_ACTIVE].Visible = false;

            SetToolbarStatus(ToolbarStatusEnum.Default);
        }

        private void ControlsEnabled(bool enable)
        {
            txtNombre.Enabled = enable;
            chkActivo.Enabled = enable;
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                captions.TryGetValue("FaltaNombre", out var caption);
                mess.Append(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));
                ret = false;
            }

            var familiaBll = new FamiliaBll();
            var f = familiaBll.GetFamilia(IdFamilia);

            if (IdFamilia != 0 && !chkActivo.Checked && chkActivo.Checked != f.Activo)
            {
                var permisoBll = new PermisoBll();
                var ok = permisoBll.ValidarDeleteFamilia(IdFamilia);

                if (!ok)
                {
                    captions.TryGetValue("NoSePuedeEliminar", out var caption);
                    mess.Append(string.Format(caption ?? McbaSettings.SinTraduccion, f.Nombre));
                    ret = false;
                }
            }
            
            if (!ret)
            {
                this.ShowMessage(mess.ToString(), McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            return ret;
        }

        private void SetFamilia()
        {
            errorProvider.Clear();

            SetToolbarStatus(ToolbarStatusEnum.None);
            ControlsEnabled(false);

            if (dgvFamilias.Rows.Count > 0)
            {
                var row = dgvFamilias.Rows[GridRow];
                var id = row.Cells[0].Value.ToString();
                ControlsEnabled(false);

                var familiaId = int.Parse(id);
                var familia = new FamiliaBll().GetFamilia(familiaId);

                if (familia == null)
                {
                    captions.TryGetValue("NoEncontrado", out var caption);
                    this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));
                    return;
                }

                IdFamilia = familiaId;
                txtId.Text = familia.Id.ToString();
                txtNombre.Text = familia.Nombre;
                chkActivo.Checked = familia.Activo;
            }

            SetToolbarStatus(ToolbarStatusEnum.Default);
        }

        private void dgvFamilias_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvFamilias.Rows)
            {
                row.DefaultCellStyle.BackColor = (bool)row.Cells[COL_ACTIVE].Value ? SystemColors.Window : Color.Red;
                row.DefaultCellStyle.ForeColor = (bool)row.Cells[COL_ACTIVE].Value ? SystemColors.ControlText : Color.White;
            }
        }
    }
}