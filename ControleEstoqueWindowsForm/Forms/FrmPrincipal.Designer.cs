namespace ControleEstoqueWindowsForm
{
    partial class FrmPrincipal
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

        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnOrdensServico = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.lblConteudoPlaceholder = new System.Windows.Forms.Label();
            this.pnlTopo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.pnlTopo.Controls.Add(this.btnSair);
            this.pnlTopo.Controls.Add(this.lblUsuarioLogado);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1000, 70);
            this.pnlTopo.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(890, 20);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 32);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(700, 27);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(157, 20);
            this.lblUsuarioLogado.TabIndex = 1;
            this.lblUsuarioLogado.Text = "Bem-vindo(a), Usuário";
            this.lblUsuarioLogado.Click += new System.EventHandler(this.lblUsuarioLogado_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🔧 Oficina Master";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(75)))));
            this.pnlMenu.Controls.Add(this.btnConfiguracoes);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnFinanceiro);
            this.pnlMenu.Controls.Add(this.btnServicos);
            this.pnlMenu.Controls.Add(this.btnEstoque);
            this.pnlMenu.Controls.Add(this.btnOrdensServico);
            this.pnlMenu.Controls.Add(this.btnVeiculos);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 70);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 580);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 400);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConfiguracoes.Size = new System.Drawing.Size(220, 50);
            this.btnConfiguracoes.TabIndex = 8;
            this.btnConfiguracoes.Text = "⚙️  Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 350);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(220, 50);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "🧑‍🔧  Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFinanceiro.ForeColor = System.Drawing.Color.White;
            this.btnFinanceiro.Location = new System.Drawing.Point(0, 300);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFinanceiro.Size = new System.Drawing.Size(220, 50);
            this.btnFinanceiro.TabIndex = 6;
            this.btnFinanceiro.Text = "💰  Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicos.FlatAppearance.BorderSize = 0;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnServicos.ForeColor = System.Drawing.Color.White;
            this.btnServicos.Location = new System.Drawing.Point(0, 250);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnServicos.Size = new System.Drawing.Size(220, 50);
            this.btnServicos.TabIndex = 5;
            this.btnServicos.Text = "🔧  Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicos.UseVisualStyleBackColor = false;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Location = new System.Drawing.Point(0, 200);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(220, 50);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "📦  Estoque / Peças";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnOrdensServico
            // 
            this.btnOrdensServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdensServico.FlatAppearance.BorderSize = 0;
            this.btnOrdensServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdensServico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOrdensServico.ForeColor = System.Drawing.Color.White;
            this.btnOrdensServico.Location = new System.Drawing.Point(0, 150);
            this.btnOrdensServico.Name = "btnOrdensServico";
            this.btnOrdensServico.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOrdensServico.Size = new System.Drawing.Size(220, 50);
            this.btnOrdensServico.TabIndex = 3;
            this.btnOrdensServico.Text = "📋  Ordens de Serviço";
            this.btnOrdensServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdensServico.UseVisualStyleBackColor = false;
            this.btnOrdensServico.Click += new System.EventHandler(this.btnOrdensServico_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeiculos.FlatAppearance.BorderSize = 0;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVeiculos.ForeColor = System.Drawing.Color.White;
            this.btnVeiculos.Location = new System.Drawing.Point(0, 100);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVeiculos.Size = new System.Drawing.Size(220, 50);
            this.btnVeiculos.TabIndex = 2;
            this.btnVeiculos.Text = "🚗  Veículos";
            this.btnVeiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeiculos.UseVisualStyleBackColor = false;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 50);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(220, 50);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "👤  Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "🏠  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlConteudo.Controls.Add(this.lblConteudoPlaceholder);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(220, 70);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(780, 580);
            this.pnlConteudo.TabIndex = 2;
            // 
            // lblConteudoPlaceholder
            // 
            this.lblConteudoPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConteudoPlaceholder.AutoSize = true;
            this.lblConteudoPlaceholder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblConteudoPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.lblConteudoPlaceholder.Location = new System.Drawing.Point(260, 270);
            this.lblConteudoPlaceholder.Name = "lblConteudoPlaceholder";
            this.lblConteudoPlaceholder.Size = new System.Drawing.Size(351, 28);
            this.lblConteudoPlaceholder.TabIndex = 0;
            this.lblConteudoPlaceholder.Text = "Selecione uma opção no menu ao lado";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oficina Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnSair;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnOrdensServico;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnConfiguracoes;

        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Label lblConteudoPlaceholder;
    }
}
