namespace AppModelo.View.Windows.Cadastros
{
    partial class frmRecuperarSenha
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
            this.txtRecuperarSenha = new System.Windows.Forms.TextBox();
            this.btnRecuperarSenha = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperar Senha";
            // 
            // txtRecuperarSenha
            // 
            this.txtRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecuperarSenha.Location = new System.Drawing.Point(23, 80);
            this.txtRecuperarSenha.Name = "txtRecuperarSenha";
            this.txtRecuperarSenha.Size = new System.Drawing.Size(180, 22);
            this.txtRecuperarSenha.TabIndex = 1;
            this.txtRecuperarSenha.Tag = "Digite seu email";
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRecuperarSenha.Location = new System.Drawing.Point(23, 126);
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Size = new System.Drawing.Size(180, 23);
            this.btnRecuperarSenha.TabIndex = 2;
            this.btnRecuperarSenha.Text = "RECUPERAR ACESSO";
            this.btnRecuperarSenha.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(23, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(231, 233);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRecuperarSenha);
            this.Controls.Add(this.txtRecuperarSenha);
            this.Controls.Add(this.label1);
            this.Name = "frmRecuperarSenha";
            this.Text = "frmRecuperarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecuperarSenha;
        private System.Windows.Forms.Button btnRecuperarSenha;
        private System.Windows.Forms.Button btnCancelar;
    }
}