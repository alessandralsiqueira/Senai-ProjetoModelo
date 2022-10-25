namespace AppModelo.View.Windows.Cadastros
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblEsqueciMinhaSenha = new System.Windows.Forms.Label();
            this.lblSuporteEContato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmailLogin.Location = new System.Drawing.Point(12, 57);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(249, 21);
            this.txtEmailLogin.TabIndex = 2;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSenhaLogin.Location = new System.Drawing.Point(12, 123);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(249, 21);
            this.txtSenhaLogin.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEntrar.Location = new System.Drawing.Point(12, 222);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(249, 25);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblEsqueciMinhaSenha
            // 
            this.lblEsqueciMinhaSenha.AutoSize = true;
            this.lblEsqueciMinhaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueciMinhaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEsqueciMinhaSenha.ForeColor = System.Drawing.Color.Gold;
            this.lblEsqueciMinhaSenha.Location = new System.Drawing.Point(135, 147);
            this.lblEsqueciMinhaSenha.Name = "lblEsqueciMinhaSenha";
            this.lblEsqueciMinhaSenha.Size = new System.Drawing.Size(126, 15);
            this.lblEsqueciMinhaSenha.TabIndex = 5;
            this.lblEsqueciMinhaSenha.Text = "Esqueci minha senha";
            this.lblEsqueciMinhaSenha.Click += new System.EventHandler(this.lblEsqueciMinhaSenha_Click);
            // 
            // lblSuporteEContato
            // 
            this.lblSuporteEContato.AutoSize = true;
            this.lblSuporteEContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblSuporteEContato.ForeColor = System.Drawing.Color.Gold;
            this.lblSuporteEContato.Location = new System.Drawing.Point(87, 284);
            this.lblSuporteEContato.Name = "lblSuporteEContato";
            this.lblSuporteEContato.Size = new System.Drawing.Size(93, 13);
            this.lblSuporteEContato.TabIndex = 6;
            this.lblSuporteEContato.Text = "Suporte e Contato";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(295, 306);
            this.Controls.Add(this.lblSuporteEContato);
            this.Controls.Add(this.lblEsqueciMinhaSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblEsqueciMinhaSenha;
        private System.Windows.Forms.Label lblSuporteEContato;
    }
}