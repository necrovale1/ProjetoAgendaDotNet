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
    public partial class MDI_Menu : Form 
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Show();
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Sair?","Confirmar",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else {
                return;
            }
        }
    }
}
