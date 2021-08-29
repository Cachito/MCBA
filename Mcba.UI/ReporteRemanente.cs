using System;
using System.Windows.Forms;
using Mcba.Infraestruture.Helpers;

namespace Mcba.UI
{
    public partial class ReporteRemanente : Form
    {
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
            var caps = LanguageHelper.GetCaptions(Name);
            LanguageHelper.SetCaptions(caps, this);
        }
    }
}
