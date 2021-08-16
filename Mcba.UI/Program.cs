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
                splash.ShowDialog();
                dr = splash.DialogResult;
            }

            if (dr != DialogResult.OK)
            {
                Environment.Exit(1);
            }

            using (var login = new Login())
            {
                login.ShowDialog();
                dr = login.DialogResult;
            }

            if (dr != DialogResult.OK)
            {
                Environment.Exit(2);
            }

            if (dr == DialogResult.OK)
            {
                Application.Run(new Menu());
            }
        }
    }
}
