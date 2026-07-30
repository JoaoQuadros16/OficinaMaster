namespace ControleEstoqueWindowsForm
{
    partial class FrmProduto
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

        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();

            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();

            this.pnlTopo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(800, 90);
            this.pnlTopo.TabIndex = 0;
            this.pnlTopo.Controls.Add(this.lblSubTitulo);
            this.pnlTopo.Controls.Add(this.label1);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "🔧 Oficina Master";

            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubTitulo.Location = new System.Drawing.Point(32, 56);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(230, 19);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "Menu Principal — Controle de Estoque";

            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.button5);
            this.pnlMenu.Controls.Add(this.btnEditar);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Controls.Add(this.btnListar);
            this.pnlMenu.Controls.Add(this.btnCadastro);
            this.pnlMenu.Location = new System.Drawing.Point(280, 110);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 330);
            this.pnlMenu.TabIndex = 1;

            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(45, 120, 230);
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(35, 100, 205);
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(20, 20);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(200, 44);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "➕  Cadastrar Produto";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.button1_Click);

            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnListar.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.btnListar.Location = new System.Drawing.Point(20, 78);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(200, 44);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "📋  Listar Produto";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.button2_Click);

            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.btnAlterar.Location = new System.Drawing.Point(20, 136);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(200, 44);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "🔄  Alterar Estoque";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);

            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.btnEditar.Location = new System.Drawing.Point(20, 194);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 44);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "✏️  Editar Produto";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 220, 220);
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.button5.Location = new System.Drawing.Point(20, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "🗑️  Excluir Produto";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oficina Master - Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubTitulo;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button5;
    }
}