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
            Form1 frmCadP = new Form1();
            frmCadP.MdiParent = this;
            frmCadP.ShowDialog();
        }
    }
}
