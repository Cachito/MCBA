using System.Windows.Forms;
using Mcba.Infraestruture.Helpers;

namespace Mcba.UI
{
    public partial class StockBuscar : Form
    {
        public StockBuscar()
        {
            InitializeComponent();
        }

        private void StockBuscar_Load(object sender, System.EventArgs e)
        {
            SetCaptions();
        }

        private void SetCaptions()
        {
            var caps = LanguageHelper.GetCaptions(Name);
            LanguageHelper.SetCaptions(caps, this);
        }
    }
}
