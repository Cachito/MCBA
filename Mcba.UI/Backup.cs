using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad.Enums;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Backup : Form
    {
        private readonly UserLogged userLogged = UserLogged.GetInstance();
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        public Backup()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbProcesar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            TipoPermisoEnum acceso = userLogged.GetPermiso($"tsmi{Name}")?.TipoPermiso ?? TipoPermisoEnum.SinAcceso;
            tsbProcesar.Enabled = (acceso & TipoPermisoEnum.Gestion) != 0;

            SetCaptions();
            SetPermissions();
        }

        private void btnSelectRuta_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void SelectFolder()
        {
            txtCarpetaDestino.Text = string.Empty;

            using (var fbg = new FolderBrowserDialog())
            {
                captions.TryGetValue("SelectFolder", out var caption);
                fbg.Description = caption;
                fbg.ShowNewFolderButton = true;
                fbg.RootFolder = Environment.SpecialFolder.MyComputer;

                DialogResult dr = fbg.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    txtCarpetaDestino.Text = fbg.SelectedPath;
                }
            }
        }

        private void Procesar()
        {
            if (!Valida())
            {
                return;
            }

            GenerarBackup();
        }

        private void GenerarBackup()
        {
            var filename = $"MCBA-Backup-{DateTime.Now:yyyyMMddHHmmss.fff}";
            var backupFilename = $"{filename}.bak";
            var backupFilePath = Path.Combine(txtCarpetaDestino.Text, backupFilename);

            var backupBll = new BackupBll();

            try
            {
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                captions.TryGetValue("GenerandoBackup", out var caption);
                lblVolumen.Text = caption ?? McbaSettings.SinTraduccion;

                backupBll.Backup(backupFilePath);

                if (!File.Exists(backupFilePath))
                {
                    captions.TryGetValue("ErrorBackupFile", out caption);
                    this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, backupFilePath, Environment.NewLine), McbaSettings.MessageTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Cursor = Cursors.Default;
                    Application.DoEvents();

                    return;
                }

                var zipExePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, McbaSettings.Path7Zip);
                if (!File.Exists(zipExePath))
                {
                    captions.TryGetValue("ErrorBackupFile", out caption);
                    this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, McbaSettings.Path7Zip, Environment.NewLine), McbaSettings.MessageTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Cursor = Cursors.Default;
                    Application.DoEvents();

                    return;
                }
                
                captions.TryGetValue("GenerandoVolumenes", out caption);
                lblVolumen.Text = string.Format(caption ?? McbaSettings.SinTraduccion, McbaSettings.VolumenesBackup);

                var zipFileName = $"{filename}.zip";
                var zipFilePath = Path.Combine(txtCarpetaDestino.Text, zipFileName);
                var totalBytes = new FileInfo(backupFilePath).Length;
                var volumeKBytes = totalBytes / McbaSettings.VolumenesBackup / 1024;
                var volumeCmd = string.Format(McbaSettings.Command7Zip, zipExePath, zipFilePath,
                    backupFilePath, volumeKBytes);

                Process process = new Process();
                process.StartInfo.WorkingDirectory = txtCarpetaDestino.Text;
                process.StartInfo.FileName = zipFilePath;
                process.StartInfo.Arguments = ex2;
                process.StartInfo.Password = new System.Security.SecureString();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;


                System.Diagnostics.Process.Start(volumeCmd);

                Cursor = Cursors.Default;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                Application.DoEvents();

                this.ShowMessage(ex.Message, McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPermissions()
        {
            var acceso = userLogged.GetPermiso($"tsmi{Name}").TipoPermiso;
            tsbProcesar.Enabled = (acceso & TipoPermisoEnum.Gestion) != 0;
        }

        private void SetCaptions()
        {
            captions = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(captions, this);
        }

        private void Clean()
        {
            txtCarpetaDestino.Text = string.Empty;
            captions.TryGetValue("lblVolumen", out var caption);
            lblVolumen.Text = caption ?? McbaSettings.SinTraduccion;
        }

        private bool Valida()
        {
            if (string.IsNullOrWhiteSpace(txtCarpetaDestino.Text))
            {
                captions.TryGetValue("FaltaCarpeta", out var caption);
                this.ShowMessage(caption, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            if (!Directory.Exists(txtCarpetaDestino.Text))
            {
                captions.TryGetValue("CarpetaNoExiste", out var caption);
                this.ShowMessage(caption, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}