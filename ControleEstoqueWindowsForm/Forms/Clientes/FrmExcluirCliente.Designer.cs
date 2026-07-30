namespace ControleEstoqueWindowsForm
{
    partial class FrmExcluirCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.lblPlacaValor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVeiculoValor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmailValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefoneValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCpfValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.pnlTopo.Controls.Add(this.label1);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(460, 70);
            this.pnlTopo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "🗑️ Excluir Cliente";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAviso.Location = new System.Drawing.Point(30, 80);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(400, 20);
            this.lblAviso.TabIndex = 1;
            this.lblAviso.Text = "Tem certeza que deseja excluir este cliente?";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.lblPlacaValor);
            this.grpDados.Controls.Add(this.label6);
            this.grpDados.Controls.Add(this.lblVeiculoValor);
            this.grpDados.Controls.Add(this.label7);
            this.grpDados.Controls.Add(this.lblEmailValor);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.lblTelefoneValor);
            this.grpDados.Controls.Add(this.label4);
            this.grpDados.Controls.Add(this.lblCpfValor);
            this.grpDados.Controls.Add(this.label3);
            this.grpDados.Controls.Add(this.lblNomeValor);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDados.Location = new System.Drawing.Point(30, 115);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(400, 280);
            this.grpDados.TabIndex = 2;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNomeValor.Location = new System.Drawing.Point(120, 30);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(60, 21);
            this.lblNomeValor.TabIndex = 1;
            this.lblNomeValor.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // lblCpfValor
            // 
            this.lblCpfValor.AutoSize = true;
            this.lblCpfValor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCpfValor.Location = new System.Drawing.Point(120, 65);
            this.lblCpfValor.Name = "lblCpfValor";
            this.lblCpfValor.Size = new System.Drawing.Size(60, 21);
            this.lblCpfValor.TabIndex = 3;
            this.lblCpfValor.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // lblTelefoneValor
            // 
            this.lblTelefoneValor.AutoSize = true;
            this.lblTelefoneValor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTelefoneValor.Location = new System.Drawing.Point(120, 100);
            this.lblTelefoneValor.Name = "lblTelefoneValor";
            this.lblTelefoneValor.Size = new System.Drawing.Size(60, 21);
            this.lblTelefoneValor.TabIndex = 5;
            this.lblTelefoneValor.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // lblEmailValor
            // 
            this.lblEmailValor.AutoSize = true;
            this.lblEmailValor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEmailValor.Location = new System.Drawing.Point(120, 135);
            this.lblEmailValor.Name = "lblEmailValor";
            this.lblEmailValor.Size = new System.Drawing.Size(60, 21);
            this.lblEmailValor.TabIndex = 7;
            this.lblEmailValor.Text = "-";
            // 
            // label7 (Veículo)
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Veículo:";
            // 
            // lblVeiculoValor
            // 
            this.lblVeiculoValor.AutoSize = true;
            this.lblVeiculoValor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblVeiculoValor.Location = new System.Drawing.Point(120, 170);
            this.lblVeiculoValor.Name = "lblVeiculoValor";
            this.lblVeiculoValor.Size = new System.Drawing.Size(60, 21);
            this.lblVeiculoValor.TabIndex = 9;
            this.lblVeiculoValor.Text = "-";
            // 
            // label6 (Placa)
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Placa:";
            // 
            // lblPlacaValor
            // 
            this.lblPlacaValor.AutoSize = true;
            this.lblPlacaValor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPlacaValor.Location = new System.Drawing.Point(120, 205);
            this.lblPlacaValor.Name = "lblPlacaValor";
            this.lblPlacaValor.Size = new System.Drawing.Size(60, 21);
            this.lblPlacaValor.TabIndex = 11;
            this.lblPlacaValor.Text = "-";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(30, 415);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(160, 38);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "🗑️ Confirmar Exclusão";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.btnCancelar.Location = new System.Drawing.Point(210, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmExcluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 475);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExcluirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Cliente - Oficina Master";
            this.Load += new System.EventHandler(this.FrmExcluirCliente_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCpfValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTelefoneValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmailValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVeiculoValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlacaValor;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}