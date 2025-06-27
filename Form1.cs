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

            this.dataSetPessoa = dsPessoas;
            this.dSPessoasTableAdapter = ta; // Garanta que o nome da variável de membro seja o plural
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