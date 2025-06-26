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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Carrega os dados
            this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);

            // Configura o DateTimePicker para iniciar sem valor
            dtpFiltroData.Format = DateTimePickerFormat.Custom;
            dtpFiltroData.CustomFormat = " ";
            dtpFiltroData.ShowCheckBox = true;
            dtpFiltroData.Checked = false;
        }

        // Quando o usuário selecionar uma data
        private void dtpFiltroData_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFiltroData.Checked)
            {
                dtpFiltroData.CustomFormat = "dd/MM/yyyy"; // Ou seu formato preferido
            }
        }

        // Quando ganhar foco (clicar no controle)
        private void dtpFiltroData_GotFocus(object sender, EventArgs e)
        {
            if (!dtpFiltroData.Checked)
            {
                dtpFiltroData.CustomFormat = "dd/MM/yyyy";
                dtpFiltroData.Checked = true;
            }
        }

        // Quando perder foco (sair do controle)
        private void dtpFiltroData_LostFocus(object sender, EventArgs e)
        {
            if (!dtpFiltroData.Checked)
            {
                dtpFiltroData.CustomFormat = " ";
            }
        }
        private void dSPessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void dSPessoaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void SalvarDados()
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
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa todos os filtros
            txtFiltroID.Text = "";
            txtFiltroNome.Text = "";
            txtFiltroEndereco.Text = "";
            txtFiltroTelefone.Text = "";
            txtFiltroCidade.Text = "";
            dtpFiltroData.Value = DateTime.Now;

            // Recarrega todos os dados
            this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria uma cópia dos dados originais
                DataTable dt = this.dataSetPessoa.DSPessoa.Copy();

                // Aplica os filtros conforme os campos preenchidos
                var resultados = dt.AsEnumerable();

                if (!string.IsNullOrEmpty(txtFiltroID.Text))
                {
                    if (int.TryParse(txtFiltroID.Text, out int idFiltro))
                    {
                        resultados = resultados.Where(r => r.Field<int>("ID") == idFiltro);
                    }
                }

                if (!string.IsNullOrEmpty(txtFiltroNome.Text))
                    resultados = resultados.Where(r => r.Field<string>("Nome").ToLower().Contains(txtFiltroNome.Text.ToLower()));

                if (!string.IsNullOrEmpty(txtFiltroEndereco.Text))
                    resultados = resultados.Where(r => r.Field<string>("Endereco").ToLower().Contains(txtFiltroEndereco.Text.ToLower()));

                if (!string.IsNullOrEmpty(txtFiltroCidade.Text))
                    resultados = resultados.Where(r => r.Field<string>("Cidade").ToLower().Contains(txtFiltroCidade.Text.ToLower()));

                if (!string.IsNullOrEmpty(txtFiltroTelefone.Text))
                    resultados = resultados.Where(r => r.Field<string>("Telefone") != null &&
                                                     r.Field<string>("Telefone").Contains(txtFiltroTelefone.Text));

                // Filtro por Data - corrigido
                if (dtpFiltroData.Checked)
                    resultados = resultados.Where(r => r.Field<DateTime>("DataNasc").Date == dtpFiltroData.Value.Date);

                // Converte os resultados de volta para DataTable
                if (resultados.Any())
                {
                    DataTable dtResultado = resultados.CopyToDataTable();
                    dSPessoaBindingSource.DataSource = dtResultado;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com os critérios informados.", "Informação",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recarrega os dados originais
                    this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Recarrega os dados originais em caso de erro
                this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);
            }
        }

        private void tstxtMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Menu mDI_Menu = new MDI_Menu();
            mDI_Menu.ShowDialog();

        }

        private void tsp1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}