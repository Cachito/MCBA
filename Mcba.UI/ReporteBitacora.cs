using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mcba.Bll.Helpers;
using Mcba.Entidad.Dto;
using Microsoft.Reporting.WinForms;

namespace Mcba.UI
{
    public partial class ReporteBitacora : Form
    {
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        public IEnumerable<BitacoraDto> Data { set; get; }

        public ReporteBitacora()
        {
            InitializeComponent();
        }

        private void ReporteBitacora_Load(object sender, EventArgs e)
        {
            SetCaptions();

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            ReportDataSource data = new ReportDataSource("Dataset", Data);

            reportViewer.LocalReport.DataSources.Add(data);

            reportViewer.RefreshReport();
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }
    }
}
