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

            // 1. Exibe a tela de Splash
            FrmSplashScreen splashScreen = new FrmSplashScreen();
            splashScreen.Show();

            // Simula um carregamento por 3 segundos
            for (int i = 0; i <= 100; i++)
            {
                splashScreen.UpdateProgress(i);
                Thread.Sleep(30); // Pausa para simular o carregamento
            }
            splashScreen.Close();
            splashScreen.Dispose();

            // 2. Exibe a tela de Login
            using (FrmLogin loginForm = new FrmLogin())
            {
                // Se o login for bem-sucedido (DialogResult.OK)
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // 3. Inicia o formulário principal MDI
                    Application.Run(new MDI_Menu());
                }
                else
                {
                    // Se o login falhar ou for cancelado, a aplicação termina
                    Application.Exit();
                }
            }
        }
    }
}