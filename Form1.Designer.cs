namespace ProjetoAgendaDotNet
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dataNascLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.dataSetPessoa = new ProjetoAgendaDotNet.Dados.DataSetPessoa();
            this.dSPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPessoaTableAdapter = new ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter();
            this.tableAdapterManager = new ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.TableAdapterManager();
            this.dSPessoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dSPessoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dataNascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.dSPessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingNavigator)).BeginInit();
            this.dSPessoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(39, 77);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(55, 20);
            this.nomeLabel.TabIndex = 3;
            this.nomeLabel.Text = "Nome:";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(39, 117);
            this.enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(82, 20);
            this.enderecoLabel.TabIndex = 5;
            this.enderecoLabel.Text = "Endereco:";
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Location = new System.Drawing.Point(39, 157);
            this.cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(63, 20);
            this.cidadeLabel.TabIndex = 7;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(39, 197);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email:";
            // 
            // dataNascLabel
            // 
            this.dataNascLabel.AutoSize = true;
            this.dataNascLabel.Location = new System.Drawing.Point(39, 238);
            this.dataNascLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataNascLabel.Name = "dataNascLabel";
            this.dataNascLabel.Size = new System.Drawing.Size(88, 20);
            this.dataNascLabel.TabIndex = 11;
            this.dataNascLabel.Text = "Data Nasc:";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(39, 277);
            this.telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(75, 20);
            this.telefoneLabel.TabIndex = 13;
            this.telefoneLabel.Text = "Telefone:";
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
            this.dSPessoasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DSPessoasTableAdapter = null;
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
            this.dSPessoaBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dSPessoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dSPessoaBindingNavigator.Size = new System.Drawing.Size(1585, 33);
            this.dSPessoaBindingNavigator.TabIndex = 0;
            this.dSPessoaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // dSPessoaBindingNavigatorSaveItem
            // 
            this.dSPessoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dSPessoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dSPessoaBindingNavigatorSaveItem.Image")));
            this.dSPessoaBindingNavigatorSaveItem.Name = "dSPessoaBindingNavigatorSaveItem";
            this.dSPessoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.dSPessoaBindingNavigatorSaveItem.Text = "Save Data";
            this.dSPessoaBindingNavigatorSaveItem.Click += new System.EventHandler(this.dSPessoaBindingNavigatorSaveItem_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(140, 72);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(436, 26);
            this.nomeTextBox.TabIndex = 4;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(140, 112);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(436, 26);
            this.enderecoTextBox.TabIndex = 6;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(140, 152);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(436, 26);
            this.cidadeTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(140, 192);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(436, 26);
            this.emailTextBox.TabIndex = 10;
            // 
            // dataNascDateTimePicker
            // 
            this.dataNascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dSPessoaBindingSource, "DataNasc", true));
            this.dataNascDateTimePicker.Location = new System.Drawing.Point(140, 232);
            this.dataNascDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataNascDateTimePicker.Name = "dataNascDateTimePicker";
            this.dataNascDateTimePicker.Size = new System.Drawing.Size(436, 26);
            this.dataNascDateTimePicker.TabIndex = 12;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(140, 272);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(436, 26);
            this.telefoneTextBox.TabIndex = 14;
            // 
            // dSPessoaDataGridView
            // 
            this.dSPessoaDataGridView.AllowUserToAddRows = false;
            this.dSPessoaDataGridView.AllowUserToDeleteRows = false;
            this.dSPessoaDataGridView.AutoGenerateColumns = false;
            this.dSPessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dSPessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dSPessoaDataGridView.DataSource = this.dSPessoaBindingSource;
            this.dSPessoaDataGridView.Location = new System.Drawing.Point(654, 38);
            this.dSPessoaDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dSPessoaDataGridView.Name = "dSPessoaDataGridView";
            this.dSPessoaDataGridView.ReadOnly = true;
            this.dSPessoaDataGridView.RowHeadersWidth = 62;
            this.dSPessoaDataGridView.Size = new System.Drawing.Size(535, 291);
            this.dSPessoaDataGridView.TabIndex = 15;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 325);
            this.Controls.Add(this.dSPessoaDataGridView);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.dataNascLabel);
            this.Controls.Add(this.dataNascDateTimePicker);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.dSPessoaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cadastro de Pessoas";
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
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker dataNascDateTimePicker;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dataNascLabel;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.DataGridView dSPessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}