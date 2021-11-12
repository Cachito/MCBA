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
    public partial class PermisosFamilias : Form
    {
        private const string COL_ID_USUARIO = "IdUd";
        private const string COL_NOMBRE_USUARIO = "NombreUd";
        private const string COL_ID_USUARIO_ASIGNADO = "IdUa";
        private const string COL_NOMBRE_USUARIO_ASIGNADA = "NombreUa";

        private const string COL_ID_PERMISO = "IdPd";
        private const string COL_NOMBRE_PERMISO = "NombrePd";
        private const string COL_ID_PERMISO_ASIGNADO = "IdPa";
        private const string COL_NOMBRE_PERMISO_ASIGNADO = "NombrePa";
        private const string COL_TIPO_PERMISO_ASIGNADO = "TipoPermiso";

        private readonly UserLogged userLogged = UserLogged.GetInstance();
        private Dictionary<string, string> captions = new Dictionary<string, string>();
        private DataTable tipoPermisoSource;

        public PermisosFamilias()
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

        private void cmbFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbFamilias.SelectedItem is FamiliaDto familia))
            {
                return;
            }

            LoadGrids(familia);
        }

        private void PermisosFamilias_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            SetCaptions();
            LoadFamilias();
            LoadTipoPermiso();
            SetGrids();

            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void LoadTipoPermiso()
        {
            tipoPermisoSource = typeof(TipoPermisoEnum).EnumToDataTable();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            AddUsuario();
        }

        private void btnRemoveUsuario_Click(object sender, EventArgs e)
        {
            RemoveUsuario();
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
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuariosAsignadas.AutoGenerateColumns = false;

            dgvPermisos.AutoGenerateColumns = false;
            dgvPermisosAsignados.AutoGenerateColumns = false;

            var cbc = dgvPermisosAsignados.Columns["TipoPermiso"] as DataGridViewComboBoxColumn;

            cbc.DataSource = tipoPermisoSource;
            cbc.DisplayMember = "Desc";
            cbc.ValueMember = "Id";

            dgvUsuarios.Columns[COL_ID_USUARIO].Visible = false;
            dgvUsuariosAsignadas.Columns[COL_ID_USUARIO_ASIGNADO].Visible = false;
            dgvPermisos.Columns[COL_ID_PERMISO].Visible = false;
            dgvPermisosAsignados.Columns[COL_ID_PERMISO_ASIGNADO].Visible = false;
        }

        private void RemovePermiso()
        {
            if (dgvPermisosAsignados.SelectedRows.Count == 0)
            {
                return;
            }

            if (!(cmbFamilias.SelectedItem is FamiliaDto familia))
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

                bool ok = permisoBll.ValidarRemovePermisoFamilia(familia.Id, idPermiso);

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

        private void RemoveUsuario()
        {
            if (dgvUsuariosAsignadas.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvUsuariosAsignadas.SelectedRows)
            {
                var id = Int32.Parse(row.Cells[COL_ID_USUARIO_ASIGNADO].Value.ToString());
                var nombre = row.Cells[COL_NOMBRE_USUARIO_ASIGNADA].Value.ToString();

                dgvUsuarios.Rows.Add(id, nombre);
                dgvUsuariosAsignadas.Rows.Remove(row);
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

        private void AddUsuario()
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvUsuarios.SelectedRows)
            {
                var id = Int32.Parse(row.Cells[COL_ID_USUARIO].Value.ToString());
                var nombre = row.Cells[COL_NOMBRE_USUARIO].Value.ToString();

                dgvUsuariosAsignadas.Rows.Add(id, nombre);
                dgvUsuarios.Rows.Remove(row);
            }
        }

        private void LoadGrids(FamiliaDto familia)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                CleanGrillas();

                LoadUsuariosDisponibles(familia.Id);
                LoadPermisosDisponibles(familia.Id);
                LoadUsuariosAsignados(familia.Id);
                LoadPermisosAsignados(familia.Id);

                Cursor = Cursors.Default;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                this.ShowMessage($"Error al cargar grillas.{Environment.NewLine}{ex.Message}",
                    McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanGrillas()
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuariosAsignadas.Rows.Clear();
            dgvPermisos.Rows.Clear();
            dgvPermisosAsignados.Rows.Clear();
        }

        private void LoadPermisosAsignados(int familiaId)
        {
            IEnumerable<PermisoDto> result = new FamiliaBll().GetPermisos(familiaId).ToList();

            if (!result.Any())
            {
                return;
            }

            foreach (var pd in result)
            {
                var tipoPermiso = pd.IdTipoPermiso.ToString();
                dgvPermisosAsignados.Rows.Add(pd.Id, pd.Nombre);

                DataGridViewRow gridRow = dgvPermisosAsignados.Rows[dgvPermisosAsignados.Rows.Count - 1];
                DataGridViewComboBoxCell rcbc = (gridRow.Cells[COL_TIPO_PERMISO_ASIGNADO] as DataGridViewComboBoxCell);
                rcbc.Value = (int)pd.IdTipoPermiso;
            }
        }

        private void LoadUsuariosAsignados(int familiaId)
        {
            IEnumerable<UserDto> result = new FamiliaBll().GetUsuarios(familiaId).ToList();

            if (!result.Any())
            {
                return;
            }

            foreach (var pd in result)
            {
                dgvUsuariosAsignadas.Rows.Add(pd.Id, pd.NombreCompleto);
            }
        }

        private void LoadUsuariosDisponibles(int familiaId)
        {
            IEnumerable<UserDto> result = new FamiliaBll().GetUsuariosDisponibles(familiaId).ToList();

            if (!result.Any())
            {
                return;
            }

            foreach (var pd in result)
            {
                dgvUsuarios.Rows.Add(pd.Id, pd.NombreCompleto);
            }
        }

        private void LoadPermisosDisponibles(int familiaId)
        {
            IEnumerable<PermisoDto> result = new FamiliaBll().GetPermisosDisponibles(familiaId).ToList();

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

        private void LoadFamilias()
        {
            Detach();

            IEnumerable<FamiliaDto> familias = new FamiliaBll().GetByActivo(true);
            cmbFamilias.DataSource = null;
            cmbFamilias.DataSource = familias;
            cmbFamilias.ValueMember = "Id";
            cmbFamilias.DisplayMember = "Nombre";
            cmbFamilias.SelectedIndex = -1;

            Atach();
        }

        private void Atach()
        {
            cmbFamilias.SelectedIndexChanged += cmbFamilias_SelectedIndexChanged;
        }

        private void Detach()
        {
            cmbFamilias.SelectedIndexChanged -= cmbFamilias_SelectedIndexChanged;
        }

        private void Save()
        {
            if (!(cmbFamilias.SelectedItem is FamiliaDto familia))
            {
                return;
            }

            if (!Valida())
            {
                return;
            }

            var usuarios = new List<int>();
            foreach (DataGridViewRow row in dgvUsuariosAsignadas.Rows)
            {
                usuarios.Add((int)row.Cells[COL_ID_USUARIO_ASIGNADO].Value);
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

                var familiaBll = new FamiliaBll();

                bitacora.Descripcion = HashCalculator.Encrypt("Asignar usuarios a familia", McbaSettings.Key, McbaSettings.Salt);
                familiaBll.AsignarUsuarios(familia.Id, usuarios, bitacora);

                bitacora.Descripcion = HashCalculator.Encrypt("Asignar permisos a familia", McbaSettings.Key, McbaSettings.Salt);
                familiaBll.AsignarPermisos(familia.Id, permisos, bitacora);

                LoadGrids(familia);
            }
            catch (Exception ex)
            {
                captions.TryGetValue("ErrorAlGuardar", out var caption);
                this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine, ex.Message));
            }
        }

        private bool Valida()
        {
            if (!(cmbFamilias.SelectedItem is FamiliaDto familia))
            {
                captions.TryGetValue("SinFamilia", out var caption);
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