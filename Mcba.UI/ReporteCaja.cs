﻿using System;
using System.Windows.Forms;

namespace Mcba.UI
{
    public partial class ReporteCaja : Form
    {
        public ReporteCaja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReportDataSource rds1 = new ReportDataSource("Personas", Agregar);
            reportViewer.LocalReport.DataSources.Clear();
            //reportViewer.LocalReport.DataSources.Add(rds1);
            reportViewer.RefreshReport();
            //reportViewer.Show();
        }

        private void ReporteCaja_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}