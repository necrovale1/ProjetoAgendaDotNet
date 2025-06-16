using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ProjetoAgendaDotNet
{
    public partial class FrmSplashScreen : Form
    {
        private ProgressBar progressBar1;
        private PictureBox pictureBoxGif;
        private SoundPlayer player;
        private Timer gifTimer;

        public FrmSplashScreen()
        {
            InitializeComponent();
            this.Load += FrmSplashScreen_Load;
            this.FormClosed += FrmSplashScreen_FormClosed;
        }

        private void InitializeComponent()
        {
            this.progressBar1 = new ProgressBar();
            this.pictureBoxGif = new PictureBox();

            // progressBar1
            this.progressBar1.Location = new Point(10, 200);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new Size(260, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;

            // pictureBoxGif
            this.pictureBoxGif.Location = new Point(10, 10);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new Size(260, 180);
            this.pictureBoxGif.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif.TabIndex = 1;
            this.pictureBoxGif.TabStop = false;
            this.pictureBoxGif.WaitOnLoad = true;

            // Carregar o GIF do recurso (certifique-se de que loading.gif está em Resources)
            this.pictureBoxGif.Image = Properties.Resources.loading; // nome do recurso "loading"

            // FrmSplashScreen
            this.ClientSize = new Size(284, 240);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBoxGif);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "FrmSplashScreen";
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                // Reproduz o som em loop (certifique-se que chinarap está no Resources)
                player = new SoundPlayer(Properties.Resources.chinarap);
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar música: " + ex.Message);
            }

            // Timer para animar o GIF
            gifTimer = new Timer();
            gifTimer.Interval = 100; // 100 ms
            gifTimer.Tick += GifTimer_Tick;
            gifTimer.Start();
        }

        private void GifTimer_Tick(object sender, EventArgs e)
        {
            if (ImageAnimator.CanAnimate(pictureBoxGif.Image))
            {
                ImageAnimator.Animate(pictureBoxGif.Image, (s, a) => pictureBoxGif.Invalidate());
            }
        }

        private void FrmSplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Para a música ao fechar
            player?.Stop();
            gifTimer?.Stop();
        }
    }
}
