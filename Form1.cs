using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoAgendaDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inicializa o banco local na abertura do formulário
            DatabaseManager.InitializeLocalDatabase();
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

                // Verifica conexão antes de salvar
                if (!TestarConexao())
                {
                    MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados.", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.tableAdapterManager.UpdateAll(this.dataSetPessoa);
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void Form1_Load(object sender, EventArgs e)
                    {
                        if (!DatabaseManager.LocalDbExists())
                        {
                            DatabaseManager.InitializeLocalDatabase();
                        }
                        CarregarDados();
                    }
        
        

        private void CarregarDados()
        {
            try
            {
                // Tenta carregar os dados do banco principal com fallback para local
                using (var connection = DatabaseManager.GetConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Não foi possível conectar a nenhum banco de dados.", "Erro",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Atualiza a connection string do TableAdapter dinamicamente
                    this.dSPessoaTableAdapter.Connection = connection;

                    // Carrega os dados
                    this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);

                    // Verifica se está usando o banco local
                    if (connection.ConnectionString.Contains("(localdb)"))
                    {
                        toolStripStatusLabel1.Text = "Modo offline: usando banco local";
                        toolStripStatusLabel1.ForeColor = Color.Orange;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Conectado ao banco principal";
                        toolStripStatusLabel1.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TestarConexao()
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    return connection != null && connection.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dSPessoaBindingSource.Current == null)
                {
                    MessageBox.Show("Não há registro selecionado para excluir.", "Aviso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmResult = MessageBox.Show("Deseja realmente excluir o registro?", "Atenção",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    dSPessoaBindingSource.RemoveCurrent();

                    // Verifica conexão antes de atualizar
                    if (!TestarConexao())
                    {
                        MessageBox.Show("Não foi possível estabelecer conexão para excluir o registro.", "Erro",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    this.tableAdapterManager.UpdateAll(this.dataSetPessoa);
                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
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

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se está no modo local
                if (!toolStripStatusLabel1.Text.Contains("offline"))
                {
                    MessageBox.Show("Você já está conectado ao banco principal.", "Informação",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tenta reconectar ao banco principal
                using (var connection = DatabaseManager.GetConnection())
                {
                    if (connection != null && !connection.ConnectionString.Contains("(localdb)"))
                    {
                        // Sincroniza os dados locais com o servidor
                        SincronizarDados();
                        CarregarDados(); // Recarrega os dados do servidor
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao sincronizar: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SincronizarDados()
        {
            // Implementação da sincronização dos dados locais com o servidor
            // (Pode ser adaptada conforme a necessidade específica)
            try
            {
                // 1. Obter todos os dados locais
                var dadosLocais = this.dataSetPessoa.DSPessoa.ToList();

                // 2. Conectar ao banco principal
                using (var connection = DatabaseManager.GetConnection())
                {
                    if (connection == null || connection.ConnectionString.Contains("(localdb)"))
                    {
                        throw new Exception("Não foi possível conectar ao banco principal para sincronização.");
                    }

                    // 3. Enviar cada registro local para o servidor
                    foreach (var registro in dadosLocais)
                    {
                        // Implemente a lógica de inserção/atualização no servidor
                        // Exemplo simplificado:
                        using (var cmd = new SqlCommand(
                            "IF NOT EXISTS (SELECT 1 FROM DSPessoa WHERE ID = @ID) " +
                            "INSERT INTO DSPessoa (Name, Endereco, Cidade, Email, DataNasc, Telefone) " +
                            "VALUES (@Name, @Endereco, @Cidade, @Email, @DataNasc, @Telefone) " +
                            "ELSE " +
                            "UPDATE DSPessoa SET Name = @Name, Endereco = @Endereco, " +
                            "Cidade = @Cidade, Email = @Email, DataNasc = @DataNasc, " +
                            "Telefone = @Telefone WHERE ID = @ID", connection))
                        {
                            // Adicione os parâmetros
                            cmd.Parameters.AddWithValue("@ID", registro.ID);
                            // ... outros parâmetros
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Sincronização concluída com sucesso!", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante a sincronização: " + ex.Message);
            }
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}