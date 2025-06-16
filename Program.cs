using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoAgendaDotNet
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmSplashScreen splash = new FrmSplashScreen();
            splash.Show();
            for (int i = 0; i <= 100; i++)
            {
                splash.UpdateProgress(i);
                Thread.Sleep(30); // Simula carregamento
            }
            splash.Close();

            Application.Run(new MDI_Menu());
        }
    }
}
