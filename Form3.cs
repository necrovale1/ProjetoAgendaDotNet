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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Carrega todos os dados inicialmente para popular o ComboBox de cidades
            this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);
            PopulateCityComboBox();
            // Limpa o DataGridView para não exibir dados ao abrir
            dSPessoaDataGridView.DataSource = null;
        }

        private void PopulateCityComboBox()
        {
            // Pega as cidades distintas do DataSet e as adiciona ao ComboBox
            var cities = this.dataSetPessoa.DSPessoa
                             .Select(row => row.Field<string>("Cidade"))
                             .Distinct()
                             .OrderBy(city => city);

            cmbCidade.Items.Clear();
            foreach (var city in cities)
            {
                cmbCidade.Items.Add(city);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            try
            {
                // Conecta o BindingSource ao DataSet completo e exibe no DataGridView
                this.dSPessoaBindingSource.DataSource = this.dataSetPessoa.DSPessoa;
                this.dSPessoaDataGridView.DataSource = this.dSPessoaBindingSource;
                lblStatus.Text = $"{this.dSPessoaBindingSource.Count} registros encontrados.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrarCidade_Click(object sender, EventArgs e)
        {
            if (cmbCidade.SelectedItem == null || string.IsNullOrEmpty(cmbCidade.Text))
            {
                MessageBox.Show("Por favor, selecione uma cidade para filtrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cidadeFiltrada = cmbCidade.Text;

            try
            {
                // Filtra os dados com base na cidade selecionada usando LINQ to DataSet
                var query = from pessoa in this.dataSetPessoa.DSPessoa
                            where pessoa.Field<string>("Cidade").Equals(cidadeFiltrada, StringComparison.OrdinalIgnoreCase)
                            select pessoa;

                if (query.Any())
                {
                    // Cria uma nova tabela com os resultados filtrados
                    DataTable filteredTable = query.CopyToDataTable();
                    this.dSPessoaBindingSource.DataSource = filteredTable;
                    this.dSPessoaDataGridView.DataSource = this.dSPessoaBindingSource;
                }
                else
                {
                    // Se não houver resultados, limpa o grid
                    this.dSPessoaDataGridView.DataSource = null;
                    MessageBox.Show("Nenhum registro encontrado para a cidade selecionada.", "Sem Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lblStatus.Text = $"{this.dSPessoaBindingSource.Count} registros encontrados para a cidade '{cidadeFiltrada}'.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao filtrar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}