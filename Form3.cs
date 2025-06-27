using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Linq;
using ProjetoAgendaDotNet.Dados;

namespace ProjetoAgendaDotNet
{
    public partial class Form3 : Form
    {
        private DataSetPessoa dsPessoa;
        private Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter dSPessoaTableAdapter;

        public Form3()
        {
            InitializeComponent();
        }


        public Form3(DataSetPessoa dataSet, Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter tableAdapter)
        {
            InitializeComponent();
            this.dsPessoa = dataSet;
            this.dSPessoaTableAdapter = tableAdapter;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (this.dsPessoa == null) return;

            // Vincula a fonte de dados que já foi carregada
            dSPessoaBindingSource.DataSource = this.dsPessoa;
            dSPessoaBindingSource.DataMember = "DSPessoa";

            // Popula o ComboBox com as colunas que podem ser filtradas
            cmbColuna.Items.Clear();
            cmbColuna.Items.Add("Nome");
            cmbColuna.Items.Add("Endereco");
            cmbColuna.Items.Add("Cidade");
            cmbColuna.Items.Add("Email");
            cmbColuna.Items.Add("Telefone");
            cmbColuna.SelectedIndex = 0;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbColuna.SelectedItem == null || string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Por favor, selecione uma coluna e digite um valor para filtrar.", "Aviso");
                return;
            }

            string coluna = cmbColuna.SelectedItem.ToString();
            string valor = txtValor.Text;

            if (!dsPessoa.DSPessoas.Columns.Contains(coluna))
            {
                MessageBox.Show($"A coluna '{coluna}' não foi encontrada nos dados. Verifique o DataSet.", "Erro");
                return;
            }

            // Usa o Filter do BindingSource, que é a maneira correta quando os dados estão vinculados
            dSPessoaBindingSource.Filter = $"[{coluna}] LIKE '%{valor.Replace("'", "''")}%'";
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dSPessoaBindingSource.Filter = null; // Limpa o filtro
            txtValor.Clear();
        }

        private void btnGerarCSV_Click(object sender, EventArgs e)
        {
            if (dSPessoaBindingSource.Count == 0)
            {
                MessageBox.Show("Não há dados (filtrados) para exportar!", "Aviso");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo CSV (*.csv)|*.csv";
            sfd.FileName = "RelatorioFiltrado.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    var columnNames = dsPessoa.DSPessoas.Columns.Cast<DataColumn>().Select(column => $"\"{column.ColumnName}\"");
                    sb.AppendLine(string.Join(";", columnNames));

                    foreach (DataRowView drv in dSPessoaBindingSource)
                    {
                        var fields = drv.Row.ItemArray.Select(field => $"\"{field.ToString()}\"");
                        sb.AppendLine(string.Join(";", fields));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Arquivo CSV gerado com sucesso!", "Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar arquivo CSV: " + ex.Message, "Erro");
                }
            }
        }

        private void btnGerarXML_Click(object sender, EventArgs e)
        {
            if (dSPessoaBindingSource.Count == 0)
            {
                MessageBox.Show("Não há dados (filtrados) para exportar!", "Aviso");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo XML (*.xml)|*.xml";
            sfd.FileName = "RelatorioFiltrado.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dtFiltrada = (dSPessoaBindingSource.List as DataView).ToTable();

                    if (dtFiltrada != null)
                    {
                        dtFiltrada.TableName = "Pessoas";
                        DataSet dsParaExportar = new DataSet("Agenda");
                        dsParaExportar.Tables.Add(dtFiltrada);
                        dsParaExportar.WriteXml(sfd.FileName);
                        MessageBox.Show("Arquivo XML gerado com sucesso!", "Sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar arquivo XML: " + ex.Message, "Erro");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Ou o nome do seu botão
        {
            // Pega a visualização atual dos dados (que já está filtrada)
            DataView visaoFiltrada = (DataView)dSPessoaBindingSource.List;

            if (visaoFiltrada.Count == 0)
            {
                MessageBox.Show("Não há dados (filtrados) para exibir no relatório.", "Aviso");
                return;
            }

            // Cria e mostra o novo formulário, passando os dados filtrados para ele
            FormRelatorioListView formRelatorio = new FormRelatorioListView(visaoFiltrada);
            formRelatorio.MdiParent = this.MdiParent;
            formRelatorio.Show();
        }
    }
}