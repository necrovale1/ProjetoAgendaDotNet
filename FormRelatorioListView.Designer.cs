namespace ProjetoAgendaDotNet
{
    partial class FormRelatorioListView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listViewRelatorio = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewRelatorio
            // 
            this.listViewRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRelatorio.HideSelection = false;
            this.listViewRelatorio.Location = new System.Drawing.Point(0, 0);
            this.listViewRelatorio.Name = "listViewRelatorio";
            this.listViewRelatorio.Size = new System.Drawing.Size(800, 450);
            this.listViewRelatorio.TabIndex = 0;
            this.listViewRelatorio.UseCompatibleStateImageBehavior = false;
            this.listViewRelatorio.View = System.Windows.Forms.View.Details;
            // 
            // FormRelatorioListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewRelatorio);
            this.Name = "FormRelatorioListView";
            this.Text = "Relatório em Lista";
            // A LINHA DA CORREÇÃO ESTÁ AQUI:
            this.Load += new System.EventHandler(this.FormRelatorioListView_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listViewRelatorio;
    }
}