using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoAgendaDotNet
{
    public partial class FrmLogin : Form
    {
        private int loginAttempts = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsuario.Text;
            string password = txbSenha.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, informe o usuário e a senha.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação das credenciais
            if (username == "aluno" && password == "2025")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                loginAttempts++;
                MessageBox.Show($"Usuário ou senha inválidos. Por favor, tente novamente.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSenha.Clear();
                txbUsuario.Focus();

                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Você excedeu o número máximo de tentativas de login. O sistema será encerrado.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }
    }
}