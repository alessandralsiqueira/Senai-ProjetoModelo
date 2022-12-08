
using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmListaFuncionario : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public frmListaFuncionario()
        {
            InitializeComponent();
            var listaDeFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvFuncionario.DataSource = listaDeFuncionarios;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var idAtual = int.Parse(txtId.Text);
            var controller = new FuncionarioController();
            var descricaoAtual = _funcionarioController.Atualizar(idAtual, txtNome.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var converter = int.Parse(txtId.Text);
            var control = new FuncionarioController();
            var removeu = _funcionarioController.Remover(converter);
            if (removeu)
            {
                MessageBox.Show("Funcionário excluído com sucesso!");
                txtNome.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao excluir no banco de dados.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
            form.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmListaFuncionario();
            Close();
        }
    }
}
