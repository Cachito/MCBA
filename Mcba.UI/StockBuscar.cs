using System.Windows.Forms;
using Mcba.Bll.Helpers;
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
            var caps = CaptionHelper.GetCaptions(Name);
            CaptionHelper.SetCaptions(caps, this);
        }
    }
}
