using System.ComponentModel;
using System.IO;
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

            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.RunWorkerCompleted +=  new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            //bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);
        }

        private void bgWorker_DoWork(object sender,  DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            var worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the
            // RunWorkerCompleted eventhandler.
            e.Result = SaveSettings();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
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

        private void Splash_Load(object sender, System.EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }
    }
}
