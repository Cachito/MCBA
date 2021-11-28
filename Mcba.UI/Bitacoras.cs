using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad;
using Mcba.Entidad.Dto;
using Mcba.Entidad.Enums;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Bitacoras : Form
    {
        private Dictionary<string, string> captions = new Dictionary<string, string>();
        private readonly UserLogged userLogged = UserLogged.GetInstance();

        private const int CRITICIDAD_COL_ID = 1;

        public Bitacoras()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Buscar();
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Imprimir();
            }
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            SetCaptions();
            SetPermissions();
            LoadUsuarios();
            LoadCriticidad();
        }

        private bool Valida()
        {
            if (cmbCriticidad.SelectedIndex == -1)
            {
                captions.TryGetValue("FaltaCriticidad", out var caption);
                this.ShowMessage(caption ?? McbaSettings.SinTraduccion);

                return false;
            }

            if (cmbUsuarios.SelectedIndex == -1)
            {
                captions.TryGetValue("FaltaUsuario", out var caption);
                this.ShowMessage(caption ?? McbaSettings.SinTraduccion);

                return false;
            }

            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                captions.TryGetValue("LapsoInvalido", out var caption);
                this.ShowMessage(caption ?? McbaSettings.SinTraduccion);

                return false;
            }

            return true;
        }

        private IEnumerable<BitacoraDto> GetData()
        {
            var usuario = cmbUsuarios.SelectedItem as UserDto;
            var criticidadRow = cmbCriticidad.SelectedItem as DataRowView;

            var idUsuario = usuario.Id;
            var criticidad = (int)criticidadRow[CRITICIDAD_COL_ID];

            var bitacoraBll = new BitacoraBll();
            return bitacoraBll.GetBitacoras(idUsuario, criticidad);
        }

        private void Imprimir()
        {
            var bitacoras = GetData().ToList();

            if (!bitacoras.Any())
            {
                return;
            }

            using (var frmRep = new ReporteBitacora {Data = bitacoras})
            {
                frmRep.ShowDialog();
            }
        }

        private void Buscar()
        {
            var bitacoras = GetData();

            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = bitacoras;

            foreach (DataGridViewColumn column in dgvBitacora.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void LoadCriticidad()
        {
            var criticidadSource = typeof(CriticidadEnum).EnumToDataTable();

            var row = criticidadSource.NewRow();
            row["Id"] = -1;
            row["Desc"] = "[Todo]";
            criticidadSource.Rows.Add(row);

            //Sorting the Table
            var dv = criticidadSource.DefaultView;
            dv.Sort = "Desc";
            var criticidadSorted = dv.ToTable();
            
            cmbCriticidad.DataSource = criticidadSorted;
            cmbCriticidad.DisplayMember = "Desc";
            cmbCriticidad.ValueMember = "Id";
            cmbCriticidad.SelectedIndex = -1;
        }

        private void LoadUsuarios()
        {
            IEnumerable<UserDto> usuarios = new UserBll().GetByActivo(true);
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = usuarios;
            cmbUsuarios.ValueMember = "Id";
            cmbUsuarios.DisplayMember = "NombreCompleto";
            cmbUsuarios.SelectedIndex = -1;
        }

        private void SetPermissions()
        {
            var acceso = userLogged.GetPermiso($"tsmi{Name}").TipoPermiso;
            tsbFind.Enabled = (acceso & TipoPermisoEnum.Gestion) != 0 || (acceso & TipoPermisoEnum.Consulta) != 0;
            tsbPrint.Enabled = (acceso & TipoPermisoEnum.Gestion) != 0 || (acceso & TipoPermisoEnum.Consulta) != 0;
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }

        private void LoadGrid()
        {

        }

        private void Clean()
        {
            
        }

        private void Bitacoras_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this,
                McbaSettings.PathManual,
                "Bitacora.htm");
        }
    }
}