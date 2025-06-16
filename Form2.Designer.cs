namespace ProjetoAgendaDotNet
{
    //MDI CONSULTA
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFiltroData = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtFiltroID = new System.Windows.Forms.TextBox();
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.txtFiltroEndereco = new System.Windows.Forms.TextBox();
            this.txtFiltroCidade = new System.Windows.Forms.TextBox();
            this.txtFiltroTelefone = new System.Windows.Forms.TextBox();
            this.txtFiltroEmail = new System.Windows.Forms.TextBox();
            this.dSPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPessoa = new ProjetoAgendaDotNet.Dados.DataSetPessoa();
            this.dSPessoaTableAdapter = new ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter();
            this.tableAdapterManager = new ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.TableAdapterManager();
            this.dSPessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsp1 = new System.Windows.Forms.ToolStrip();
            this.tstxtMenuPrincipal = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaDataGridView)).BeginInit();
            this.tsp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data";
            // 
            // dtpFiltroData
            // 
            this.dtpFiltroData.Location = new System.Drawing.Point(41, 527);
            this.dtpFiltroData.Name = "dtpFiltroData";
            this.dtpFiltroData.Size = new System.Drawing.Size(246, 26);
            this.dtpFiltroData.TabIndex = 18;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(656, 524);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 37);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(347, 524);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(288, 37);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtFiltroID
            // 
            this.txtFiltroID.Location = new System.Drawing.Point(50, 130);
            this.txtFiltroID.Name = "txtFiltroID";
            this.txtFiltroID.Size = new System.Drawing.Size(237, 26);
            this.txtFiltroID.TabIndex = 22;
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.Location = new System.Drawing.Point(49, 198);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(237, 26);
            this.txtFiltroNome.TabIndex = 23;
            // 
            // txtFiltroEndereco
            // 
            this.txtFiltroEndereco.Location = new System.Drawing.Point(50, 268);
            this.txtFiltroEndereco.Name = "txtFiltroEndereco";
            this.txtFiltroEndereco.Size = new System.Drawing.Size(237, 26);
            this.txtFiltroEndereco.TabIndex = 24;
            // 
            // txtFiltroCidade
            // 
            this.txtFiltroCidade.Location = new System.Drawing.Point(49, 333);
            this.txtFiltroCidade.Name = "txtFiltroCidade";
            this.txtFiltroCidade.Size = new System.Drawing.Size(237, 26);
            this.txtFiltroCidade.TabIndex = 25;
            // 
            // txtFiltroTelefone
            // 
            this.txtFiltroTelefone.Location = new System.Drawing.Point(50, 398);
            this.txtFiltroTelefone.Name = "txtFiltroTelefone";
            this.txtFiltroTelefone.Size = new System.Drawing.Size(237, 26);
            this.txtFiltroTelefone.TabIndex = 26;
            // 
            // txtFiltroEmail
            // 
            this.txtFiltroEmail.Location = new System.Drawing.Point(50, 459);
            this.txtFiltroEmail.Name = "txtFiltroEmail";
            this.txtFiltroEmail.Size = new System.Drawing.Size(237, 26);
            this.txtFiltroEmail.TabIndex = 27;
            // 
            // dSPessoaBindingSource
            // 
            this.dSPessoaBindingSource.DataMember = "DSPessoa";
            this.dSPessoaBindingSource.DataSource = this.dataSetPessoa;
            // 
            // dataSetPessoa
            // 
            this.dataSetPessoa.DataSetName = "DataSetPessoa";
            this.dataSetPessoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSPessoaTableAdapter
            // 
            this.dSPessoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DSPessoaTableAdapter = this.dSPessoaTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dSPessoaDataGridView
            // 
            this.dSPessoaDataGridView.AutoGenerateColumns = false;
            this.dSPessoaDataGridView.ColumnHeadersHeight = 34;
            this.dSPessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dSPessoaDataGridView.DataSource = this.dSPessoaBindingSource;
            this.dSPessoaDataGridView.Location = new System.Drawing.Point(345, 107);
            this.dSPessoaDataGridView.Margin = new System.Windows.Forms.Padding(3, 3, 75, 3);
            this.dSPessoaDataGridView.Name = "dSPessoaDataGridView";
            this.dSPessoaDataGridView.RowHeadersWidth = 62;
            this.dSPessoaDataGridView.RowTemplate.Height = 28;
            this.dSPessoaDataGridView.Size = new System.Drawing.Size(1114, 383);
            this.dSPessoaDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DataNasc";
            this.dataGridViewTextBoxColumn6.HeaderText = "DataNasc";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // tsp1
            // 
            this.tsp1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtMenuPrincipal});
            this.tsp1.Location = new System.Drawing.Point(0, 0);
            this.tsp1.Name = "tsp1";
            this.tsp1.Size = new System.Drawing.Size(1620, 31);
            this.tsp1.TabIndex = 28;
            // 
            // tstxtMenuPrincipal
            // 
            this.tstxtMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtMenuPrincipal.Name = "tstxtMenuPrincipal";
            this.tstxtMenuPrincipal.Size = new System.Drawing.Size(150, 38);
            this.tstxtMenuPrincipal.Text = "Menu Principal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1620, 659);
            this.ControlBox = false;
            this.Controls.Add(this.tsp1);
            this.Controls.Add(this.dSPessoaDataGridView);
            this.Controls.Add(this.txtFiltroEmail);
            this.Controls.Add(this.txtFiltroTelefone);
            this.Controls.Add(this.txtFiltroCidade);
            this.Controls.Add(this.txtFiltroEndereco);
            this.Controls.Add(this.txtFiltroNome);
            this.Controls.Add(this.txtFiltroID);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtpFiltroData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "MDI_Consulta";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaDataGridView)).EndInit();
            this.tsp1.ResumeLayout(false);
            this.tsp1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DataSetPessoa dataSetPessoa;
        private System.Windows.Forms.BindingSource dSPessoaBindingSource;
        private Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter dSPessoaTableAdapter;
        private Dados.DataSetPessoaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFiltroData;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtFiltroID;
        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.TextBox txtFiltroEndereco;
        private System.Windows.Forms.TextBox txtFiltroCidade;
        private System.Windows.Forms.TextBox txtFiltroTelefone;
        private System.Windows.Forms.TextBox txtFiltroEmail;
        private System.Windows.Forms.DataGridView dSPessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStrip tsp1;
        private System.Windows.Forms.ToolStripTextBox tstxtMenuPrincipal;
    }
}