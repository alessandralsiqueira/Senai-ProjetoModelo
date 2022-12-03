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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = frmLogin.SetNomeUsuario;
            lblInfoUsuario.Text = frmLogin.HoraLogin;
        }
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
            this.Hide();
        }

        private void nacionalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
            this.Hide();
        }

        private void naturalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
            this.Hide();
        }

        private void listaDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmListaFuncionario();
            form.Show();
            this.Hide();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmRelatorios();
            form.Show();
            this.Hide();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmLogin();
            form.Show();
            this.Hide();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
            Close();
        }
    }

}
