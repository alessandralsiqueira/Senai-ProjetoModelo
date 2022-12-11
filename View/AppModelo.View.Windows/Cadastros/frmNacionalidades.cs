using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        /// <summary>
        /// Instancia a classe NacionalidadeController em uma propriedade para utilizá-la onde necessário.
        /// </summary>
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        /// <summary>
        /// Instancia o método NacionalidadeController, para cadastrar uma nova Nacionalidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var controller = new NacionalidadeController();
            var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);
            if(salvou)
            {
                MessageBox.Show("Nacionalidade incluída com sucesso!");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados.");
            }
        }

        /// <summary>
        /// Instancia o método NacionalidadeController, para excluir uma Nacionalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var control = new NacionalidadeController();
            var removeu = _nacionalidadeController.Remover(txtDescricao.Text);
            if(removeu)
            {
                MessageBox.Show("Nacionalidade excluída com sucesso!");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao excluir no banco de dados.");
            }
        }

        /// <summary>
        /// Instancia o método NacionalidadeController, para atualizar uma Nacionalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var idAtual = int.Parse(txtId.Text); 
            var controller = new NacionalidadeController();
            var descricaoAtual = _nacionalidadeController.Atualizar(idAtual, txtDescricao.Text);           
        }

        /// <summary>
        /// Evento criado para retornar ao frmPrincipal.
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
        /// Evento criado para fechar o frmNacionalidades.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            Close();
        }
    }
}
