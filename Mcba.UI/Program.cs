using System;
using System.Windows.Forms;

namespace Mcba.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult dr;

            using (var splash = new Splash())
            {
                dr = splash.DialogResult;
            }

            if (dr == DialogResult.OK)
            {
                Application.Run(new Menu());
            }
        }
    }
}
