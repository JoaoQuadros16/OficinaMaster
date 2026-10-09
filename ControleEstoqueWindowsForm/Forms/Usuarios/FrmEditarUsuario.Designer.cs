namespace ControleEstoqueWindowsForm
{
    partial class FrmEditarUsuario
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.grpSenha = new System.Windows.Forms.GroupBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblDicaSenha = new System.Windows.Forms.Label();
            this.grpPerfil = new System.Windows.Forms.GroupBox();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.rbFuncionario = new System.Windows.Forms.RadioButton();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.grpSenha.SuspendLayout();
            this.grpPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblSubTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(460, 80);
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
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "✏️ Editar usuário";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.lblSubTitulo.Location = new System.Drawing.Point(21, 48);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "Altere os dados e clique em Salvar";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.lblCodigo);
            this.grpDados.Controls.Add(this.txtCodigo);
            this.grpDados.Controls.Add(this.lblNome);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.lblLogin);
            this.grpDados.Controls.Add(this.txtLogin);
            this.grpDados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDados.Location = new System.Drawing.Point(20, 95);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(420, 165);
            this.grpDados.TabIndex = 1;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do usuário";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(15, 47);
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 30);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(110, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.Location = new System.Drawing.Point(110, 47);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 30);
            this.txtNome.TabIndex = 3;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(15, 90);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLogin.Location = new System.Drawing.Point(15, 112);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(390, 30);
            this.txtLogin.TabIndex = 5;
            // 
            // grpSenha
            // 
            this.grpSenha.Controls.Add(this.lblSenha);
            this.grpSenha.Controls.Add(this.txtSenha);
            this.grpSenha.Controls.Add(this.lblConfirmarSenha);
            this.grpSenha.Controls.Add(this.txtConfirmarSenha);
            this.grpSenha.Controls.Add(this.lblDicaSenha);
            this.grpSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpSenha.Location = new System.Drawing.Point(20, 270);
            this.grpSenha.Name = "grpSenha";
            this.grpSenha.Size = new System.Drawing.Size(420, 125);
            this.grpSenha.TabIndex = 2;
            this.grpSenha.TabStop = false;
            this.grpSenha.Text = "Alterar senha (opcional)";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(15, 25);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Nova senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSenha.Location = new System.Drawing.Point(15, 47);
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(185, 30);
            this.txtSenha.TabIndex = 1;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(220, 25);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.TabIndex = 2;
            this.lblConfirmarSenha.Text = "Confirmar nova senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(220, 47);
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(185, 30);
            this.txtConfirmarSenha.TabIndex = 3;
            // 
            // lblDicaSenha
            // 
            this.lblDicaSenha.AutoSize = true;
            this.lblDicaSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDicaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblDicaSenha.Location = new System.Drawing.Point(15, 90);
            this.lblDicaSenha.Name = "lblDicaSenha";
            this.lblDicaSenha.TabIndex = 4;
            this.lblDicaSenha.Text = "Deixe em branco para manter a senha atual.";
            // 
            // grpPerfil
            // 
            this.grpPerfil.Controls.Add(this.rbAdministrador);
            this.grpPerfil.Controls.Add(this.rbFuncionario);
            this.grpPerfil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpPerfil.Location = new System.Drawing.Point(20, 405);
            this.grpPerfil.Name = "grpPerfil";
            this.grpPerfil.Size = new System.Drawing.Size(420, 65);
            this.grpPerfil.TabIndex = 3;
            this.grpPerfil.TabStop = false;
            this.grpPerfil.Text = "Perfil de acesso";
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(15, 28);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.TabIndex = 0;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // rbFuncionario
            // 
            this.rbFuncionario.AutoSize = true;
            this.rbFuncionario.Location = new System.Drawing.Point(180, 28);
            this.rbFuncionario.Name = "rbFuncionario";
            this.rbFuncionario.TabIndex = 1;
            this.rbFuncionario.TabStop = true;
            this.rbFuncionario.Text = "Funcionário";
            this.rbFuncionario.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(25, 482);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.TabIndex = 4;
            this.chkAtivo.Text = "Usuário ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnCancelar.Location = new System.Drawing.Point(200, 515);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(320, 515);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 38);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "💾 Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmEditarUsuario
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(460, 570);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.grpPerfil);
            this.Controls.Add(this.grpSenha);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Usuário - Oficina Master";
            this.Load += new System.EventHandler(this.FrmEditarUsuario_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpSenha.ResumeLayout(false);
            this.grpSenha.PerformLayout();
            this.grpPerfil.ResumeLayout(false);
            this.grpPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox grpSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblDicaSenha;
        private System.Windows.Forms.GroupBox grpPerfil;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.RadioButton rbFuncionario;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}
