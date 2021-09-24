using System.Collections.Generic;
using System.Windows.Forms;
using Mcba.Bll.Helpers;
using Mcba.Infraestruture.Settings;

namespace Mcba.UI
{
    public partial class Busqueda : Form
    {
        public string Titulo { set; get; }
        public string TextoBuscado { set; get; }

        private Dictionary<string, string> captions = new Dictionary<string, string>();

        public Busqueda()
        {
            InitializeComponent();
        }

        private void Busqueda_Load(object sender, System.EventArgs e)
        {
            captions = CaptionHelper.GetCaptions(Name);

            captions.TryGetValue(Name, out var formText);
            Text = string.Format(formText ?? McbaSettings.SinTraduccion, Titulo);

            captions.TryGetValue(lblBusqueda.Name, out var labelText);
            lblBusqueda.Text = string.Format(labelText ?? McbaSettings.SinTraduccion, Titulo);

            CaptionHelper.SetCaptions(captions, this);
        }

        private void tsbSalir_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tsbOk_Click(object sender, System.EventArgs e)
        {
            TextoBuscado = txtBusqueda.Text;

            if (string.IsNullOrWhiteSpace(TextoBuscado))
            {
                captions.TryGetValue("TextoVacio", out var textoVacio);
                MessageBox.Show(textoVacio, McbaSettings.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
