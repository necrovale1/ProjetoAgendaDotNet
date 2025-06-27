using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoAgendaDotNet
{
    public partial class FormRelatorioListView : Form
    {
        private DataView dadosParaExibir;

        public FormRelatorioListView(DataView dados)
        {
            // Esta chamada é essencial! Ela executa o código do outro arquivo.
            InitializeComponent();

            this.dadosParaExibir = dados;
        }

        private void FormRelatorioListView_Load(object sender, EventArgs e)
        {
            listViewRelatorio.Items.Clear();
            listViewRelatorio.Columns.Clear();

            if (dadosParaExibir == null || dadosParaExibir.Count == 0)
            {
                MessageBox.Show("Não há dados para exibir.", "Informação");
                this.Close();
                return;
            }

            foreach (DataColumn coluna in dadosParaExibir.Table.Columns)
            {
                listViewRelatorio.Columns.Add(coluna.ColumnName, 120);
            }

            foreach (DataRowView linha in dadosParaExibir)
            {
                ListViewItem item = new ListViewItem(linha[0]?.ToString() ?? "");
                for (int i = 1; i < dadosParaExibir.Table.Columns.Count; i++)
                {
                    item.SubItems.Add(linha[i]?.ToString() ?? "");
                }
                listViewRelatorio.Items.Add(item);
            }
            listViewRelatorio.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}