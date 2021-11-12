using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using Mcba.Entidad.Enums;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.UI
{
    public partial class PermisosUsuarios : Form
    {
        private const string COL_ID_FAMILIA = "IdFd";
        private const string COL_NOMBRE_FAMILIA = "NombreFd";
        private const string COL_ID_FAMILIA_ASIGNADA = "IdFa";
        private const string COL_NOMBRE_FAMILIA_ASIGNADA = "NombreFa";

        private const string COL_ID_PERMISO = "IdPd";
        private const string COL_NOMBRE_PERMISO = "NombrePd";
        private const string COL_ID_PERMISO_ASIGNADO = "IdPa";
        private const string COL_NOMBRE_PERMISO_ASIGNADO = "NombrePa";
        private const string COL_TIPO_PERMISO_ASIGNADO = "TipoPermiso";

        private readonly UserLogged userLogged = UserLogged.GetInstance();
        private Dictionary<string, string> captions = new Dictionary<string, string>();
        private DataTable tipoPermisoSource;

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
            LoadTipoPermiso();
            SetGrids();

            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void LoadTipoPermiso()
        {
            tipoPermisoSource = typeof(TipoPermisoEnum).EnumToDataTable();
        }

        private void btnAddFamilia_Click(object sender, EventArgs e)
        {
            AddFamilia();
        }

        private void btnRemoveFamilia_Click(object sender, EventArgs e)
        {
            RemoveFamilia();
        }

        private void btnAddPermiso_Click(object sender, EventArgs e)
        {
            AddPermiso();
        }

        private void btnRemovePermiso_Click(object sender, EventArgs e)
        {
            RemovePermiso();
        }

        private void dgvPermisosAsignados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // solo para que no se produzca la excepción "El valor de DataGridViewComboBoxCell no es válido."
        }

        private void dgvPermisosAsignados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvPermisosAsignados.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvPermisosAsignados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string comboboxSelectedValue = string.Empty;

            if (dgvPermisosAsignados.Columns[e.ColumnIndex].GetType() == typeof(DataGridViewComboBoxColumn))
            {
                comboboxSelectedValue = dgvPermisosAsignados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void SetGrids()
        {
            dgvFamilias.AutoGenerateColumns = false;
            dgvFamiliasAsignadas.AutoGenerateColumns = false;

            dgvPermisos.AutoGenerateColumns = false;
            dgvPermisosAsignados.AutoGenerateColumns = false;

            var cbc = dgvPermisosAsignados.Columns["TipoPermiso"] as DataGridViewComboBoxColumn;

            cbc.DataSource = tipoPermisoSource;
            cbc.DisplayMember = "Desc";
            cbc.ValueMember = "Id";

            dgvFamilias.Columns[COL_ID_FAMILIA].Visible = false;
            dgvFamiliasAsignadas.Columns[COL_ID_FAMILIA_ASIGNADA].Visible = false;
            dgvPermisos.Columns[COL_ID_PERMISO].Visible = false;
            dgvPermisosAsignados.Columns[COL_ID_PERMISO_ASIGNADO].Visible = false;
        }

        private void RemovePermiso()
        {
            if (dgvPermisosAsignados.SelectedRows.Count == 0)
            {
                return;
            }

            if (!(cmbUsuarios.SelectedItem is UserDto user))
            {
                return;
            }

            var msj = new StringBuilder();
            var sep = string.Empty;

            var permisoBll = new PermisoBll();

            foreach (DataGridViewRow row in dgvPermisosAsignados.SelectedRows)
            {
                var idPermiso = int.Parse(row.Cells[COL_ID_PERMISO_ASIGNADO].Value.ToString());
                var nombre = row.Cells[COL_NOMBRE_PERMISO_ASIGNADO].Value.ToString();

                bool ok = permisoBll.ValidarRemovePermisoUsuario(user.Id, idPermiso);

                if (!ok)
                {
                    msj.Append($"{sep}{nombre}");
                    sep = ", ";

                    continue;
                }

                dgvPermisos.Rows.Add(idPermiso, nombre);
                dgvPermisosAsignados.Rows.Remove(row);
            }

            if (msj.Length > 0)
            {
                captions.TryGetValue("NoSePuedeQuitarPermiso", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, msj),
                    McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RemoveFamilia()
        {
            if (dgvFamiliasAsignadas.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvFamiliasAsignadas.SelectedRows)
            {
                var id = Int32.Parse(row.Cells[COL_ID_FAMILIA_ASIGNADA].Value.ToString());
                var nombre = row.Cells[COL_NOMBRE_FAMILIA_ASIGNADA].Value.ToString();

                dgvFamilias.Rows.Add(id, nombre);
                dgvFamiliasAsignadas.Rows.Remove(row);
            }
        }

        private void AddPermiso()
        {
            if (dgvPermisos.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvPermisos.SelectedRows)
            {
                var id = Int32.Parse(row.Cells[COL_ID_PERMISO].Value.ToString());
                var nombre = row.Cells[COL_NOMBRE_PERMISO].Value.ToString();

                dgvPermisosAsignados.Rows.Add(id, nombre, (int)TipoPermisoEnum.Gestion);
                dgvPermisos.Rows.Remove(row);
            }
        }

        private void AddFamilia()
        {
            if (dgvFamilias.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvFamilias.SelectedRows)
            {
                var id = Int32.Parse(row.Cells[COL_ID_FAMILIA].Value.ToString());
                var nombre = row.Cells[COL_NOMBRE_FAMILIA].Value.ToString();

                dgvFamiliasAsignadas.Rows.Add(id, nombre);
                dgvFamilias.Rows.Remove(row);
            }
        }

        private void LoadGrids(UserDto user)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                CleanGrillas();

                LoadFamiliasDisponibles(user.Id);
                LoadPermisosDisponibles(user.Id);
                LoadFamiliasAsignadas(user.Id);
                LoadPermisosAsignados(user.Id);

                Cursor = Cursors.Default;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                captions.TryGetValue("ErrorAlGuardar", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine, ex.Message), McbaSettings.MessageTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanGrillas()
        {
            dgvFamilias.Rows.Clear();
            dgvFamiliasAsignadas.Rows.Clear();
            dgvPermisos.Rows.Clear();
            dgvPermisosAsignados.Rows.Clear();
        }

        private void LoadPermisosAsignados(int userId)
        {
            IEnumerable<PermisoDto> result = new UserBll().GetPermisos(userId).ToList();

            if (!result.Any())
            {
                return;
            }

            foreach (var pd in result)
            {
                //var tipoPermiso = pd.IdTipoPermiso.ToString();
                dgvPermisosAsignados.Rows.Add(pd.Id, pd.Nombre);

                DataGridViewRow gridRow = dgvPermisosAsignados.Rows[dgvPermisosAsignados.Rows.Count - 1];
                DataGridViewComboBoxCell rcbc = (gridRow.Cells[COL_TIPO_PERMISO_ASIGNADO] as DataGridViewComboBoxCell);
                rcbc.Value = (int)pd.IdTipoPermiso;
            }
        }

        private void LoadFamiliasAsignadas(int userId)
        {
            IEnumerable<FamiliaDto> result = new UserBll().GetFamilias(userId).ToList();

            if (!result.Any())
            {
                return;
            }

            foreach (var pd in result)
            {
                dgvFamiliasAsignadas.Rows.Add(pd.Id, pd.Nombre);
            }
        }

        private void LoadFamiliasDisponibles(int userId)
        {
            IEnumerable<FamiliaDto> result = new FamiliaBll().GetDisponibles(userId).ToList();

            if (!result.Any())
            {
                return;
            }

            foreach (var pd in result)
            {
                dgvFamilias.Rows.Add(pd.Id, pd.Nombre);
            }
        }

        private void LoadPermisosDisponibles(int userId)
        {
            IEnumerable<PermisoDto> result = new UserBll().GetPermisosDisponibles(userId).ToList();

            dgvPermisos.AutoGenerateColumns = false;

            if (!result.Any())
            {
                return;
            }
            
            foreach (var pd in result)
            {
                dgvPermisos.Rows.Add(pd.Id, pd.Nombre);
            }
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
            if (!(cmbUsuarios.SelectedItem is UserDto user))
            {
                return;
            }

            if (!Valida())
            {
                return;
            }

            var familias = new List<int>();
            foreach (DataGridViewRow row in dgvFamiliasAsignadas.Rows)
            {
                familias.Add((int)row.Cells[COL_ID_FAMILIA_ASIGNADA].Value);
            }

            var permisos = new Dictionary<int, int>();
            foreach (DataGridViewRow row in dgvPermisosAsignados.Rows)
            {
                var tipoPermiso = (TipoPermisoEnum)Enum.Parse(typeof(TipoPermisoEnum), row.Cells[COL_TIPO_PERMISO_ASIGNADO].Value.ToString());
                permisos.Add((int)row.Cells[COL_ID_PERMISO_ASIGNADO].Value, (int)tipoPermiso);
            }

            try
            {
                var permiso = userLogged.GetPermiso($"tsmi{Name}");
                var bitacora = new Bitacora()
                {
                    Login = userLogged.CryptLogin,
                    FechaHora = DateTime.Now,
                    Criticidad = permiso.Criticidad,
                    Patente = HashCalculator.Encrypt($"{permiso.Nombre} - {permiso.TipoPermiso.ToString()}",
                        McbaSettings.Key, McbaSettings.Salt)
                };

                var userBll = new UserBll();

                bitacora.Descripcion = HashCalculator.Encrypt("Asignar familias a usuario", McbaSettings.Key, McbaSettings.Salt);
                userBll.AsignarFamilias(user.Id, familias, bitacora);

                bitacora.Descripcion = HashCalculator.Encrypt("Asignar permisos a usuario", McbaSettings.Key, McbaSettings.Salt);
                userBll.AsignarPermisos(user.Id, permisos, bitacora);

                LoadGrids(user);
            }
            catch (Exception ex)
            {
                captions.TryGetValue("ErrorAlGuardar", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine, ex.Message));
            }
        }

        private bool Valida()
        {
            if (!(cmbUsuarios.SelectedItem is UserDto user))
            {
                captions.TryGetValue("SinUsuario", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));

                return false;
            }

            if (dgvPermisosAsignados.Rows.Count == 0)
            {
                captions.TryGetValue("SinSeleccion", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));

                return false;
            }

            foreach (DataGridViewRow row in dgvPermisosAsignados.Rows)
            {
                if (row.Cells[COL_TIPO_PERMISO_ASIGNADO].Value == null)
                {
                    captions.TryGetValue("FaltaPermiso", out var caption);
                    this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine));

                    return false;
                }
            }

            return true;
        }
    }
}