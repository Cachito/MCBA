using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mcba.Bll.Helpers;

namespace Mcba.UI
{
    public partial class ReporteRemanente : Form
    {
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        public ReporteRemanente()
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

        private void ReporteRemanente_Load(object sender, EventArgs e)
        {
            SetCaptions();
            reportViewer.RefreshReport();
        }

        private void SetCaptions()
        {
            var captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }
    }
}
