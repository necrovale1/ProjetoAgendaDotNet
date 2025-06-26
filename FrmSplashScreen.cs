using System;
using System.Media;
using System.Windows.Forms;

namespace ProjetoAgendaDotNet
{
    public partial class FrmSplashScreen : Form
    {
        private SoundPlayer player;

        public FrmSplashScreen()
        {
            // Este método é definido no arquivo FrmSplashScreen.Designer.cs
            InitializeComponent();

            // Atribui os eventos aos métodos que irão lidar com eles
            this.Load += FrmSplashScreen_Load;
            this.FormClosed += FrmSplashScreen_FormClosed;
        }

        // Método público que permite ao Program.cs controlar a barra de progresso
        public void UpdateProgress(int progress)
        {
            if (progress >= progressBar1.Minimum && progress <= progressBar1.Maximum)
            {
                progressBar1.Value = progress;
            }
        }

        // Lógica para quando o formulário carrega
        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                player = new SoundPlayer(Properties.Resources.chinarap);
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar música: " + ex.Message);
            }
        }

        // Lógica para quando o formulário fecha
        private void FrmSplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            player?.Stop();
            player?.Dispose();
        }
    }
}