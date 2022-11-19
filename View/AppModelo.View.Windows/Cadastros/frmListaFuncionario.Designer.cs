namespace AppModelo.View.Windows.Cadastros
{
    partial class frmListaFuncionario
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
            this.gvFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gvFuncionario
            // 
            this.gvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFuncionario.Location = new System.Drawing.Point(24, 12);
            this.gvFuncionario.Name = "gvFuncionario";
            this.gvFuncionario.Size = new System.Drawing.Size(531, 374);
            this.gvFuncionario.TabIndex = 0;
            // 
            // frmListaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.gvFuncionario);
            this.Name = "frmListaFuncionario";
            this.Text = "frmListaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.gvFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFuncionario;
    }
}