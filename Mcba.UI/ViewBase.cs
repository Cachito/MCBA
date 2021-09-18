﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mcba.Infraestruture.Enums;

namespace Mcba.UI
{
    public partial class ViewBase : Form
    {
        private bool SalirEnabled
        {
            set => tsbSalir.Enabled = value;
        }

        private bool CleanEnabled
        {
            set => tsbClean.Enabled = value;
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
            Find();
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

        private void tsbClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        protected internal virtual void Salir()
        {
            SetToolbarStatus(ToolbarStatusEnum.None);
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
            SetToolbarStatus(ToolbarStatusEnum.Save);
        }

        protected internal virtual void Print()
        {
            SetToolbarStatus(ToolbarStatusEnum.Print);
        }

        protected internal virtual void Find()
        {
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

        protected internal virtual void Clean()
        {
            SetToolbarStatus(ToolbarStatusEnum.Default);
        }

        protected internal void SetCaptions(Dictionary<string, string> captions)
        {

        }

        protected void SetToolbarStatus(ToolbarStatusEnum status)
        {
            switch (status)
            {
                case ToolbarStatusEnum.New:
                    SetToolbarNew();
                    break;

                case ToolbarStatusEnum.Default:
                    SetToolbarDefault();
                    break;

                case ToolbarStatusEnum.None:
                    SetToolbarNone();
                    break;

                case ToolbarStatusEnum.All:
                    SetToolbarAll();
                    break;

                default:
                    break;
            }
        }

        private void SetToolbarDefault()
        {
            SalirEnabled = true;
            CleanEnabled = false;
            NewEnabled = true;
            DeleteEnabled = true;
            EditEnabled = true;
            SaveEnabled = false;
            BuscarEnabled = true;
            PreviousEnabled = true;
            NextEnabled = true;
            PrintEnabled = true;
            RestorePassEnabled = true;
        }

        private void SetToolbarNone()
        {
            SalirEnabled = false;
            CleanEnabled = false;
            NewEnabled = false;
            DeleteEnabled = false;
            EditEnabled = false;
            SaveEnabled = false;
            BuscarEnabled = false;
            PreviousEnabled = false;
            NextEnabled = false;
            PrintEnabled = false;
            RestorePassEnabled = false;
        }

        private void SetToolbarAll()
        {
            SalirEnabled = true;
            CleanEnabled = true;
            NewEnabled = true;
            DeleteEnabled = true;
            EditEnabled = true;
            SaveEnabled = true;
            BuscarEnabled = true;
            PreviousEnabled = true;
            NextEnabled = true;
            PrintEnabled = true;
            RestorePassEnabled = true;
        }

        private void SetToolbarNew()
        {
            SalirEnabled = false;
            CleanEnabled = true;
            NewEnabled = false;
            DeleteEnabled = false;
            EditEnabled = false;
            SaveEnabled = true;
            BuscarEnabled = false;
            PreviousEnabled = false;
            NextEnabled = false;
            PrintEnabled = false;
            RestorePassEnabled = false;
        }

        protected internal virtual void LoadView()
        {


        }
    }
}