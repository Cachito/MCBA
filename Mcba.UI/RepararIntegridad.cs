using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mcba.Bll;
using Mcba.Bll.Helpers;
using Mcba.Entidad;
using Mcba.Infraestruture.Settings;
using Mcba.Seguridad;

namespace Mcba.UI
{
    public partial class RepararIntegridad : Form
    {
        private readonly UserLogged userLogged = UserLogged.GetInstance();
        private Dictionary<string, string> captions = new Dictionary<string, string>();

        public RepararIntegridad()
        {
            InitializeComponent();
        }

        private void RepararIntegridad_Load(object sender, System.EventArgs e)
        {
            captions = CaptionHelper.GetCaptions(Name);

            CaptionHelper.SetCaptions(captions, this);
        }

        private void tsbSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Reparar(out var final);

            if (!string.IsNullOrWhiteSpace(final))
            {
                var permiso = userLogged.GetPermiso($"tsmi{Name}");

                var bitacora = new Bitacora
                {
                    Login = userLogged.CryptLogin,
                    Descripcion = "Reparar Integridad",
                    FechaHora = DateTime.Now,
                    Patente = HashCalculator.Encrypt($"{permiso.Nombre} - {permiso.TipoPermiso.ToString()}",
                        McbaSettings.Key, McbaSettings.Salt),
                    Criticidad = permiso.Criticidad
                };

                BitacoraBll bitacoraBll = new BitacoraBll();
                bitacoraBll.Registrar(bitacora);

                MessageBox.Show(final, McbaSettings.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Close();
        }

        private bool Reparar(out string final)
        {
            final = string.Empty;
            
            if (!Confirma())
            {
                return false;
            }

            try
            {
                var ok = IntegrityHelper.RepareIntegrity(McbaSettings.CnnString);
                captions.TryGetValue(ok ? "Exito" : "Error", out final);
            }
            catch(Exception ex)
            {
                captions.TryGetValue("Excepcion", out var error);
                final = string.Format(error ?? McbaSettings.SinTraduccion, ex.Message);

                return false;
            }

            return true;
        }

        private bool Confirma()
        {
            captions.TryGetValue("Warning", out var warning);
            var dr = MessageBox.Show(string.Format(warning ?? McbaSettings.SinTraduccion, Environment.NewLine),
                McbaSettings.MessageTitle, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            return dr == DialogResult.Yes;
        }

        private void RepararIntegridad_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this,
                "C:/Cacho/Proyectos/MCBA/Manual/Mnual-Mcba.chm",
                "RepararIntegridad.htm");
        }
    }
}
