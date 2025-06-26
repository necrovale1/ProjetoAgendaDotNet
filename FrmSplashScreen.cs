using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ProjetoAgendaDotNet
{
    public partial class FrmSplashScreen : Form
    {
        private SoundPlayer player;
        private Timer closeTimer;

        public FrmSplashScreen()
        {
            InitializeComponent();

            // Initialize components
            closeTimer = new Timer();
            player = new SoundPlayer(Properties.Resources.chinarap);

            // Set form properties
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Salmon;

            // Set up progress bar
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            // Load embedded image
            pictureBox1.Image = Properties.Resources.loading;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Play sound
            player.Play();

            // Set up auto-close timer
            closeTimer.Interval = 3000;
            closeTimer.Tick += (s, e) =>
            {
                player.Stop();
                this.Close();
            };
            closeTimer.Start();
        }
    }
}