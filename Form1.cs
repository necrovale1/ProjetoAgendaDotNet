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

        private void dSPessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dSPessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetPessoa);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.DSPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.dSPessoaTableAdapter.Fill(this.dataSetPessoa.DSPessoa);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir o registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dSPessoaBindingSource.RemoveCurrent();

            }
        }
    }
}
