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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dSPessoaBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            // O ID será gerado automaticamente pelo banco
            // Não precisamos definir manualmente
        }

        private void dSPessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dSPessoaBindingSource.EndEdit();

                // Verifica se é uma nova linha
                if (((DataRowView)dSPessoaBindingSource.Current).IsNew)
                {
                    // Remove qualquer valor que possa ter sido inserido no ID
                    ((DataRowView)dSPessoaBindingSource.Current)["ID"] = DBNull.Value;
                }

                this.tableAdapterManager.UpdateAll(this.dataSetPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.DSPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se há um registro atual para excluir
                if (dSPessoaBindingSource.Current == null)
                {
                    MessageBox.Show("Não há registro selecionado para excluir.", "Aviso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirmação do usuário
                var confirmResult = MessageBox.Show("Deseja realmente excluir o registro?", "Atenção",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Remove o registro atual
                    dSPessoaBindingSource.RemoveCurrent();

                    // Atualiza o banco de dados
                    this.tableAdapterManager.UpdateAll(this.dataSetPessoa);

                    // Opcional: Exibe mensagem de sucesso
                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Tratamento de erros
                MessageBox.Show($"Ocorreu um erro ao excluir o registro:\n{ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuPriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Menu mDI_Menu = new MDI_Menu();
            mDI_Menu.ShowDialog();
        }
    }
}
