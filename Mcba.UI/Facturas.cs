﻿using System;
using System.Text;
using System.Windows.Forms;

namespace Mcba.UI
{
    public partial class Facturas : Form
    {
        private int idChofer { set; get; }

        public Facturas()
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

        private void Facturas_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {

        }

        private void Edit()
        {
            ControlsEnabled(true);
        }

        private void New()
        {
            ControlsEnabled(true);
            Clean();
        }

        private void Clean()
        {
            idChofer = 0;
            txtRazónSocial.Text = string.Empty;
        }

        private void ControlsEnabled(bool enable)
        {
            txtRazónSocial.Enabled = enable;
        }

        private void Save()
        {
            if (!Valida())
            {
                return;
            }

            int.TryParse(txtRazónSocial.Text, out var dni);

            LoadGrid();
        }

        private bool Valida()
        {
            var ret = true;
            var mess = new StringBuilder();

            if (txtRazónSocial.Text == string.Empty)
            {
                mess.Append("Debe ingreasr DNI.");
                ret = false;
            }

            if (!int.TryParse(txtRazónSocial.Text, out var _))
            {
                mess.Append("Valor para DNI no válido.");
                ret = false;
            }

            return ret;
        }
    }
}