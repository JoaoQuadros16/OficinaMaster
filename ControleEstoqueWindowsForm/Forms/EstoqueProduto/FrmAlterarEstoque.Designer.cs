namespace ControleEstoqueWindowsForm
{
    partial class FrmAlterarEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesquisar = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlterarSaldo = new System.Windows.Forms.Button();
            this.rdmSaida = new System.Windows.Forms.RadioButton();
            this.rdmEntrada = new System.Windows.Forms.RadioButton();
            this.txtAlteracao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.pnlTopo.Controls.Add(this.lblSubTitulo);
            this.pnlTopo.Controls.Add(this.label1);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(820, 70);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubTitulo.Location = new System.Drawing.Point(22, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(166, 23);
            this.lblSubTitulo.TabIndex = 2;
            this.lblSubTitulo.Text = "Controle de Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alterar Estoque";
            // 
            // Pesquisar
            // 
            this.Pesquisar.AutoSize = true;
            this.Pesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pesquisar.Location = new System.Drawing.Point(30, 88);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(109, 20);
            this.Pesquisar.TabIndex = 3;
            this.Pesquisar.Text = "Buscar Produto";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisa.Location = new System.Drawing.Point(140, 84);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(340, 30);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 220);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlterarSaldo);
            this.groupBox1.Controls.Add(this.rdmSaida);
            this.groupBox1.Controls.Add(this.rdmEntrada);
            this.groupBox1.Controls.Add(this.txtAlteracao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(30, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto Selecionado";
            // 
            // btnAlterarSaldo
            // 
            this.btnAlterarSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.btnAlterarSaldo.FlatAppearance.BorderSize = 0;
            this.btnAlterarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSaldo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAlterarSaldo.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSaldo.Location = new System.Drawing.Point(590, 130);
            this.btnAlterarSaldo.Name = "btnAlterarSaldo";
            this.btnAlterarSaldo.Size = new System.Drawing.Size(140, 40);
            this.btnAlterarSaldo.TabIndex = 10;
            this.btnAlterarSaldo.Text = "Alterar Saldo";
            this.btnAlterarSaldo.UseVisualStyleBackColor = false;
            this.btnAlterarSaldo.Click += new System.EventHandler(this.btnAlterarSaldo_Click);
            // 
            // rdmSaida
            // 
            this.rdmSaida.AutoSize = true;
            this.rdmSaida.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rdmSaida.Location = new System.Drawing.Point(360, 89);
            this.rdmSaida.Name = "rdmSaida";
            this.rdmSaida.Size = new System.Drawing.Size(69, 25);
            this.rdmSaida.TabIndex = 9;
            this.rdmSaida.TabStop = true;
            this.rdmSaida.Text = "Saida";
            this.rdmSaida.UseVisualStyleBackColor = true;
            // 
            // rdmEntrada
            // 
            this.rdmEntrada.AutoSize = true;
            this.rdmEntrada.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rdmEntrada.Location = new System.Drawing.Point(260, 89);
            this.rdmEntrada.Name = "rdmEntrada";
            this.rdmEntrada.Size = new System.Drawing.Size(84, 25);
            this.rdmEntrada.TabIndex = 8;
            this.rdmEntrada.TabStop = true;
            this.rdmEntrada.Text = "Entrada";
            this.rdmEntrada.UseVisualStyleBackColor = true;
            // 
            // txtAlteracao
            // 
            this.txtAlteracao.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAlteracao.Location = new System.Drawing.Point(105, 87);
            this.txtAlteracao.Name = "txtAlteracao";
            this.txtAlteracao.Size = new System.Drawing.Size(130, 29);
            this.txtAlteracao.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantidade:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSaldo.Location = new System.Drawing.Point(590, 94);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(140, 29);
            this.txtSaldo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saldo atual:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNome.Location = new System.Drawing.Point(325, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(240, 29);
            this.txtNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCodigo.Location = new System.Drawing.Point(95, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(140, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo:";
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnVoltar);
            this.pnlRodape.Controls.Add(this.btnAtualizar);
            this.pnlRodape.Location = new System.Drawing.Point(30, 565);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(760, 50);
            this.pnlRodape.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnVoltar.Location = new System.Drawing.Point(630, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 40);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnAtualizar.Location = new System.Drawing.Point(500, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 40);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmAlterarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 640);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmAlterarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlterarEstoque";
            this.Load += new System.EventHandler(this.FrmAlterarEstoque_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubTitulo;

        private System.Windows.Forms.Label Pesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlteracao;
        private System.Windows.Forms.RadioButton rdmEntrada;
        private System.Windows.Forms.RadioButton rdmSaida;
        private System.Windows.Forms.Button btnAlterarSaldo;

        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}