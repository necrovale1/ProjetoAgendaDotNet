using System;
using System.Windows.Forms;
using ProjetoAgendaDotNet.Dados;

namespace ProjetoAgendaDotNet
{
    public partial class Form1 : Form
    {
        // O Designer agora gerencia as variáveis 'dataSetPessoa' e 'dSPessoaTableAdapter'

        // Construtor padrão (usado pelo designer)
        public Form1()
        {
            InitializeComponent();
        }

        // Construtor que recebe os dados do MDI_Menu
        public Form1(DataSetPessoa dsPessoa, Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter ta)
        {
            InitializeComponent();

            // Faz o formulário usar os componentes de dados que vieram do MDI_Menu
            this.dataSetPessoa = dsPessoa;
            this.dSPessoaTableAdapter.Connection = ta.Connection; // Usa a mesma conexão
            this.tableAdapterManager.DSPessoaTableAdapter = this.dSPessoaTableAdapter;
        }

        private void dSPessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dSPessoaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetPessoa);
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar os dados. Erro: " + ex.Message, "Erro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Vincula os dados já carregados aos controles do formulário
            // O BindingSource já está configurado no designer para usar o dataSetPessoa
            this.dSPessoaBindingSource.DataSource = this.dataSetPessoa.DSPessoa;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // Verifica se existe algum registro para ser excluído
            if (dSPessoaBindingSource.Count == 0)
            {
                MessageBox.Show("Não há registros para excluir.", "Aviso");
                return;
            }

            // Cria a caixa de diálogo de confirmação
            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este registro permanentemente?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Se o usuário clicar em "Sim", o registro é removido
            if (resultado == DialogResult.Yes)
            {
                dSPessoaBindingSource.RemoveCurrent();
                MessageBox.Show("Registro excluído. Clique em 'Salvar' para confirmar a remoção no banco de dados.", "Excluído");
            }
            // Se clicar em "Não", nada acontece.
        }

    }
}