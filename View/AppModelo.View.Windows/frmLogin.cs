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
        //Crio uma variável global para colocar no txtEmail
        public static string SetNomeUsuario = "";
        public static string HoraLogin = "";
        public frmLogin()
        {
            InitializeComponent();
            txtEmail.Text = "alessandra@email.com";
            txtSenha.Text = "123456Al";

            HoraLogin = DateTime.Now.ToString("u");
        }

        private void btnLogar_Click_1(object sender, EventArgs e)
        {
            // 1 passo validar o email
            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "E-mail inválido!");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);

            if (usuarioEncontrado)
            {
                //Coloco o txtEmail dentro da variável global para passar para o frmPrincipal
                SetNomeUsuario = txtEmail.Text;

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

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            var form = new frmLogin();
            Close();
        }
    }
}
