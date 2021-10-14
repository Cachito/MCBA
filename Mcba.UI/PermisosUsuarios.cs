using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad.Dto;
using Mcba.Entidad.Enums;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class PermisosUsuarios : Form
    {
        private const int COL_ID_PERMISO = 0;
        private const int COL_NOMBRE_PERMISO = 1;
        private const int COL_TIPO_PERMISO = 2;

        private const int COL_ID_FAMILIA = 0;
        private const int COL_NOMBRE_FAMILIA = 1;
        private const int COL_ACTIVO_FAMILIA = 2;

        private Dictionary<string, string> captions = new Dictionary<string, string>();

        public PermisosUsuarios()
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

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbUsuarios.SelectedItem is UserDto user))
            {
                return;
            }

            LoadGrids(user);
        }

        private void PermisosUsuarios_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            SetCaptions();
            LoadUsuarios();

            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void LoadGrids(UserDto user)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                LoadFamiliasDisponibles(user.Id);
                LoadPermisosDisponibles(user.Id);
                LoadFamiliasAsignadas(user.Id);
                LoadPermisosAsignados(user.Id);

                Cursor = Cursors.Default;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                this.ShowMessage($"Error al cargar grillas.{Environment.NewLine}{ex.Message}",
                    McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadPermisosAsignados(int userId)
        {
            IEnumerable<PermisoDto> result = new PermisoBll().GetAsignados(userId).ToList();

            dgvPermisosAsignados.AutoGenerateColumns = false;
            dgvPermisosAsignados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermisosAsignados.Rows.Clear();
            dgvPermisosAsignados.Columns.Clear();

            if (!result.Any())
            {
                return;
            }

            var props = typeof(PermisoDto).GetProperties();

            foreach (var prop in props)
            {
                var ct = new DataGridViewTextBoxColumn { HeaderText = prop.Name };
                dgvPermisosAsignados.Columns.Add(ct);
            }

            var cb = new DataGridViewComboBoxColumn
            {
                HeaderText = "Tipo de Permiso",
                DataSource = Enum.GetValues(typeof(TipoPermisoEnum))
            };
            dgvPermisosAsignados.Columns.Add(cb);

            foreach (var pd in result)
            {
                dgvPermisosAsignados.Rows.Add(pd.Id, pd.Nombre);
            }

            dgvPermisosAsignados.Columns[COL_ID_PERMISO].Visible = false;
        }

        private void LoadFamiliasAsignadas(int userId)
        {
            IEnumerable<FamiliaDto> result = new FamiliaBll().GetAsignadas(userId).ToList();

            dgvFamiliasAsignadas.AutoGenerateColumns = false;
            dgvFamiliasAsignadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFamiliasAsignadas.Rows.Clear();
            dgvFamiliasAsignadas.Columns.Clear();

            if (!result.Any())
            {
                return;
            }

            var props = typeof(FamiliaDto).GetProperties();

            foreach (var prop in props)
            {
                var c = new DataGridViewTextBoxColumn() { HeaderText = prop.Name };
                dgvFamiliasAsignadas.Columns.Add(c);
            }

            foreach (var pd in result)
            {
                dgvFamilias.Rows.Add(pd.Id, pd.Nombre);
            }

            dgvFamiliasAsignadas.Columns[COL_ID_FAMILIA].Visible = false;
            dgvFamiliasAsignadas.Columns[COL_ACTIVO_FAMILIA].Visible = false;
        }

        private void LoadFamiliasDisponibles(int userId)
        {
            IEnumerable<FamiliaDto> result = new FamiliaBll().GetDisponibles(userId).ToList();

            dgvFamilias.AutoGenerateColumns = false;
            dgvFamilias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFamilias.Rows.Clear();
            dgvFamilias.Columns.Clear();

            if (!result.Any())
            {
                return;
            }

            var props = typeof(FamiliaDto).GetProperties();

            foreach (var prop in props)
            {
                var c = new DataGridViewTextBoxColumn() { HeaderText = prop.Name };
                dgvFamilias.Columns.Add(c);
            }

            foreach (var pd in result)
            {
                dgvFamilias.Rows.Add(pd.Id, pd.Nombre);
            }

            dgvFamilias.Columns[COL_ID_FAMILIA].Visible = false;
            dgvFamilias.Columns[COL_ACTIVO_FAMILIA].Visible = false;
        }

        private void LoadPermisosDisponibles(int userId)
        {
            IEnumerable<PermisoDto> result = new PermisoBll().GetDisponibles(userId).ToList();

            dgvPermisos.AutoGenerateColumns = false;
            dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermisos.Rows.Clear();
            dgvPermisos.Columns.Clear();

            if (!result.Any())
            {
                return;
            }

            var props = typeof(PermisoDto).GetProperties();

            foreach (var prop in props)
            {
                var c = new DataGridViewTextBoxColumn() { HeaderText = prop.Name};
                dgvPermisos.Columns.Add(c);
            }

            foreach (var pd in result)
            {
                dgvPermisos.Rows.Add(pd.Id, pd.Nombre);
            }

            dgvPermisos.Columns[COL_ID_PERMISO].Visible = false;
            dgvPermisos.Columns[COL_TIPO_PERMISO].Visible = false;
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }

        private void LoadUsuarios()
        {
            Detach();

            IEnumerable<UserDto> usuarios = new UserBll().GetByActivo(true);
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = usuarios;
            cmbUsuarios.ValueMember = "Id";
            cmbUsuarios.DisplayMember = "NombreCompleto";
            cmbUsuarios.SelectedIndex = -1;

            Atach();
        }

        private void Atach()
        {
            cmbUsuarios.SelectedIndexChanged += cmbUsuarios_SelectedIndexChanged;
        }

        private void Detach()
        {
            cmbUsuarios.SelectedIndexChanged -= cmbUsuarios_SelectedIndexChanged;
        }

        private void Save()
        {
            if (!Valida())
            {
                return;
            }

            LoadUsuarios();
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();


            return ret;
        }
    }
}