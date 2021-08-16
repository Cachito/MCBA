using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using Mcba.Seguridad;
using System.Windows.Forms;
using Mcba.Infraestruture.Settings;
using Mcba.UI.Properties;
using Newtonsoft.Json;

namespace Mcba.UI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, System.EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tsProgress.Value = e.ProgressPercentage;
            tsLabel.Text = e.ProgressPercentage.ToString();
        }

        private void bgWorker_DoWork(object sender,  DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            if (worker == null)
            {
                Environment.Exit(1);
            }

            for (var i = 1; i <= 100; i++)
            {
                Thread.Sleep(100);

                worker.ReportProgress(i);
            }

            var settings = SaveSettings();

            // check integridad

            e.Result = settings;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = (bool)e.Result ? DialogResult.OK : DialogResult.Cancel;
            Close();
        }

        private bool SaveSettings()
        {
            var fileName = HashHelper.Base64Decode(Settings.Default.Data);
            var encodedData = File.ReadAllText(Path.Combine(Application.StartupPath, fileName));

            var jsonData = HashHelper.Base64Decode(encodedData);

            var mcbaSettings = JsonConvert.DeserializeObject<InstanceSettings>(jsonData);

            McbaSettings.MapSettings(mcbaSettings);

            return true;
        }
    }
}
