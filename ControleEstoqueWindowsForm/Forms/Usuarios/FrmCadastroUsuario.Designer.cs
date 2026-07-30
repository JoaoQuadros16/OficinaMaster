namespace ControleEstoqueWindowsForm
{

    partial class FrmCadastroUsuario
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
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpPerfil = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.rbFuncionario = new System.Windows.Forms.RadioButton();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.grpPerfil.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.pnlTopo.Controls.Add(this.lblSubTitulo);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(624, 70);
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
            this.lblSubTitulo.Size = new System.Drawing.Size(165, 23);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "Cadastro de Usuário";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(386, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🔧 Sistema de Gestão de Oficina";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grpPerfil);
            this.grpDados.Controls.Add(this.txtConfirmarSenha);
            this.grpDados.Controls.Add(this.lblConfirmarSenha);
            this.grpDados.Controls.Add(this.txtSenha);
            this.grpDados.Controls.Add(this.lblSenha);
            this.grpDados.Controls.Add(this.txtLogin);
            this.grpDados.Controls.Add(this.lblLogin);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.lblNome);
            this.grpDados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDados.Location = new System.Drawing.Point(20, 85);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(584, 343);
            this.grpDados.TabIndex = 1;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do Usuário";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(304, 170);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(260, 30);
            this.txtConfirmarSenha.TabIndex = 7;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(304, 152);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(119, 20);
            this.lblConfirmarSenha.TabIndex = 6;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSenha.Location = new System.Drawing.Point(20, 170);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(260, 30);
            this.txtSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(20, 152);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLogin.Location = new System.Drawing.Point(20, 110);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(544, 30);
            this.txtLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(20, 92);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 20);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.Location = new System.Drawing.Point(20, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(544, 30);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo";
            // 
            // grpPerfil
            // 
            this.grpPerfil.Controls.Add(this.chkAtivo);
            this.grpPerfil.Controls.Add(this.rbFuncionario);
            this.grpPerfil.Controls.Add(this.rbAdministrador);
            this.grpPerfil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpPerfil.Location = new System.Drawing.Point(20, 228);
            this.grpPerfil.Name = "grpPerfil";
            this.grpPerfil.Size = new System.Drawing.Size(544, 90);
            this.grpPerfil.TabIndex = 8;
            this.grpPerfil.TabStop = false;
            this.grpPerfil.Text = "Perfil";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAtivo.Location = new System.Drawing.Point(20, 60);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(134, 27);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "Usuário Ativo";
            // 
            // rbFuncionario
            // 
            this.rbFuncionario.AutoSize = true;
            this.rbFuncionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbFuncionario.Location = new System.Drawing.Point(180, 30);
            this.rbFuncionario.Name = "rbFuncionario";
            this.rbFuncionario.Size = new System.Drawing.Size(120, 27);
            this.rbFuncionario.TabIndex = 1;
            this.rbFuncionario.Text = "Funcionário";
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Checked = true;
            this.rbAdministrador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbAdministrador.Location = new System.Drawing.Point(20, 30);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(139, 27);
            this.rbAdministrador.TabIndex = 0;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRodape.Controls.Add(this.btnVoltar);
            this.pnlRodape.Controls.Add(this.btnLimpar);
            this.pnlRodape.Controls.Add(this.btnSalvar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 447);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(624, 70);
            this.pnlRodape.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnVoltar.Location = new System.Drawing.Point(484, 15);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 40);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "↩ Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnLimpar.Location = new System.Drawing.Point(354, 15);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 40);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "🧹 Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(224, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 40);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "💾 Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 517);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpPerfil.ResumeLayout(false);
            this.grpPerfil.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;

        private System.Windows.Forms.GroupBox grpPerfil;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.RadioButton rbFuncionario;
        private System.Windows.Forms.CheckBox chkAtivo;

        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}
