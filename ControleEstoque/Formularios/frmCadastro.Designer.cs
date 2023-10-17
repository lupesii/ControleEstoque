namespace ControleEstoque.Formularios
{
    partial class frmCadastro
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEmail.Location = new System.Drawing.Point(12, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(15, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblSenha.Location = new System.Drawing.Point(12, 83);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 19);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSenha.Location = new System.Drawing.Point(15, 111);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(184, 25);
            this.txtSenha.TabIndex = 5;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblConfSenha.Location = new System.Drawing.Point(11, 157);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(119, 19);
            this.lblConfSenha.TabIndex = 10;
            this.lblConfSenha.Text = "Confirmar senha:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfSenha.Location = new System.Drawing.Point(14, 185);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(185, 25);
            this.txtConfSenha.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnSair.Location = new System.Drawing.Point(137, 224);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 32);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnEntrar.Location = new System.Drawing.Point(16, 224);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(76, 32);
            this.btnEntrar.TabIndex = 11;
            this.btnEntrar.Text = "Cadastrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(211, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
    }
}