using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
            var filename = $"MCBA-Backup-{DateTime.Now:yyyyMMddHHmmss.fff}.bak";
            var filePath = Path.Combine(txtCarpetaDestino.Text, filename);


            /*
                // set backupfilename (you will get something like: "C:/temp/MyDatabase-2013-12-07.bak")
                var backupFileName = String.Format("{0}{1}-{2}.bak", 
                    backupFolder, sqlConStrBuilder.InitialCatalog, 
                    DateTime.Now.ToString("yyyy-MM-dd"));

                using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
                {
                    var query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'", 
                        sqlConStrBuilder.InitialCatalog, backupFileName);

                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
             */
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            TipoPermisoEnum acceso = userLogged.GetPermiso($"tsmi{Name}")?.TipoPermiso ?? TipoPermisoEnum.SinAcceso;
            tsbProcesar.Enabled = (acceso & TipoPermisoEnum.Gestion) != 0;

            SetCaptions();
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
            var ret = true;

            if (string.IsNullOrWhiteSpace(txtCarpetaDestino.Text))
            {
                captions.TryGetValue("FaltaCarpeta", out var caption);
                this.ShowMessage(caption, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                ret = false;
            }

            if (!Directory.Exists(txtCarpetaDestino.Text))
            {
                captions.TryGetValue("CarpetaNoExiste", out var caption);
                this.ShowMessage(caption, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                ret = false;
            }

            return ret;
        }
    }
}