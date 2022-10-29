using AppModelo.Controller.Segurança;
using AppModelo.Model.Domain.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent(); 
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            // 1 passo validar o email
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
            if(emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu email está errado.");
                txtEmail.Focus();
                return; 
            }

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if(usuarioEncontrado)
            {
                var form = new frmPrincipal(); 
                form.Show();
                this.Hide();

            } 
            else
            {
                MessageBox.Show("Usuário ou senha não encontrado!");
            }
        }

        private void lblEsqueciMinhaSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }

     
    }
}
