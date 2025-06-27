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

            // Cria o formulário de login
            FrmLogin loginForm = new FrmLogin();

            // Mostra o formulário de login como uma caixa de diálogo.
            // O código vai pausar aqui até o loginForm ser fechado.
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Se o DialogResult for OK (login bem-sucedido),
                // então abre o menu principal.
                // A aplicação continuará rodando até o MDI_Menu ser fechado.
                Application.Run(new MDI_Menu());
            }
            // Se o DialogResult for qualquer outra coisa (Cancel, etc.),
            // o método Main() termina e a aplicação fecha, o que é o comportamento desejado.
        }
    }
}