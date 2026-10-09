namespace ControleEstoqueWindowsForm
{
    partial class FrmOrdemServico
    {
        /// <summary>
        /// Variável necessária do designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblStatusOS = new System.Windows.Forms.Label();
            this.grpCabecalho = new System.Windows.Forms.GroupBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.txtDataAbertura = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.lblProblema = new System.Windows.Forms.Label();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.grpServicos = new System.Windows.Forms.GroupBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.lblValorServico = new System.Windows.Forms.Label();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.btnAdicionarServico = new System.Windows.Forms.Button();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.btnRemoverServico = new System.Windows.Forms.Button();
            this.lblSubtotalServicos = new System.Windows.Forms.Label();
            this.grpPecas = new System.Windows.Forms.GroupBox();
            this.lblPeca = new System.Windows.Forms.Label();
            this.cboPeca = new System.Windows.Forms.ComboBox();
            this.lblQuantidadePeca = new System.Windows.Forms.Label();
            this.txtQuantidadePeca = new System.Windows.Forms.TextBox();
            this.lblValorPeca = new System.Windows.Forms.Label();
            this.txtValorPeca = new System.Windows.Forms.TextBox();
            this.btnAdicionarPeca = new System.Windows.Forms.Button();
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.btnRemoverPeca = new System.Windows.Forms.Button();
            this.lblSubtotalPecas = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelarOS = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.grpCabecalho.SuspendLayout();
            this.grpServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.grpPecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblSubTitulo);
            this.pnlTopo.Controls.Add(this.lblStatusOS);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1000, 80);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📋 Nova Ordem de Serviço";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(21, 48);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(403, 20);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "Escolha o cliente, o veículo e descreva o problema relatado";
            // 
            // lblStatusOS
            // 
            this.lblStatusOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.lblStatusOS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusOS.ForeColor = System.Drawing.Color.White;
            this.lblStatusOS.Location = new System.Drawing.Point(830, 24);
            this.lblStatusOS.Name = "lblStatusOS";
            this.lblStatusOS.Size = new System.Drawing.Size(150, 32);
            this.lblStatusOS.TabIndex = 2;
            this.lblStatusOS.Text = "Nova";
            this.lblStatusOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCabecalho
            // 
            this.grpCabecalho.Controls.Add(this.lblNumero);
            this.grpCabecalho.Controls.Add(this.txtNumero);
            this.grpCabecalho.Controls.Add(this.lblDataAbertura);
            this.grpCabecalho.Controls.Add(this.txtDataAbertura);
            this.grpCabecalho.Controls.Add(this.lblCliente);
            this.grpCabecalho.Controls.Add(this.cboCliente);
            this.grpCabecalho.Controls.Add(this.lblVeiculo);
            this.grpCabecalho.Controls.Add(this.cboVeiculo);
            this.grpCabecalho.Controls.Add(this.lblProblema);
            this.grpCabecalho.Controls.Add(this.txtProblema);
            this.grpCabecalho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpCabecalho.Location = new System.Drawing.Point(20, 92);
            this.grpCabecalho.Name = "grpCabecalho";
            this.grpCabecalho.Size = new System.Drawing.Size(960, 175);
            this.grpCabecalho.TabIndex = 1;
            this.grpCabecalho.TabStop = false;
            this.grpCabecalho.Text = "Dados da OS";
            this.grpCabecalho.Enter += new System.EventHandler(this.grpCabecalho_Enter);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 25);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Nº OS:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumero.Location = new System.Drawing.Point(15, 47);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(90, 30);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TabStop = false;
            // 
            // lblDataAbertura
            // 
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Location = new System.Drawing.Point(120, 25);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(70, 20);
            this.lblDataAbertura.TabIndex = 2;
            this.lblDataAbertura.Text = "Abertura:";
            // 
            // txtDataAbertura
            // 
            this.txtDataAbertura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDataAbertura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDataAbertura.Location = new System.Drawing.Point(120, 47);
            this.txtDataAbertura.Name = "txtDataAbertura";
            this.txtDataAbertura.ReadOnly = true;
            this.txtDataAbertura.Size = new System.Drawing.Size(150, 30);
            this.txtDataAbertura.TabIndex = 3;
            this.txtDataAbertura.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(285, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCliente.Location = new System.Drawing.Point(285, 47);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(330, 31);
            this.cboCliente.TabIndex = 5;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(630, 25);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(60, 20);
            this.lblVeiculo.TabIndex = 6;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // cboVeiculo
            // 
            this.cboVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVeiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVeiculo.Location = new System.Drawing.Point(630, 47);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(315, 31);
            this.cboVeiculo.TabIndex = 7;
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(15, 85);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(218, 20);
            this.lblProblema.TabIndex = 8;
            this.lblProblema.Text = "Problema relatado pelo cliente:";
            // 
            // txtProblema
            // 
            this.txtProblema.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProblema.Location = new System.Drawing.Point(15, 107);
            this.txtProblema.MaxLength = 500;
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProblema.Size = new System.Drawing.Size(930, 55);
            this.txtProblema.TabIndex = 9;
            // 
            // grpServicos
            // 
            this.grpServicos.Controls.Add(this.lblServico);
            this.grpServicos.Controls.Add(this.cboServico);
            this.grpServicos.Controls.Add(this.lblValorServico);
            this.grpServicos.Controls.Add(this.txtValorServico);
            this.grpServicos.Controls.Add(this.btnAdicionarServico);
            this.grpServicos.Controls.Add(this.dgvServicos);
            this.grpServicos.Controls.Add(this.btnRemoverServico);
            this.grpServicos.Controls.Add(this.lblSubtotalServicos);
            this.grpServicos.Enabled = false;
            this.grpServicos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpServicos.Location = new System.Drawing.Point(20, 278);
            this.grpServicos.Name = "grpServicos";
            this.grpServicos.Size = new System.Drawing.Size(470, 300);
            this.grpServicos.TabIndex = 2;
            this.grpServicos.TabStop = false;
            this.grpServicos.Text = "Serviços";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(15, 25);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(60, 20);
            this.lblServico.TabIndex = 0;
            this.lblServico.Text = "Serviço:";
            // 
            // cboServico
            // 
            this.cboServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboServico.Location = new System.Drawing.Point(15, 47);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(270, 31);
            this.cboServico.TabIndex = 1;
            this.cboServico.SelectedIndexChanged += new System.EventHandler(this.cboServico_SelectedIndexChanged);
            // 
            // lblValorServico
            // 
            this.lblValorServico.AutoSize = true;
            this.lblValorServico.Location = new System.Drawing.Point(295, 25);
            this.lblValorServico.Name = "lblValorServico";
            this.lblValorServico.Size = new System.Drawing.Size(77, 20);
            this.lblValorServico.TabIndex = 2;
            this.lblValorServico.Text = "Valor (R$):";
            // 
            // txtValorServico
            // 
            this.txtValorServico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtValorServico.Location = new System.Drawing.Point(295, 47);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(80, 30);
            this.txtValorServico.TabIndex = 3;
            this.txtValorServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.btnAdicionarServico.FlatAppearance.BorderSize = 0;
            this.btnAdicionarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarServico.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarServico.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarServico.Location = new System.Drawing.Point(383, 45);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(72, 34);
            this.btnAdicionarServico.TabIndex = 4;
            this.btnAdicionarServico.Text = "➕";
            this.btnAdicionarServico.UseVisualStyleBackColor = false;
            this.btnAdicionarServico.Click += new System.EventHandler(this.btnAdicionarServico_Click);
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.EnableHeadersVisualStyles = false;
            this.dgvServicos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvServicos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvServicos.Location = new System.Drawing.Point(15, 88);
            this.dgvServicos.MultiSelect = false;
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            this.dgvServicos.RowHeadersVisible = false;
            this.dgvServicos.RowHeadersWidth = 51;
            this.dgvServicos.RowTemplate.Height = 26;
            this.dgvServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicos.Size = new System.Drawing.Size(440, 162);
            this.dgvServicos.TabIndex = 5;
            // 
            // btnRemoverServico
            // 
            this.btnRemoverServico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoverServico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnRemoverServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverServico.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRemoverServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnRemoverServico.Location = new System.Drawing.Point(15, 258);
            this.btnRemoverServico.Name = "btnRemoverServico";
            this.btnRemoverServico.Size = new System.Drawing.Size(120, 32);
            this.btnRemoverServico.TabIndex = 6;
            this.btnRemoverServico.Text = "Remover";
            this.btnRemoverServico.UseVisualStyleBackColor = false;
            this.btnRemoverServico.Click += new System.EventHandler(this.btnRemoverServico_Click);
            // 
            // lblSubtotalServicos
            // 
            this.lblSubtotalServicos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblSubtotalServicos.Location = new System.Drawing.Point(255, 262);
            this.lblSubtotalServicos.Name = "lblSubtotalServicos";
            this.lblSubtotalServicos.Size = new System.Drawing.Size(200, 24);
            this.lblSubtotalServicos.TabIndex = 7;
            this.lblSubtotalServicos.Text = "Subtotal: R$ 0,00";
            this.lblSubtotalServicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpPecas
            // 
            this.grpPecas.Controls.Add(this.lblPeca);
            this.grpPecas.Controls.Add(this.cboPeca);
            this.grpPecas.Controls.Add(this.lblQuantidadePeca);
            this.grpPecas.Controls.Add(this.txtQuantidadePeca);
            this.grpPecas.Controls.Add(this.lblValorPeca);
            this.grpPecas.Controls.Add(this.txtValorPeca);
            this.grpPecas.Controls.Add(this.btnAdicionarPeca);
            this.grpPecas.Controls.Add(this.dgvPecas);
            this.grpPecas.Controls.Add(this.btnRemoverPeca);
            this.grpPecas.Controls.Add(this.lblSubtotalPecas);
            this.grpPecas.Enabled = false;
            this.grpPecas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpPecas.Location = new System.Drawing.Point(510, 278);
            this.grpPecas.Name = "grpPecas";
            this.grpPecas.Size = new System.Drawing.Size(470, 300);
            this.grpPecas.TabIndex = 3;
            this.grpPecas.TabStop = false;
            this.grpPecas.Text = "Peças";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Location = new System.Drawing.Point(15, 25);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(42, 20);
            this.lblPeca.TabIndex = 0;
            this.lblPeca.Text = "Peça:";
            // 
            // cboPeca
            // 
            this.cboPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPeca.Location = new System.Drawing.Point(15, 47);
            this.cboPeca.Name = "cboPeca";
            this.cboPeca.Size = new System.Drawing.Size(200, 31);
            this.cboPeca.TabIndex = 1;
            this.cboPeca.SelectedIndexChanged += new System.EventHandler(this.cboPeca_SelectedIndexChanged);
            // 
            // lblQuantidadePeca
            // 
            this.lblQuantidadePeca.AutoSize = true;
            this.lblQuantidadePeca.Location = new System.Drawing.Point(223, 25);
            this.lblQuantidadePeca.Name = "lblQuantidadePeca";
            this.lblQuantidadePeca.Size = new System.Drawing.Size(37, 20);
            this.lblQuantidadePeca.TabIndex = 2;
            this.lblQuantidadePeca.Text = "Qtd:";
            // 
            // txtQuantidadePeca
            // 
            this.txtQuantidadePeca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantidadePeca.Location = new System.Drawing.Point(223, 47);
            this.txtQuantidadePeca.MaxLength = 9;
            this.txtQuantidadePeca.Name = "txtQuantidadePeca";
            this.txtQuantidadePeca.Size = new System.Drawing.Size(55, 30);
            this.txtQuantidadePeca.TabIndex = 3;
            this.txtQuantidadePeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorPeca
            // 
            this.lblValorPeca.AutoSize = true;
            this.lblValorPeca.Location = new System.Drawing.Point(286, 25);
            this.lblValorPeca.Name = "lblValorPeca";
            this.lblValorPeca.Size = new System.Drawing.Size(78, 20);
            this.lblValorPeca.TabIndex = 4;
            this.lblValorPeca.Text = "Valor unit.:";
            // 
            // txtValorPeca
            // 
            this.txtValorPeca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtValorPeca.Location = new System.Drawing.Point(286, 47);
            this.txtValorPeca.Name = "txtValorPeca";
            this.txtValorPeca.Size = new System.Drawing.Size(89, 30);
            this.txtValorPeca.TabIndex = 5;
            this.txtValorPeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdicionarPeca
            // 
            this.btnAdicionarPeca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.btnAdicionarPeca.FlatAppearance.BorderSize = 0;
            this.btnAdicionarPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPeca.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarPeca.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarPeca.Location = new System.Drawing.Point(383, 45);
            this.btnAdicionarPeca.Name = "btnAdicionarPeca";
            this.btnAdicionarPeca.Size = new System.Drawing.Size(72, 34);
            this.btnAdicionarPeca.TabIndex = 6;
            this.btnAdicionarPeca.Text = "➕";
            this.btnAdicionarPeca.UseVisualStyleBackColor = false;
            this.btnAdicionarPeca.Click += new System.EventHandler(this.btnAdicionarPeca_Click);
            // 
            // dgvPecas
            // 
            this.dgvPecas.AllowUserToAddRows = false;
            this.dgvPecas.AllowUserToDeleteRows = false;
            this.dgvPecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPecas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPecas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.EnableHeadersVisualStyles = false;
            this.dgvPecas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPecas.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPecas.Location = new System.Drawing.Point(15, 88);
            this.dgvPecas.MultiSelect = false;
            this.dgvPecas.Name = "dgvPecas";
            this.dgvPecas.ReadOnly = true;
            this.dgvPecas.RowHeadersVisible = false;
            this.dgvPecas.RowHeadersWidth = 51;
            this.dgvPecas.RowTemplate.Height = 26;
            this.dgvPecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPecas.Size = new System.Drawing.Size(440, 162);
            this.dgvPecas.TabIndex = 7;
            // 
            // btnRemoverPeca
            // 
            this.btnRemoverPeca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoverPeca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnRemoverPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverPeca.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRemoverPeca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnRemoverPeca.Location = new System.Drawing.Point(15, 258);
            this.btnRemoverPeca.Name = "btnRemoverPeca";
            this.btnRemoverPeca.Size = new System.Drawing.Size(120, 32);
            this.btnRemoverPeca.TabIndex = 8;
            this.btnRemoverPeca.Text = "Remover";
            this.btnRemoverPeca.UseVisualStyleBackColor = false;
            this.btnRemoverPeca.Click += new System.EventHandler(this.btnRemoverPeca_Click);
            // 
            // lblSubtotalPecas
            // 
            this.lblSubtotalPecas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalPecas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblSubtotalPecas.Location = new System.Drawing.Point(255, 262);
            this.lblSubtotalPecas.Name = "lblSubtotalPecas";
            this.lblSubtotalPecas.Size = new System.Drawing.Size(200, 24);
            this.lblSubtotalPecas.TabIndex = 9;
            this.lblSubtotalPecas.Text = "Subtotal: R$ 0,00";
            this.lblSubtotalPecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 588);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(192, 37);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: R$ 0,00";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(20, 635);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "💾 Salvar OS";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciar.Enabled = false;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnIniciar.Location = new System.Drawing.Point(170, 635);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 40);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "▶ Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(70)))));
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(300, 635);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(130, 40);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "✔ Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelarOS
            // 
            this.btnCancelarOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancelarOS.Enabled = false;
            this.btnCancelarOS.FlatAppearance.BorderSize = 0;
            this.btnCancelarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOS.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancelarOS.ForeColor = System.Drawing.Color.White;
            this.btnCancelarOS.Location = new System.Drawing.Point(440, 635);
            this.btnCancelarOS.Name = "btnCancelarOS";
            this.btnCancelarOS.Size = new System.Drawing.Size(140, 40);
            this.btnCancelarOS.TabIndex = 8;
            this.btnCancelarOS.Text = "✖ Cancelar OS";
            this.btnCancelarOS.UseVisualStyleBackColor = false;
            this.btnCancelarOS.Click += new System.EventHandler(this.btnCancelarOS_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(860, 635);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 40);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 695);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelarOS);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpPecas);
            this.Controls.Add(this.grpServicos);
            this.Controls.Add(this.grpCabecalho);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ordem de Serviço - Oficina Master";
            this.Load += new System.EventHandler(this.FrmOrdemServico_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.grpCabecalho.ResumeLayout(false);
            this.grpCabecalho.PerformLayout();
            this.grpServicos.ResumeLayout(false);
            this.grpServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.grpPecas.ResumeLayout(false);
            this.grpPecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblStatusOS;
        private System.Windows.Forms.GroupBox grpCabecalho;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblDataAbertura;
        private System.Windows.Forms.TextBox txtDataAbertura;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.ComboBox cboVeiculo;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.GroupBox grpServicos;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.ComboBox cboServico;
        private System.Windows.Forms.Label lblValorServico;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.Button btnRemoverServico;
        private System.Windows.Forms.Label lblSubtotalServicos;
        private System.Windows.Forms.GroupBox grpPecas;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.ComboBox cboPeca;
        private System.Windows.Forms.Label lblQuantidadePeca;
        private System.Windows.Forms.TextBox txtQuantidadePeca;
        private System.Windows.Forms.Label lblValorPeca;
        private System.Windows.Forms.TextBox txtValorPeca;
        private System.Windows.Forms.Button btnAdicionarPeca;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.Button btnRemoverPeca;
        private System.Windows.Forms.Label lblSubtotalPecas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelarOS;
        private System.Windows.Forms.Button btnVoltar;
    }
}
