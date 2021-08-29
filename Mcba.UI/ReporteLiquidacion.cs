using System;
using System.Windows.Forms;
using Mcba.Infraestruture.Helpers;

namespace Mcba.UI
{
    public partial class ReporteLiquidacion : Form
    {
        public ReporteLiquidacion()
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

        private void ReporteLiquidacion_Load(object sender, EventArgs e)
        {
            SetCaptions();
            this.reportViewer.RefreshReport();
        }

        private void SetCaptions()
        {
            var caps = LanguageHelper.GetCaptions(Name);
            LanguageHelper.SetCaptions(caps, this);
        }
    }
}
