using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcba.UI.Controls
{
    public partial class McbaToolbar : UserControl
    {
        public McbaToolbar()
        {
            InitializeComponent();
        }

        protected internal virtual void tsbSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        protected internal virtual void Salir()
        {
            MessageBox.Show("Salir");
        }
    }
}
