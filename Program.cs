using ProjetoAgendaDotNet;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoAgendaDotNet
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

            // Show splash screen
            using (var splash = new FrmSplashScreen())
            {
                splash.ShowDialog();
            }

            // Run main application
            Application.Run(new FrmLogin()); // Replace FrmMain with your main form class
        }
    }
}