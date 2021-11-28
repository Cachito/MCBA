using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Enums;
using Mcba.Infraestruture.Helpers;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;
using Mcba.UI.Properties;
using Newtonsoft.Json;

namespace Mcba.UI
{
    public partial class CambioCns : Form
    {
        private readonly UserLogged userLogged = UserLogged.GetInstance();
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        public CambioCns()
        {
            InitializeComponent();
        }

        private void CambioCns_Load(object sender, System.EventArgs e)
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);

            txtServer.Text = BaseDataHelper.GetServerName();
            txtBase.Text = BaseDataHelper.GetDataBaseName();
        }

        private void tsbSalir_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tsbOk_Click(object sender, System.EventArgs e)
        {
            if (!Valida())
            {
                return;
            }

            captions.TryGetValue("CambioCnsWarning", out var warning);
            var dr = MessageBox.Show(string.Format(warning ?? McbaSettings.SinTraduccion, Environment.NewLine),
                McbaSettings.MessageTitle, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr != DialogResult.Yes)
            {
                return;
            }

            try
            {
                SetSettings();
                ShowSettings();
                Close();
            }
            catch (Exception ex)
            {
                captions.TryGetValue("Error", out var error);
                MessageBox.Show(string.Format(error ?? McbaSettings.SinTraduccion, ex.Message), McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowSettings()
        {
            var labelText = BaseDataHelper.GetString();

            captions.TryGetValue("MenuLblBase", out var showText);

            showText = string.Format(showText ?? McbaSettings.SinTraduccion, labelText);

            foreach (Control c  in MdiParent.Controls)
            {
                if (!(c is StatusStrip ss) )
                {
                    continue;
                }

                foreach (ToolStripItem stripItem in ss.Items)
                {
                    if (stripItem.Tag != null && stripItem.Tag.ToString() == "lblBase")
                    {
                        stripItem.Text = showText;
                    }
                }
            }
        }

        private void SetSettings()
        {
            var fileName = HashCalculator.Base64Decode(Settings.Default.Data);
            var filePath = Path.Combine(Application.StartupPath, fileName);
            var encodedData = File.ReadAllText(filePath);

            var jsonData = HashCalculator.Base64Decode(encodedData);

            var newServer = txtServer.Text.Trim();
            var newBase = txtBase.Text.Trim();

            var mcbaSettings = JsonConvert.DeserializeObject<InstanceSettings>(jsonData);
            mcbaSettings.CnnString = string.Format(mcbaSettings.CnnStringTemplate, newBase, newServer);
            mcbaSettings.Language = McbaSettings.Language;

            McbaSettings.MapSettings(mcbaSettings);

            var jsonSettings = JsonConvert.SerializeObject(mcbaSettings);
            var hashSettings = HashCalculator.Base64Encode(jsonSettings);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (Stream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(hashSettings);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
        }

        private bool Valida()
        {
            var newServer = txtServer.Text;
            var newBase = txtBase.Text;
            var newString = string.Format(McbaSettings.CnnStringTemplate, newBase, newServer);

            if (newString.ToLower().Equals(McbaSettings.CnnString.ToLower()))
            {
                captions.TryGetValue("SinCambios", out var textoVacio);
                MessageBox.Show(textoVacio, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return false;
            }

            if (string.IsNullOrWhiteSpace(newServer) || string.IsNullOrWhiteSpace(newBase))
            {
                captions.TryGetValue("TextoVacio", out var textoVacio);
                MessageBox.Show(textoVacio, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return false;
            }

            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            var ok = new TestConexionBll().TestConexion(newString);

            Cursor = Cursors.Default;
            Application.DoEvents();

            if (!ok)
            {
                captions.TryGetValue("StringNoValida", out var textoVacio);
                MessageBox.Show(textoVacio, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        private void CambioCns_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this,
                McbaSettings.PathManual,
                "CambioCadena.htm");
        }
    }
}
