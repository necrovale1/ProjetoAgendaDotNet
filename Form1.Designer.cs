namespace ProjetoAgendaDotNet
{
    //MDI_PESSOAS
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
            System.Windows.Forms.Label lblNome;
            System.Windows.Forms.Label lblEndereco;
            System.Windows.Forms.Label lblCidade;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblDataNasc;
            System.Windows.Forms.Label lblID;
            System.Windows.Forms.Label lblTelefone;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dSPessoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dSPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPessoa = new ProjetoAgendaDotNet.Dados.DataSetPessoa();
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dSPessoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSPessoaTableAdapter = new ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.DSPessoaTableAdapter();
            this.tableAdapterManager = new ProjetoAgendaDotNet.Dados.DataSetPessoaTableAdapters.TableAdapterManager();
            this.dSPessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            lblNome = new System.Windows.Forms.Label();
            lblEndereco = new System.Windows.Forms.Label();
            lblCidade = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblDataNasc = new System.Windows.Forms.Label();
            lblID = new System.Windows.Forms.Label();
            lblTelefone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingNavigator)).BeginInit();
            this.dSPessoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new System.Drawing.Point(41, 91);
            lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(38, 13);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new System.Drawing.Point(41, 112);
            lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new System.Drawing.Size(56, 13);
            lblEndereco.TabIndex = 5;
            lblEndereco.Text = "Endereco:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new System.Drawing.Point(41, 133);
            lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new System.Drawing.Size(43, 13);
            lblCidade.TabIndex = 7;
            lblCidade.Text = "Cidade:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(41, 153);
            lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new System.Drawing.Point(41, 199);
            lblDataNasc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new System.Drawing.Size(61, 13);
            lblDataNasc.TabIndex = 11;
            lblDataNasc.Text = "Data Nasc:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new System.Drawing.Point(41, 70);
            lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(21, 13);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new System.Drawing.Point(41, 177);
            lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new System.Drawing.Size(52, 13);
            lblTelefone.TabIndex = 15;
            lblTelefone.Text = "Telefone:";
            // 
            // dSPessoaBindingNavigator
            // 
            this.dSPessoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dSPessoaBindingNavigator.BackColor = System.Drawing.Color.MistyRose;
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
            this.toolStripButton1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dSPessoaBindingNavigatorSaveItem});
            this.dSPessoaBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.dSPessoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dSPessoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dSPessoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dSPessoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dSPessoaBindingNavigator.Name = "dSPessoaBindingNavigator";
            this.dSPessoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dSPessoaBindingNavigator.Size = new System.Drawing.Size(1125, 31);
            this.dSPessoaBindingNavigator.TabIndex = 0;
            this.dSPessoaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.MistyRose;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // dSPessoaBindingNavigatorSaveItem
            // 
            this.dSPessoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dSPessoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dSPessoaBindingNavigatorSaveItem.Image")));
            this.dSPessoaBindingNavigatorSaveItem.Name = "dSPessoaBindingNavigatorSaveItem";
            this.dSPessoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.dSPessoaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.dSPessoaBindingNavigatorSaveItem.Click += new System.EventHandler(this.dSPessoaBindingNavigatorSaveItem_Click);
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.MistyRose;
            this.txbNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Nome", true));
            this.txbNome.Location = new System.Drawing.Point(103, 89);
            this.txbNome.Margin = new System.Windows.Forms.Padding(2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(135, 20);
            this.txbNome.TabIndex = 4;
            // 
            // txbEndereco
            // 
            this.txbEndereco.BackColor = System.Drawing.Color.MistyRose;
            this.txbEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Endereco", true));
            this.txbEndereco.Location = new System.Drawing.Point(103, 110);
            this.txbEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(135, 20);
            this.txbEndereco.TabIndex = 6;
            // 
            // txbCidade
            // 
            this.txbCidade.BackColor = System.Drawing.Color.MistyRose;
            this.txbCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Cidade", true));
            this.txbCidade.Location = new System.Drawing.Point(103, 131);
            this.txbCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(135, 20);
            this.txbCidade.TabIndex = 8;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.MistyRose;
            this.txbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Email", true));
            this.txbEmail.Location = new System.Drawing.Point(103, 151);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(135, 20);
            this.txbEmail.TabIndex = 10;
            // 
            // dtpData
            // 
            this.dtpData.CalendarForeColor = System.Drawing.Color.MistyRose;
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dtpData.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpData.CalendarTrailingForeColor = System.Drawing.Color.MistyRose;
            this.dtpData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dSPessoaBindingSource, "DataNasc", true));
            this.dtpData.Location = new System.Drawing.Point(103, 196);
            this.dtpData.Margin = new System.Windows.Forms.Padding(2);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(135, 20);
            this.dtpData.TabIndex = 12;
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(103, 68);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(135, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1125, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPriToolStripMenuItem
            // 
            this.menuPriToolStripMenuItem.Name = "menuPriToolStripMenuItem";
            this.menuPriToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.menuPriToolStripMenuItem.Text = "Menu Principal";
            this.menuPriToolStripMenuItem.Click += new System.EventHandler(this.menuPriToolStripMenuItem_Click);
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
            this.dSPessoaDataGridView.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dSPessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dSPessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dSPessoaDataGridView.DataSource = this.dSPessoaBindingSource;
            this.dSPessoaDataGridView.GridColor = System.Drawing.Color.Firebrick;
            this.dSPessoaDataGridView.Location = new System.Drawing.Point(289, 62);
            this.dSPessoaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dSPessoaDataGridView.Name = "dSPessoaDataGridView";
            this.dSPessoaDataGridView.RowHeadersWidth = 62;
            this.dSPessoaDataGridView.RowTemplate.Height = 28;
            this.dSPessoaDataGridView.Size = new System.Drawing.Size(751, 143);
            this.dSPessoaDataGridView.TabIndex = 14;
            this.dSPessoaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dSPessoaDataGridView_CellContentClick);
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
            // txbTelefone
            // 
            this.txbTelefone.BackColor = System.Drawing.Color.MistyRose;
            this.txbTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPessoaBindingSource, "Email", true));
            this.txbTelefone.Location = new System.Drawing.Point(103, 176);
            this.txbTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(135, 20);
            this.txbTelefone.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1125, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1125, 250);
            this.Controls.Add(this.dSPessoaDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(lblTelefone);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(lblID);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(lblEndereco);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(lblCidade);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(lblDataNasc);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.dSPessoaBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MDI_Pessoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingNavigator)).EndInit();
            this.dSPessoaBindingNavigator.ResumeLayout(false);
            this.dSPessoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPessoaDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPriToolStripMenuItem;
        private System.Windows.Forms.DataGridView dSPessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

