namespace ControleEstoqueWindowsForm
{
    partial class FrmOrdensServico
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAbertas = new System.Windows.Forms.Panel();
            this.lblQtdAbertas = new System.Windows.Forms.Label();
            this.lblTituloAbertas = new System.Windows.Forms.Label();
            this.pnlAndamento = new System.Windows.Forms.Panel();
            this.lblQtdAndamento = new System.Windows.Forms.Label();
            this.lblTituloAndamento = new System.Windows.Forms.Label();
            this.pnlFinalizadas = new System.Windows.Forms.Panel();
            this.lblQtdFinalizadas = new System.Windows.Forms.Label();
            this.lblTituloFinalizadas = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dgvOrdens = new System.Windows.Forms.DataGridView();
            this.btnNovaOS = new System.Windows.Forms.Button();
            this.btnAbrirOS = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.pnlAbertas.SuspendLayout();
            this.pnlAndamento.SuspendLayout();
            this.pnlFinalizadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1000, 70);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📋 Ordens de Serviço";
            // 
            // pnlAbertas
            // 
            this.pnlAbertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.pnlAbertas.Controls.Add(this.lblQtdAbertas);
            this.pnlAbertas.Controls.Add(this.lblTituloAbertas);
            this.pnlAbertas.Location = new System.Drawing.Point(30, 85);
            this.pnlAbertas.Name = "pnlAbertas";
            this.pnlAbertas.Size = new System.Drawing.Size(200, 62);
            this.pnlAbertas.TabIndex = 1;
            // 
            // lblQtdAbertas
            // 
            this.lblQtdAbertas.AutoSize = true;
            this.lblQtdAbertas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblQtdAbertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.lblQtdAbertas.Location = new System.Drawing.Point(12, 6);
            this.lblQtdAbertas.Name = "lblQtdAbertas";
            this.lblQtdAbertas.TabIndex = 0;
            this.lblQtdAbertas.Text = "0";
            // 
            // lblTituloAbertas
            // 
            this.lblTituloAbertas.AutoSize = true;
            this.lblTituloAbertas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloAbertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblTituloAbertas.Location = new System.Drawing.Point(14, 38);
            this.lblTituloAbertas.Name = "lblTituloAbertas";
            this.lblTituloAbertas.TabIndex = 1;
            this.lblTituloAbertas.Text = "Abertas";
            // 
            // pnlAndamento
            // 
            this.pnlAndamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.pnlAndamento.Controls.Add(this.lblQtdAndamento);
            this.pnlAndamento.Controls.Add(this.lblTituloAndamento);
            this.pnlAndamento.Location = new System.Drawing.Point(245, 85);
            this.pnlAndamento.Name = "pnlAndamento";
            this.pnlAndamento.Size = new System.Drawing.Size(200, 62);
            this.pnlAndamento.TabIndex = 2;
            // 
            // lblQtdAndamento
            // 
            this.lblQtdAndamento.AutoSize = true;
            this.lblQtdAndamento.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblQtdAndamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(130)))), ((int)(((byte)(20)))));
            this.lblQtdAndamento.Location = new System.Drawing.Point(12, 6);
            this.lblQtdAndamento.Name = "lblQtdAndamento";
            this.lblQtdAndamento.TabIndex = 0;
            this.lblQtdAndamento.Text = "0";
            // 
            // lblTituloAndamento
            // 
            this.lblTituloAndamento.AutoSize = true;
            this.lblTituloAndamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloAndamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblTituloAndamento.Location = new System.Drawing.Point(14, 38);
            this.lblTituloAndamento.Name = "lblTituloAndamento";
            this.lblTituloAndamento.TabIndex = 1;
            this.lblTituloAndamento.Text = "Em andamento";
            // 
            // pnlFinalizadas
            // 
            this.pnlFinalizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.pnlFinalizadas.Controls.Add(this.lblQtdFinalizadas);
            this.pnlFinalizadas.Controls.Add(this.lblTituloFinalizadas);
            this.pnlFinalizadas.Location = new System.Drawing.Point(460, 85);
            this.pnlFinalizadas.Name = "pnlFinalizadas";
            this.pnlFinalizadas.Size = new System.Drawing.Size(200, 62);
            this.pnlFinalizadas.TabIndex = 3;
            // 
            // lblQtdFinalizadas
            // 
            this.lblQtdFinalizadas.AutoSize = true;
            this.lblQtdFinalizadas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblQtdFinalizadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(70)))));
            this.lblQtdFinalizadas.Location = new System.Drawing.Point(12, 6);
            this.lblQtdFinalizadas.Name = "lblQtdFinalizadas";
            this.lblQtdFinalizadas.TabIndex = 0;
            this.lblQtdFinalizadas.Text = "0";
            // 
            // lblTituloFinalizadas
            // 
            this.lblTituloFinalizadas.AutoSize = true;
            this.lblTituloFinalizadas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloFinalizadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblTituloFinalizadas.Location = new System.Drawing.Point(14, 38);
            this.lblTituloFinalizadas.Name = "lblTituloFinalizadas";
            this.lblTituloFinalizadas.TabIndex = 1;
            this.lblTituloFinalizadas.Text = "Finalizadas";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPesquisa.Location = new System.Drawing.Point(30, 169);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.TabIndex = 4;
            this.lblPesquisa.Text = "Buscar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPesquisa.Location = new System.Drawing.Point(95, 165);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(260, 29);
            this.txtPesquisa.TabIndex = 5;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(375, 169);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboStatus.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Em andamento",
            "Finalizada",
            "Cancelada"});
            this.cboStatus.Location = new System.Drawing.Point(430, 165);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(150, 29);
            this.cboStatus.TabIndex = 7;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPeriodo.Location = new System.Drawing.Point(600, 169);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.TabIndex = 8;
            this.lblPeriodo.Text = "Período:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(665, 165);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(120, 29);
            this.dtpInicio.TabIndex = 9;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAte.Location = new System.Drawing.Point(792, 169);
            this.lblAte.Name = "lblAte";
            this.lblAte.TabIndex = 10;
            this.lblAte.Text = "até";
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(822, 165);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(120, 29);
            this.dtpFim.TabIndex = 11;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // dgvOrdens
            // 
            this.dgvOrdens.AllowUserToAddRows = false;
            this.dgvOrdens.AllowUserToDeleteRows = false;
            this.dgvOrdens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdens.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdens.EnableHeadersVisualStyles = false;
            this.dgvOrdens.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvOrdens.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvOrdens.Location = new System.Drawing.Point(30, 210);
            this.dgvOrdens.MultiSelect = false;
            this.dgvOrdens.Name = "dgvOrdens";
            this.dgvOrdens.ReadOnly = true;
            this.dgvOrdens.RowHeadersVisible = false;
            this.dgvOrdens.RowHeadersWidth = 51;
            this.dgvOrdens.RowTemplate.Height = 28;
            this.dgvOrdens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdens.Size = new System.Drawing.Size(940, 330);
            this.dgvOrdens.TabIndex = 12;
            this.dgvOrdens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdens_CellDoubleClick);
            // 
            // btnNovaOS
            // 
            this.btnNovaOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovaOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.btnNovaOS.FlatAppearance.BorderSize = 0;
            this.btnNovaOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaOS.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNovaOS.ForeColor = System.Drawing.Color.White;
            this.btnNovaOS.Location = new System.Drawing.Point(30, 555);
            this.btnNovaOS.Name = "btnNovaOS";
            this.btnNovaOS.Size = new System.Drawing.Size(140, 38);
            this.btnNovaOS.TabIndex = 13;
            this.btnNovaOS.Text = "➕ Nova OS";
            this.btnNovaOS.UseVisualStyleBackColor = false;
            this.btnNovaOS.Click += new System.EventHandler(this.btnNovaOS_Click);
            // 
            // btnAbrirOS
            // 
            this.btnAbrirOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirOS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnAbrirOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirOS.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnAbrirOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnAbrirOS.Location = new System.Drawing.Point(180, 555);
            this.btnAbrirOS.Name = "btnAbrirOS";
            this.btnAbrirOS.Size = new System.Drawing.Size(130, 38);
            this.btnAbrirOS.TabIndex = 14;
            this.btnAbrirOS.Text = "📂 Abrir OS";
            this.btnAbrirOS.UseVisualStyleBackColor = false;
            this.btnAbrirOS.Click += new System.EventHandler(this.btnAbrirOS_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRelatorio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnRelatorio.Location = new System.Drawing.Point(320, 555);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(130, 38);
            this.btnRelatorio.TabIndex = 15;
            this.btnRelatorio.Text = "🖨️ Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnAtualizar.Location = new System.Drawing.Point(780, 555);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 38);
            this.btnAtualizar.TabIndex = 16;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(880, 555);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 38);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmOrdensServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnAbrirOS);
            this.Controls.Add(this.btnNovaOS);
            this.Controls.Add(this.dgvOrdens);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.pnlFinalizadas);
            this.Controls.Add(this.pnlAndamento);
            this.Controls.Add(this.pnlAbertas);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 560);
            this.Name = "FrmOrdensServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordens de Serviço - Oficina Master";
            this.Load += new System.EventHandler(this.FrmOrdensServico_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlAbertas.ResumeLayout(false);
            this.pnlAbertas.PerformLayout();
            this.pnlAndamento.ResumeLayout(false);
            this.pnlAndamento.PerformLayout();
            this.pnlFinalizadas.ResumeLayout(false);
            this.pnlFinalizadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAbertas;
        private System.Windows.Forms.Label lblQtdAbertas;
        private System.Windows.Forms.Label lblTituloAbertas;
        private System.Windows.Forms.Panel pnlAndamento;
        private System.Windows.Forms.Label lblQtdAndamento;
        private System.Windows.Forms.Label lblTituloAndamento;
        private System.Windows.Forms.Panel pnlFinalizadas;
        private System.Windows.Forms.Label lblQtdFinalizadas;
        private System.Windows.Forms.Label lblTituloFinalizadas;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DataGridView dgvOrdens;
        private System.Windows.Forms.Button btnNovaOS;
        private System.Windows.Forms.Button btnAbrirOS;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;
    }
}
