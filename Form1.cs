using System;
using System.Windows.Forms;
using ProjetoAgendaDotNet.Dados;

namespace ProjetoAgendaDotNet
{
    public partial class Form1 : Form
    {
        // As variáveis 'dataSetPessoa' e 'dSPessoaTableAdapter' são declaradas
        // automaticamente pelo Visual Studio no arquivo 'Form1.Designer.cs'
        // porque foram adicionadas como componentes no modo Design.
        // Por isso, não as declaramos novamente aqui.

        // Construtor padrão (necessário para o Designer)
        public Form1()
        {
            InitializeComponent();
        }

        // Construtor que recebe os dados do menu principal (MDI_Menu)
        public Form1(DataSetPessoa dsPessoas, Dados.DataSetPessoaTableAdapters.DSPessoasTableAdapter ta)
        {
            InitializeComponent();

            // Atribui o DataSet recebido do menu ao componente DataSet deste formulário.
            // 'this.dataSetPessoa' refere-se ao componente que você vê na barra inferior do designer do Form1.
            this.dataSetPessoas = dsPessoas;

            // Faz o TableAdapter deste formulário ser o mesmo do menu, garantindo que usem a mesma conexão.
            this.dSPessoasTableAdapter = ta;

            // Vincula o TableAdapter ao Manager para que o botão de Salvar funcione corretamente.
            this.tableAdapterManager.DSPessoasTableAdapter = this.dSPessoasTableAdapter;
        }

        private void dSPessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dSPessoaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetPessoa);
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar os dados. Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // No carregamento do formulário, define a fonte de dados do BindingSource.
            // O BindingSource é o componente que liga os campos de texto e outros controles
            // aos dados na memória.
            this.dSPessoasBindingSource.DataSource = this.dataSetPessoa.DSPessoas;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dSPessoasBindingSource.Count == 0)
            {
                MessageBox.Show("Não há registros para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este registro?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                dSPessoaBindingSource.RemoveCurrent();
                MessageBox.Show("Registro excluído. Clique em 'Salvar' para confirmar a remoção no banco de dados.", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}