using System;
using System.Windows.Forms;

namespace Mcba.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiVehiculos_Click(object sender, EventArgs e)
        {
            StockBuscar frm = new StockBuscar
            {
                MdiParent = this
            };

            frm.Show();
        }

        private void tsmiChoferes_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos
            {
                MdiParent = this
            };

            frm.Show();
        }
    }
}