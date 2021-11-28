using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad;
using Mcba.Entidad.Enums;
using Mcba.Infraestruture;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

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

        private void tsbRestore_Click(object sender, EventArgs e)
        {
            Restaurar();
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
            LoadGrid();
        }

        private void LoadGrid()
        {
            if (string.IsNullOrWhiteSpace(txtCarpetaDestino.Text))
            {
                return;
            }

            if (!Directory.Exists(txtCarpetaDestino.Text))
            {
                captions.TryGetValue("FaltaCarpeta", out var caption);
                this.ShowMessage(caption, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }


            var filePaths = Directory.GetFiles(txtCarpetaDestino.Text, "*.zip.??1")
                .ToList();


            filePaths.Sort(delegate(string x, string y)
            {
                if (x == null && y == null)
                {
                    return 0;
                }

                if (x == null)
                {
                    return 1;
                }

                if (y == null)
                {
                    return -1;
                }

                return y.CompareTo(x);
            });

            dgvBackup.DataSource = null;
            dgvBackup.DataSource = filePaths.Select(x => new { Value = x }).ToList();
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
            string caption;
            var permiso = userLogged.GetPermiso($"tsmi{Name}");

            Bitacora bitacora = new Bitacora
            {
                Login = userLogged.CryptLogin,
                Criticidad = permiso.Criticidad,
                FechaHora = DateTime.Now,
                Patente = HashCalculator.Encrypt($"{permiso.Nombre} - {permiso.TipoPermiso.ToString()}", McbaSettings.Key, McbaSettings.Salt)
            };

            var bitacoraBll = new BitacoraBll();
            var backupBll = new BackupBll();

            try
            {
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                captions.TryGetValue("GenerandoBackup", out caption);
                lblVolumen.Text = caption ?? McbaSettings.SinTraduccion;

                backupBll.Backup(backupFilePath);

                if (!File.Exists(backupFilePath))
                {
                    captions.TryGetValue("ErrorBackupFile", out caption);

                    bitacora.Descripcion = HashCalculator.Encrypt(
                        string.Format(caption ?? McbaSettings.SinTraduccion, backupFilename, txtCarpetaDestino.Text),
                        McbaSettings.Key, McbaSettings.Salt);
                    bitacoraBll.Registrar(bitacora);

                    this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, backupFilePath, Environment.NewLine), McbaSettings.MessageTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Cursor = Cursors.Default;
                    Application.DoEvents();

                    return;
                }

                if (!File.Exists(McbaSettings.Path7Zip))
                {
                    captions.TryGetValue("ErrorBackupFile", out caption);

                    bitacora.Descripcion = HashCalculator.Encrypt(
                        string.Format(caption ?? McbaSettings.SinTraduccion, backupFilename, txtCarpetaDestino.Text),
                        McbaSettings.Key, McbaSettings.Salt);
                    bitacoraBll.Registrar(bitacora);

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
                var arguments = string.Format(McbaSettings.Arguments7Zip, zipFilePath, backupFilePath, volumeKBytes);

                using (var process = new Process
                {
                    StartInfo =
                    {
                        WorkingDirectory = txtCarpetaDestino.Text,
                        FileName = McbaSettings.Path7Zip,
                        Arguments = arguments,
                        CreateNoWindow = false,
                        WindowStyle = ProcessWindowStyle.Normal
                    }
                })
                {
                    process.Start();
                    process.WaitForExit();
                }

                var backupFileRename = $"{filename}.orig.bak";
                var backupFileRepath = Path.Combine(txtCarpetaDestino.Text, backupFileRename);
                File.Move(backupFilePath, backupFileRepath);

                captions.TryGetValue("BackupGenerado", out caption);
                bitacora.Descripcion =
                    HashCalculator.Encrypt(
                        string.Format(caption ?? McbaSettings.SinTraduccion, backupFilename, txtCarpetaDestino.Text),
                        McbaSettings.Key, McbaSettings.Salt);
                bitacoraBll.Registrar(bitacora);

                Cursor = Cursors.Default;
                Application.DoEvents();

                this.ShowMessage(
                    string.Format(caption ?? McbaSettings.SinTraduccion, backupFilename, txtCarpetaDestino.Text),
                    McbaSettings.MessageTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                Application.DoEvents();

                try
                {
                    bitacora.Descripcion =
                        HashCalculator.Encrypt(
                            $"{ex.Message}, {backupFilename}, {txtCarpetaDestino.Text}",
                            McbaSettings.Key, McbaSettings.Salt);
                    bitacoraBll.Registrar(bitacora);
                }
                catch (Exception e)
                {
                    this.ShowMessage(e.Message, McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.ShowMessage(ex.Message, McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Clean();
        }

        private void Restaurar()
        {
            string caption;

            if (dgvBackup.SelectedRows.Count == 0)
            {
                captions.TryGetValue("FaltaSeleccion", out caption);
                this.ShowMessage(caption, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            captions.TryGetValue("RestoreWarning", out caption);
            var dr = this.ShowMessage(string.Format(caption ?? McbaSettings.SinTraduccion, Environment.NewLine), McbaSettings.MessageTitle, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            var permiso = userLogged.GetPermiso($"tsmi{Name}");
            var bitacoraBll = new BitacoraBll();
            var backupBll = new BackupBll();

            var bitacora = new Bitacora
            {
                Login = userLogged.CryptLogin,
                Criticidad = permiso.Criticidad,
                FechaHora = DateTime.Now,
                Patente = HashCalculator.Encrypt($"{permiso.Nombre} - {permiso.TipoPermiso.ToString()}", McbaSettings.Key, McbaSettings.Salt)
            };

            var backupVolumeFile = string.Empty;

            try
            {
                backupVolumeFile = (string)dgvBackup.SelectedRows[0].Cells[0].Value;
                if (!File.Exists(backupVolumeFile))
                {
                    captions.TryGetValue("ErrorBackupFile", out caption);

                    bitacora.Descripcion = HashCalculator.Encrypt(
                        string.Format(caption ?? McbaSettings.SinTraduccion, backupVolumeFile, txtCarpetaDestino.Text),
                        McbaSettings.Key, McbaSettings.Salt);
                    bitacoraBll.Registrar(bitacora);

                    Cursor = Cursors.Default;
                    Application.DoEvents();

                    this.ShowMessage(
                        string.Format(caption ?? McbaSettings.SinTraduccion, backupVolumeFile, Environment.NewLine),
                        McbaSettings.MessageTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                var folderName = Path.GetDirectoryName(backupVolumeFile);

                if (!Directory.Exists(folderName))
                {
                    captions.TryGetValue("ErrorCarpeta", out caption);

                    bitacora.Descripcion = HashCalculator.Encrypt(
                        string.Format(caption ?? McbaSettings.SinTraduccion, folderName, Environment.NewLine),
                        McbaSettings.Key, McbaSettings.Salt);
                    bitacoraBll.Registrar(bitacora);

                    Cursor = Cursors.Default;
                    Application.DoEvents();

                    this.ShowMessage(
                        string.Format(caption ?? McbaSettings.SinTraduccion, folderName, Environment.NewLine),
                        McbaSettings.MessageTitle, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }

                var backupFileWhitoutExtension = Path.GetFileNameWithoutExtension(backupVolumeFile);
                var backupVolumeFiles = Directory.GetFiles(txtCarpetaDestino.Text, $"{backupFileWhitoutExtension}.???")
                    .ToList();

                captions.TryGetValue("DescomprimiendoVolumenes", out caption);
                lblVolumen.Text = string.Format(caption ?? McbaSettings.SinTraduccion, backupVolumeFiles.Count);

                var arguments = string.Format(McbaSettings.ArgumentsExtract7Zip, backupVolumeFile);

                using (var process = new Process
                {
                    StartInfo =
                    {
                        WorkingDirectory = txtCarpetaDestino.Text,
                        FileName = McbaSettings.Path7Zip,
                        Arguments = arguments,
                        CreateNoWindow = false,
                        WindowStyle = ProcessWindowStyle.Normal
                    }
                })
                {
                    process.Start();
                    process.WaitForExit();
                }

                var backupFile = Path.Combine(txtCarpetaDestino.Text,
                    $"{Path.GetFileNameWithoutExtension(backupFileWhitoutExtension)}.bak");

                if (!File.Exists(backupFile))
                {
                    captions.TryGetValue("ErrorBackupFile", out caption);

                    bitacora.Descripcion = HashCalculator.Encrypt(
                        string.Format(caption ?? McbaSettings.SinTraduccion, backupFile, Environment.NewLine),
                        McbaSettings.Key, McbaSettings.Salt);
                    bitacoraBll.Registrar(bitacora);

                    Cursor = Cursors.Default;
                    Application.DoEvents();

                    this.ShowMessage(
                        string.Format(caption ?? McbaSettings.SinTraduccion, backupFile, Environment.NewLine),
                        McbaSettings.MessageTitle, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }

                backupBll.Restore(backupFile);

                captions.TryGetValue("RestoreCompleto", out caption);
                bitacora.Descripcion =
                    HashCalculator.Encrypt(
                        string.Format(caption ?? McbaSettings.SinTraduccion, backupFile, Environment.NewLine),
                        McbaSettings.Key, McbaSettings.Salt);
                bitacoraBll.Registrar(bitacora);

                Cursor = Cursors.Default;
                Application.DoEvents();

                this.ShowMessage(
                    string.Format(caption ?? McbaSettings.SinTraduccion, backupFile, Environment.NewLine),
                    McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                Application.Exit();

                Close();

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                Application.DoEvents();

                try
                {
                    bitacora.Descripcion =
                        HashCalculator.Encrypt(
                            $"{ex.Message}, {backupVolumeFile}, {txtCarpetaDestino.Text}",
                            McbaSettings.Key, McbaSettings.Salt);
                    bitacoraBll.Registrar(bitacora);
                }
                catch (Exception e)
                {
                    this.ShowMessage(e.Message, McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.ShowMessage(ex.Message, McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Clean();
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
            //txtCarpetaDestino.Text = string.Empty;
            captions.TryGetValue("lblVolumen", out var caption);
            lblVolumen.Text = caption ?? McbaSettings.SinTraduccion;

            LoadGrid();
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

        private void Backup_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this,
                McbaSettings.PathManual,
                "Backup.htm");
        }
    }
}