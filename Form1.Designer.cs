namespace ProjetoAgendaDotNet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label dataNascLabel;
            this.dataSetPessoa = new ProjetoAgendaDotNet.Dados.DataSetPessoa();
            this.dSPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPessoaTableAdapter = new ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter();
            this.tableAdapterManager = new ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.TableAdapterManager();
            this.dSPessoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dSPessoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dataNascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dSPessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            dataNascLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingNavigator)).BeginInit();
            this.dSPessoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetPessoa
            // 
            this.dataSetPessoa.DataSetName = "DataSetPessoa";
            this.dataSetPessoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSPessoaBindingSource
            // 
            this.dSPessoaBindingSource.DataMember = "DSPessoa";
            this.dSPessoaBindingSource.DataSource = this.dataSetPessoa;
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
            // dSPessoaBindingNavigator
            // 
            this.dSPessoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dSPessoaBindingNavigator.BindingSource = this.dSPessoaBindingSource;
            this.dSPessoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dSPessoaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dSPessoaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dSPessoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dSPessoaBindingNavigatorSaveItem});
            this.dSPessoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dSPessoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dSPessoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dSPessoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dSPessoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dSPessoaBindingNavigator.Name = "dSPessoaBindingNavigator";
            this.dSPessoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dSPessoaBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.dSPessoaBindingNavigator.TabIndex = 0;
            this.dSPessoaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 25);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // dSPessoaBindingNavigatorSaveItem
            // 
            this.dSPessoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dSPessoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dSPessoaBindingNavigatorSaveItem.Image")));
            this.dSPessoaBindingNavigatorSaveItem.Name = "dSPessoaBindingNavigatorSaveItem";
            this.dSPessoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dSPessoaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.dSPessoaBindingNavigatorSaveItem.Click += new System.EventHandler(this.dSPessoaBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(61, 108);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(155, 105);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 26);
            this.iDTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(61, 140);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(155, 137);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 26);
            this.nomeTextBox.TabIndex = 4;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(61, 172);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(82, 20);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "Endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(155, 169);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(200, 26);
            this.enderecoTextBox.TabIndex = 6;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(61, 204);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 20);
            cidadeLabel.TabIndex = 7;
            cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(155, 201);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 26);
            this.cidadeTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(61, 236);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(155, 233);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 26);
            this.emailTextBox.TabIndex = 10;
            // 
            // dataNascLabel
            // 
            dataNascLabel.AutoSize = true;
            dataNascLabel.Location = new System.Drawing.Point(61, 269);
            dataNascLabel.Name = "dataNascLabel";
            dataNascLabel.Size = new System.Drawing.Size(88, 20);
            dataNascLabel.TabIndex = 11;
            dataNascLabel.Text = "Data Nasc:";
            // 
            // dataNascDateTimePicker
            // 
            this.dataNascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dSPessoaBindingSource, "DataNasc", true));
            this.dataNascDateTimePicker.Location = new System.Drawing.Point(155, 265);
            this.dataNascDateTimePicker.Name = "dataNascDateTimePicker";
            this.dataNascDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dataNascDateTimePicker.TabIndex = 12;
            // 
            // dSPessoaDataGridView
            // 
            this.dSPessoaDataGridView.AutoGenerateColumns = false;
            this.dSPessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dSPessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dSPessoaDataGridView.DataSource = this.dSPessoaBindingSource;
            this.dSPessoaDataGridView.Location = new System.Drawing.Point(389, 71);
            this.dSPessoaDataGridView.Name = "dSPessoaDataGridView";
            this.dSPessoaDataGridView.RowHeadersWidth = 62;
            this.dSPessoaDataGridView.RowTemplate.Height = 28;
            this.dSPessoaDataGridView.Size = new System.Drawing.Size(300, 220);
            this.dSPessoaDataGridView.TabIndex = 13;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.dSPessoaDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(dataNascLabel);
            this.Controls.Add(this.dataNascDateTimePicker);
            this.Controls.Add(this.dSPessoaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingNavigator)).EndInit();
            this.dSPessoaBindingNavigator.ResumeLayout(false);
            this.dSPessoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DataSetPessoa dataSetPessoa;
        private System.Windows.Forms.BindingSource dSPessoaBindingSource;
        private Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter dSPessoaTableAdapter;
        private Dados.DataSetPessoaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dSPessoaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dSPessoaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker dataNascDateTimePicker;
        private System.Windows.Forms.DataGridView dSPessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

