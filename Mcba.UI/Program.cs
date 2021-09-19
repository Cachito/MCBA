using System;
using System.Windows.Forms;
using Mcba.Seguridad;

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

            UserLogged userLoggedIn = null;

            using (var login = new Login())
            {
                login.ShowDialog();
                dr = login.DialogResult;
                if (dr == DialogResult.OK)
                {
                    userLoggedIn = login.UserLoggedIn;
                }
            }

            if (dr != DialogResult.OK)
            {
                Environment.Exit(2);
            }

            if (dr == DialogResult.OK)
            {
                Application.Run(new Menu(userLoggedIn));
            }
        }
    }
}
