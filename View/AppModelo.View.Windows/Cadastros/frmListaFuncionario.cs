using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmListaFuncionario : Form
    {
        /// <summary>
        /// Instancia a classe FuncionarioController em uma propriedade para utilizá-la onde necessário.
        /// </summary>
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public frmListaFuncionario()
        {
            InitializeComponent();
            var listaDeFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvFuncionario.DataSource = listaDeFuncionarios;

        }

        /// <summary>
        ///  Instancia o método FuncionarioController, para atualizar um funcionário cadastrado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var idAtual = int.Parse(txtId.Text);
            var controller = new FuncionarioController();
            var descricaoAtual = _funcionarioController.Atualizar(idAtual, txtNome.Text);
        }

        /// <summary>
        /// Instancia o método FuncionarioController, para excluir um funcionário cadastrado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        ///  Evento criado para retornar ao frmPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
            form.Show();
            this.Hide();
        }
        /// <summary>
        /// Evento criado para fechar o frmListaFuncionario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmListaFuncionario();
            Close();
        }
    }
}
