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
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
            // Garante que o formulário será um contêiner MDI
            this.IsMdiContainer = true;
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre o formulário de cadastro de pessoas como filho do MDI
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Abre o formulário de consulta de pessoas como filho do MDI
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre o formulário de relatórios como filho do MDI
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair do sistema?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close(); // Fecha o formulário MDI e encerra a aplicação
            }
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {
            // Maximiza a janela principal para melhor visualização
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
