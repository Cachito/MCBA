using System;
using System.ComponentModel;
using System.IO;
using Mcba.Seguridad;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Enums;
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

            var settings = SetSettings();

            CaptionHelper.SetCaption(tsLabel, Name, "CheckIntegridad");

            // check integridad
            var integrityOk = IntegrityHelper.CheckIntegrity();

            e.Result = settings && integrityOk;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = (bool)e.Result ? DialogResult.OK : DialogResult.Cancel;
            Close();
        }

        private bool SetSettings()
        {
            var fileName = HashCalculator.Base64Decode(Settings.Default.Data);
            var encodedData = File.ReadAllText(Path.Combine(Application.StartupPath, fileName));

            var jsonData = HashCalculator.Base64Decode(encodedData);

            var mcbaSettings = JsonConvert.DeserializeObject<InstanceSettings>(jsonData);

            McbaSettings.MapSettings(mcbaSettings);
            McbaSettings.Language = (LanguageEnum)Settings.Default.Language;

            return true;
        }
    }
}
