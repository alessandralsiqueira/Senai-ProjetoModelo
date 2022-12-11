using AppModelo.Controller.Segurança;
using AppModelo.Model.Domain.Validators;
using System;
using System.Drawing;
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

        /// <summary>
        /// Método criado para login do usuário através da verificação de email e senha já cadastrados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Chama o frmRecuperarSenha para o usuário executar a recuperação de senha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblEsqueciMinhaSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Evento criado para fechar o frmLogin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            var form = new frmLogin();
            Close();
        }

        private void btnFechar_MouseHover(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(170, 57, 57);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.White;
        }
    }
}
