namespace Estacionamento
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.tpVeiculos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoDataSet1 = new Estacionamento.EstacionamentoDataSet1();
            this.txCor = new System.Windows.Forms.TextBox();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoCadastro = new System.Windows.Forms.TextBox();
            this.txtPlacaCadastro = new System.Windows.Forms.MaskedTextBox();
            this.dgVeiculos = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbDadosVeiculo = new System.Windows.Forms.GroupBox();
            this.btnLiberarVaga = new System.Windows.Forms.Button();
            this.btnEstacionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.painelEstacionamento = new System.Windows.Forms.FlowLayoutPanel();
            this.tpHistorico = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltrarHistorico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataFinalHistorico = new System.Windows.Forms.DateTimePicker();
            this.dataInicialHistorico = new System.Windows.Forms.DateTimePicker();
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.clienteTableAdapter1 = new Estacionamento.EstacionamentoDataSet1TableAdapters.ClienteTableAdapter();
            this.tcPrincipal.SuspendLayout();
            this.tpClientes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.tpVeiculos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gbDadosVeiculo.SuspendLayout();
            this.tpHistorico.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPrincipal.Controls.Add(this.tpClientes);
            this.tcPrincipal.Controls.Add(this.tpVeiculos);
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tpHistorico);
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(827, 502);
            this.tcPrincipal.TabIndex = 4;
            this.tcPrincipal.SelectedIndexChanged += new System.EventHandler(this.tcPrincipal_SelectedIndexChanged);
            // 
            // tpClientes
            // 
            this.tpClientes.BackColor = System.Drawing.Color.Gray;
            this.tpClientes.Controls.Add(this.groupBox3);
            this.tpClientes.Controls.Add(this.dgClientes);
            this.tpClientes.Location = new System.Drawing.Point(4, 22);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientes.Size = new System.Drawing.Size(819, 476);
            this.tpClientes.TabIndex = 3;
            this.tpClientes.Text = "Clientes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEndereco);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCpf);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTelefone);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnCadastroCliente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtNome);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Novo Cliente";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(91, 48);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(137, 20);
            this.txtEndereco.TabIndex = 11;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Endereço";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(91, 72);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(137, 20);
            this.txtCpf.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(91, 98);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(137, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone";
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.Location = new System.Drawing.Point(91, 128);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(137, 23);
            this.btnCadastroCliente.TabIndex = 5;
            this.btnCadastroCliente.Text = "Cadastrar cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 20);
            this.txtNome.TabIndex = 2;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgClientes.Location = new System.Drawing.Point(3, 3);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgClientes.RowHeadersVisible = false;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(813, 306);
            this.dgClientes.TabIndex = 1;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // tpVeiculos
            // 
            this.tpVeiculos.BackColor = System.Drawing.Color.Gray;
            this.tpVeiculos.Controls.Add(this.groupBox1);
            this.tpVeiculos.Controls.Add(this.dgVeiculos);
            this.tpVeiculos.Location = new System.Drawing.Point(4, 22);
            this.tpVeiculos.Name = "tpVeiculos";
            this.tpVeiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tpVeiculos.Size = new System.Drawing.Size(819, 476);
            this.tpVeiculos.TabIndex = 1;
            this.tpVeiculos.Text = "Veículos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxCliente);
            this.groupBox1.Controls.Add(this.txCor);
            this.groupBox1.Controls.Add(this.lbIdCliente);
            this.groupBox1.Controls.Add(this.lbCor);
            this.groupBox1.Controls.Add(this.btnCadastrarVeiculo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescricaoCadastro);
            this.groupBox1.Controls.Add(this.txtPlacaCadastro);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo veículo";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(81, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.DataSource = this.clienteBindingSource1;
            this.cbxCliente.DisplayMember = "Id";
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(81, 119);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(100, 21);
            this.cbxCliente.TabIndex = 10;
            this.cbxCliente.ValueMember = "Id";
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.estacionamentoDataSet1;
            // 
            // estacionamentoDataSet1
            // 
            this.estacionamentoDataSet1.DataSetName = "EstacionamentoDataSet1";
            this.estacionamentoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txCor
            // 
            this.txCor.Location = new System.Drawing.Point(81, 87);
            this.txCor.Name = "txCor";
            this.txCor.Size = new System.Drawing.Size(100, 20);
            this.txCor.TabIndex = 9;
            this.txCor.TextChanged += new System.EventHandler(this.txIdCliente_TextChanged);
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(22, 119);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(39, 13);
            this.lbIdCliente.TabIndex = 8;
            this.lbIdCliente.Text = "Cliente";
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Location = new System.Drawing.Point(38, 90);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(23, 13);
            this.lbCor.TabIndex = 6;
            this.lbCor.Text = "Cor";
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(81, 152);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrarVeiculo.TabIndex = 5;
            this.btnCadastrarVeiculo.Text = "Cadastrar veículo";
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.btnCadastrarVeiculo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescricaoCadastro
            // 
            this.txtDescricaoCadastro.Location = new System.Drawing.Point(81, 56);
            this.txtDescricaoCadastro.Name = "txtDescricaoCadastro";
            this.txtDescricaoCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoCadastro.TabIndex = 2;
            // 
            // txtPlacaCadastro
            // 
            this.txtPlacaCadastro.Location = new System.Drawing.Point(81, 23);
            this.txtPlacaCadastro.Mask = "CCC-9999";
            this.txtPlacaCadastro.Name = "txtPlacaCadastro";
            this.txtPlacaCadastro.PromptChar = ' ';
            this.txtPlacaCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtPlacaCadastro.TabIndex = 1;
            // 
            // dgVeiculos
            // 
            this.dgVeiculos.AllowUserToAddRows = false;
            this.dgVeiculos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgVeiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVeiculos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgVeiculos.Location = new System.Drawing.Point(3, 3);
            this.dgVeiculos.Name = "dgVeiculos";
            this.dgVeiculos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVeiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgVeiculos.RowHeadersVisible = false;
            this.dgVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVeiculos.Size = new System.Drawing.Size(813, 245);
            this.dgVeiculos.TabIndex = 0;
            this.dgVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeiculos_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.gbDadosVeiculo);
            this.tabPage1.Controls.Add(this.painelEstacionamento);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estacionamento";
            // 
            // gbDadosVeiculo
            // 
            this.gbDadosVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDadosVeiculo.Controls.Add(this.btnLiberarVaga);
            this.gbDadosVeiculo.Controls.Add(this.btnEstacionar);
            this.gbDadosVeiculo.Controls.Add(this.label2);
            this.gbDadosVeiculo.Controls.Add(this.txtPlaca);
            this.gbDadosVeiculo.Enabled = false;
            this.gbDadosVeiculo.ForeColor = System.Drawing.Color.White;
            this.gbDadosVeiculo.Location = new System.Drawing.Point(4, 405);
            this.gbDadosVeiculo.Name = "gbDadosVeiculo";
            this.gbDadosVeiculo.Size = new System.Drawing.Size(312, 67);
            this.gbDadosVeiculo.TabIndex = 5;
            this.gbDadosVeiculo.TabStop = false;
            this.gbDadosVeiculo.Text = "Dados do veículo";
            // 
            // btnLiberarVaga
            // 
            this.btnLiberarVaga.ForeColor = System.Drawing.Color.Black;
            this.btnLiberarVaga.Location = new System.Drawing.Point(218, 37);
            this.btnLiberarVaga.Name = "btnLiberarVaga";
            this.btnLiberarVaga.Size = new System.Drawing.Size(75, 23);
            this.btnLiberarVaga.TabIndex = 5;
            this.btnLiberarVaga.Text = "Liberar vaga";
            this.btnLiberarVaga.UseVisualStyleBackColor = true;
            this.btnLiberarVaga.Click += new System.EventHandler(this.btnLiberarVaga_Click);
            // 
            // btnEstacionar
            // 
            this.btnEstacionar.ForeColor = System.Drawing.Color.Black;
            this.btnEstacionar.Location = new System.Drawing.Point(137, 37);
            this.btnEstacionar.Name = "btnEstacionar";
            this.btnEstacionar.Size = new System.Drawing.Size(75, 23);
            this.btnEstacionar.TabIndex = 4;
            this.btnEstacionar.Text = "Estacionar";
            this.btnEstacionar.UseVisualStyleBackColor = true;
            this.btnEstacionar.Click += new System.EventHandler(this.btnEstacionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite a placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(30, 38);
            this.txtPlaca.Mask = "CCC-9999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PromptChar = ' ';
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 0;
            // 
            // painelEstacionamento
            // 
            this.painelEstacionamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelEstacionamento.AutoScroll = true;
            this.painelEstacionamento.BackColor = System.Drawing.Color.LightGray;
            this.painelEstacionamento.Location = new System.Drawing.Point(3, 6);
            this.painelEstacionamento.Name = "painelEstacionamento";
            this.painelEstacionamento.Size = new System.Drawing.Size(815, 394);
            this.painelEstacionamento.TabIndex = 4;
            // 
            // tpHistorico
            // 
            this.tpHistorico.BackColor = System.Drawing.Color.Gray;
            this.tpHistorico.Controls.Add(this.groupBox2);
            this.tpHistorico.Controls.Add(this.dgHistorico);
            this.tpHistorico.Location = new System.Drawing.Point(4, 22);
            this.tpHistorico.Name = "tpHistorico";
            this.tpHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tpHistorico.Size = new System.Drawing.Size(819, 476);
            this.tpHistorico.TabIndex = 2;
            this.tpHistorico.Text = "Histórico";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnFiltrarHistorico);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataFinalHistorico);
            this.groupBox2.Controls.Add(this.dataInicialHistorico);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por periodo";
            // 
            // btnFiltrarHistorico
            // 
            this.btnFiltrarHistorico.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrarHistorico.Location = new System.Drawing.Point(246, 37);
            this.btnFiltrarHistorico.Name = "btnFiltrarHistorico";
            this.btnFiltrarHistorico.Size = new System.Drawing.Size(103, 22);
            this.btnFiltrarHistorico.TabIndex = 8;
            this.btnFiltrarHistorico.Text = "Filtrar ";
            this.btnFiltrarHistorico.UseVisualStyleBackColor = true;
            this.btnFiltrarHistorico.Click += new System.EventHandler(this.btnFiltrarHistorico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data inicial";
            // 
            // dataFinalHistorico
            // 
            this.dataFinalHistorico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinalHistorico.Location = new System.Drawing.Point(135, 39);
            this.dataFinalHistorico.Name = "dataFinalHistorico";
            this.dataFinalHistorico.Size = new System.Drawing.Size(103, 20);
            this.dataFinalHistorico.TabIndex = 5;
            // 
            // dataInicialHistorico
            // 
            this.dataInicialHistorico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicialHistorico.Location = new System.Drawing.Point(19, 38);
            this.dataInicialHistorico.Name = "dataInicialHistorico";
            this.dataInicialHistorico.Size = new System.Drawing.Size(103, 20);
            this.dataInicialHistorico.TabIndex = 4;
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgHistorico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHistorico.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgHistorico.Location = new System.Drawing.Point(3, 3);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgHistorico.RowHeadersVisible = false;
            this.dgHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHistorico.Size = new System.Drawing.Size(813, 388);
            this.dgHistorico.TabIndex = 1;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            // 
            // dadosBindingSource
            // 
            this.dadosBindingSource.DataSource = typeof(Estacionamento.Classes.Dados);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 505);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(46, 22);
            this.btnSair.Text = "&Sair";
            this.btnSair.ToolTipText = "Sair da aplicação";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 530);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tcPrincipal);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamento";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tpClientes.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.tpVeiculos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.gbDadosVeiculo.ResumeLayout(false);
            this.gbDadosVeiculo.PerformLayout();
            this.tpHistorico.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel painelEstacionamento;
        private System.Windows.Forms.TabPage tpVeiculos;
        private System.Windows.Forms.GroupBox gbDadosVeiculo;
        private System.Windows.Forms.Button btnEstacionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrarVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoCadastro;
        private System.Windows.Forms.MaskedTextBox txtPlacaCadastro;
        private System.Windows.Forms.DataGridView dgVeiculos;
        private System.Windows.Forms.Button btnLiberarVaga;
        private System.Windows.Forms.TabPage tpHistorico;
        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataFinalHistorico;
        private System.Windows.Forms.DateTimePicker dataInicialHistorico;
        private System.Windows.Forms.Button btnFiltrarHistorico;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txCor;
        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.BindingSource dadosBindingSource;
        //private EstacionamentoDataSet estacionamentoDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
       // private EstacionamentoDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private EstacionamentoDataSet1 estacionamentoDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private EstacionamentoDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter1;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Button button1;
    }
}

