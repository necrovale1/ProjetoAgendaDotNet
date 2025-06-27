using System;
using System.Windows.Forms;
using ProjetoAgendaDotNet.Dados;

namespace ProjetoAgendaDotNet
{
    public partial class Form2 : Form
    {
        // Construtor padrão
        public Form2()
        {
            InitializeComponent();
        }

        // Construtor que recebe os dados do MDI_Menu
        public Form2(DataSetPessoa dsPessoa)
        {
            InitializeComponent();

            // Faz o formulário usar o DataSet que veio do MDI_Menu
            this.dataSetPessoa = dsPessoa;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Vincula os dados já carregados à grade de visualização
            if (this.dataSetPessoa != null)
            {
                this.dSPessoaBindingSource.DataSource = this.dataSetPessoa.DSPessoas;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Aplica um filtro baseado no que foi digitado no campo de nome
            this.dSPessoaBindingSource.Filter = $"Nome LIKE '%{txtNome.Text}%'";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa o filtro e o campo de texto
            this.dSPessoaBindingSource.Filter = null;
            this.txtNome.Clear();
        }
    }
}