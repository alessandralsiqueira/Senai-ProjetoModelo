using AppModelo.Controller.Segurança;
using AppModelo.Model.Domain.Validators;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método criado para recuperação de senha através do email cadastrado no banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;

            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu email está errado.");
                txtEmail.Focus();
                return;
            }
            var controller = new UsuarioController();
            var resultado = controller.RecuperarSenha(txtEmail.Text);
            MessageBox.Show(resultado);
        }

        /// <summary>
        /// Evento criado para fechar o frmRecuperarSenha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            Close();
        }

        /// <summary>
        /// Evento criado para retornar ao frmLogin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.FromArgb(13, 108, 139);
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
