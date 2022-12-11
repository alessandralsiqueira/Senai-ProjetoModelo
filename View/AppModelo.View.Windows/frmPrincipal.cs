using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método criado para exibir dados do acesso no sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = frmLogin.SetNomeUsuario;
            lblInfoUsuario.Text = frmLogin.HoraLogin;
        }

        /// <summary>
        /// Menu criado para exibir o frmCadastroFuncionario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Menu criado para exibir o frmNacionalidades.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nacionalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Menu criado para exibir o frmNaturalidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naturalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Menu criado para exibir o frmListaFuncionario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmListaFuncionario();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Menu criado para exibir o frmRelatorios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmRelatorios();
            form.Show();
            this.Hide();
        }
        /// <summary>
        /// Evento criado para retornar ao frmPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmLogin();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Evento criado para fechar o frmPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
            Close();
        }
    }

}
