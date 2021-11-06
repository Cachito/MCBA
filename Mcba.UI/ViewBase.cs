using System;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Entidad.Enums;
using Mcba.Infraestruture.Enums;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class ViewBase : Form
    {
        private readonly UserLogged userLogged = UserLogged.GetInstance();

        private bool SalirEnabled
        {
            set => tsbSalir.Enabled = value;
        }

        private bool UndoEnabled
        {
            set => tsbUndo.Enabled = value;
        }

        private bool NewEnabled
        {
            set => tsbNew.Enabled = value;
        }

        private bool DeleteEnabled
        {
            set => tsbDelete.Enabled = value;
        }

        private bool EditEnabled
        {
            set => tsbEdit.Enabled = value;
        }

        private bool SaveEnabled
        {
            set => tsbSave.Enabled = value;
        }

        private bool BuscarEnabled
        {
            set => tsbBuscar.Enabled = value;
        }

        private bool BuscarChecked
        {
            set => tsbBuscar.Checked = value;
        }

        private bool PreviousEnabled
        {
            set => tsbPrevious.Enabled = value;
        }

        private bool NextEnabled
        {
            set => tsbNext.Enabled = value;
        }

        private bool PrintEnabled
        {
            set => tsbPrint.Enabled = value;
        }

        private bool RestorePassEnabled
        {
            set => tsbRestorePass.Enabled = value;
        }

        protected internal bool RestorePassVisible
        {
            set => tsbRestorePass.Visible = value;
        }

        private bool ChangePassEnabled
        {
            set => tsbChangePass.Enabled = value;
        }

        protected internal bool ChangePassVisible
        {
            set => tsbChangePass.Visible = value;
        }

        protected internal bool DeleteVisible
        {
            set => tsbDelete.Visible = value;
        }

        protected internal int GridPage { set; get; }
        protected internal int DataRowsCount { set; get; }

        public ViewBase()
        {
            InitializeComponent();
        }

        private void ViewBase_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        private void tsbSalir_Click(object sender, System.EventArgs e)
        {
            Salir();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            //Find();
        }

        private void tsbBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripButton btn && btn.Name == "tsbBuscar")
            {
                Find(btn.Checked);
            }
        }

        private void tsbLeft_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void tsbRight_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void tsbRestaurar_Click(object sender, EventArgs e)
        {
            RestorePass();
        }

        private void tsbChangePass_Click(object sender, EventArgs e)
        {
            ChangePass();
        }

        private void tsbUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        protected internal virtual void Salir()
        {
            SetToolbarStatus(ToolbarStatusEnum.None);
        }

        protected internal virtual void Undo()
        {

        }

        protected internal virtual void New()
        {
            SetToolbarStatus(ToolbarStatusEnum.New);
        }

        protected internal virtual void Delete()
        {
            SetToolbarStatus(ToolbarStatusEnum.Delete);
        }

        protected internal virtual void Edit()
        {
            SetToolbarStatus(ToolbarStatusEnum.Edit);
        }

        protected internal virtual void Save()
        {
            SetToolbarStatus(ToolbarStatusEnum.None);
        }

        protected internal virtual void Print()
        {
            SetToolbarStatus(ToolbarStatusEnum.Print);
        }

        protected internal virtual void Find(bool btnChecked)
        {
            tsbBuscar.Image = btnChecked ? Properties.Resources.IconNoBuscar : Properties.Resources.IconBuscar;
            SetToolbarStatus(ToolbarStatusEnum.Find);
        }

        protected internal virtual void Previous()
        {

        }

        protected internal virtual void Next()
        {

        }

        protected internal virtual void RestorePass()
        {
            SetToolbarStatus(ToolbarStatusEnum.RestorePass);
        }

        protected internal virtual void ChangePass()
        {
            SetToolbarStatus(ToolbarStatusEnum.RestorePass);
        }

        protected internal virtual void Clean()
        {
            SetToolbarStatus(ToolbarStatusEnum.Default);
        }

        protected void SetToolbarStatus(ToolbarStatusEnum status)
        {
            Detach();

            TipoPermisoEnum acceso = userLogged.GetPermiso($"tsmi{Name}").TipoPermiso;

            SalirEnabled = status != ToolbarStatusEnum.Edit;
            UndoEnabled = status != ToolbarStatusEnum.Default && (acceso & TipoPermisoEnum.Gestion) != 0;
            NewEnabled = status == ToolbarStatusEnum.Default && (acceso & TipoPermisoEnum.Gestion) != 0;
            DeleteEnabled = (status == ToolbarStatusEnum.Default || status == ToolbarStatusEnum.Find) &&
                            (acceso & TipoPermisoEnum.Gestion) != 0;
            EditEnabled = (status == ToolbarStatusEnum.Default || status == ToolbarStatusEnum.Find) &&
                          (acceso & TipoPermisoEnum.Gestion) != 0;
            SaveEnabled = (status == ToolbarStatusEnum.New || status == ToolbarStatusEnum.Edit) &&
                          (acceso & TipoPermisoEnum.Gestion) != 0;
            BuscarEnabled = !(status == ToolbarStatusEnum.New || status == ToolbarStatusEnum.Delete) &&
                            ((acceso & TipoPermisoEnum.Gestion) != 0 || (acceso & TipoPermisoEnum.Consulta) != 0);

            if (status == ToolbarStatusEnum.Default)
            {
                BuscarChecked = false;
            }

            PreviousEnabled = (GridPage > 0 || status != ToolbarStatusEnum.Delete) &&
                              ((acceso & TipoPermisoEnum.Gestion) != 0 || (acceso & TipoPermisoEnum.Consulta) != 0);
            NextEnabled =
                ((DataRowsCount >= (GridPage == 0 ? 1 : GridPage) * McbaSettings.DataPagination) ||
                 status != ToolbarStatusEnum.Delete) &&
                ((acceso & TipoPermisoEnum.Gestion) != 0 || (acceso & TipoPermisoEnum.Consulta) != 0);
            PrintEnabled = (status == ToolbarStatusEnum.Default || status == ToolbarStatusEnum.Find) &&
                           ((acceso & TipoPermisoEnum.Gestion) != 0 || (acceso & TipoPermisoEnum.Consulta) != 0);
            RestorePassEnabled = (status == ToolbarStatusEnum.Default || status == ToolbarStatusEnum.Find) &&
                                 (acceso & TipoPermisoEnum.Gestion) != 0;
            ChangePassEnabled = (status == ToolbarStatusEnum.Default || status == ToolbarStatusEnum.Find) &&
                                (acceso & TipoPermisoEnum.Gestion) != 0;

            Attach();
        }

        private bool GetUndoEnabled(ToolbarStatusEnum status)
        {
            TipoPermisoEnum acceso = userLogged.GetPermiso(Name).TipoPermiso;
            return status != ToolbarStatusEnum.Default && (acceso & TipoPermisoEnum.Gestion) != 0;
        }

        private bool GetSalirEnabled(ToolbarStatusEnum status)
        {
            return status != ToolbarStatusEnum.Edit;
        }

        private void Attach()
        {
            tsbBuscar.CheckedChanged += tsbBuscar_CheckedChanged;
        }

        private void Detach()
        {
            tsbBuscar.CheckedChanged -= tsbBuscar_CheckedChanged;
        }

        protected internal virtual void LoadView()
        {

        }
    }
}