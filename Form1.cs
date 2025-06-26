using System;
using System.Windows.Forms;

namespace ProjetoAgendaDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // O TableAdapter usa a conexão do App.config para preencher os dados da tabela 'Pessoas'.
                int registrosCarregados = this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);

                toolStripStatusLabel1.Text = "Conectado ao banco de dados local.";

                // ***** LINHA DE DIAGNÓSTICO ADICIONADA *****
                // Esta mensagem irá nos dizer exatamente quantos registros foram lidos do banco.
                MessageBox.Show($"Diagnóstico: {registrosCarregados} registros foram carregados da tabela 'Pessoas'.",
                                "Verificação de Dados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar os dados da tabela 'Pessoas'.\n\n" +
                                $"Erro: {ex.Message}",
                                "Erro de Carregamento",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dSPessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dSPessoaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetPessoa);
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados.\n\n" +
                                $"Erro: {ex.Message}",
                                "Erro de Salvamento",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // ***** MÉTODO RESTAURADO *****
        // Lógica para o botão de excluir no BindingNavigator
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dSPessoaBindingSource.Current == null)
            {
                MessageBox.Show("Não há registro selecionado para excluir.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmar Exclusão",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    dSPessoaBindingSource.RemoveCurrent();
                    // Após remover da tela, salva a alteração no banco de dados
                    dSPessoaBindingNavigatorSaveItem_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar excluir o registro.\n\n" + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Se deu erro, recarrega os dados para desfazer a exclusão na tela
                    btnRecarregar_Click(sender, e);
                }
            }
        }

        // ***** MÉTODO RESTAURADO *****
        // Lógica para o item de menu "Menu Principal"
        private void menuPriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // A forma correta de fechar um formulário filho em MDI
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataSetPessoa.DSPessoa.Clear();
                this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao recarregar os dados: " + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dSPessoaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}