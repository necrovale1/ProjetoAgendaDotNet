using System;
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

            // Inicia diretamente o menu principal. 
            // A inicialização do banco não é mais necessária aqui.
            Application.Run(new MDI_Menu());
        }
    }
}