using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgendaDotNet.Dados; // Essencial para reconhecer o DataSetPessoa

namespace ProjetoAgendaDotNet
{
    public partial class MDI_Menu : Form
    {
        // Declaração dos componentes de dados para serem usados por todo o MDI
        private DataSetPessoa dataSetPessoa;
        private Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter dSPessoaTableAdapter;

        public MDI_Menu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            // Inicializa os componentes de dados
            this.dataSetPessoa = new DataSetPessoa();
            this.dSPessoasTableAdapter = new Dados.DataSetPessoaTableAdapters.DSPessoasTableAdapter(); // Nome corrigido
        }


        private void MDI_Menu_Load(object sender, EventArgs e)
        {
            // Maximiza a janela principal
            this.WindowState = FormWindowState.Maximized;

            // Carrega os dados do banco de dados de forma segura
            try
            {
                this.dSPessoasTableAdapter.Fill(this.dataSetPessoa.DSPessoas); // Nome da tabela corrigido para DSPessoas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha crítica ao conectar com o banco de dados. Verifique o App.config e a conexão.\n\nErro: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // Fecha o programa se não conseguir carregar os dados
            }
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this.dataSetPessoa, this.dSPessoasTableAdapter); // Passando o objeto com nome correto
            form1.MdiParent = this;
            form1.Show();
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Abre o formulário de consulta (Form2)
            Form2 form2 = new Form2(this.dataSetPessoa);
            form2.MdiParent = this; // Define que ele abrirá DENTRO do menu
            form2.Show();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre o formulário de relatórios (Form3)
            Form3 form3 = new Form3(this.dataSetPessoa, this.dSPessoasTableAdapter);
            form3.MdiParent = this; // Define que ele abrirá DENTRO do menu
            form3.Show();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair do sistema?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Encerra a aplicação
            }
        }
    }
}