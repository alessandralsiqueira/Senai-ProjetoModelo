using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        /// <summary>
        /// Instancia a classe NaturalidadeController em uma propriedade para utilizá-la onde necessário.
        /// </summary>
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();

            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNaturalidade;
        }

        /// <summary>
        /// Instancia o método NaturalidadeController, para cadastrar uma nova Naturalidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);
            if (temNumero)
            {
                errorProvider1.SetError(txtDescricao, "Naturalidade não tem número.");
                txtDescricao.Focus();
                return; 
            }
            var controller = new NaturalidadeController();
            var descricaoMauiscula = txtDescricao.Text.ToUpper();

            var salvou = controller.Cadastrar(descricaoMauiscula, chkStatus.Checked);
            if (salvou)
            {
                MessageBox.Show("Naturalidade incluída com sucesso!");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados.");
            }
        }

        /// <summary>
        /// Instancia o método NaturalidadeController, para atualizar uma Naturalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var idAtual = int.Parse(txtId.Text);
            var controller = new NaturalidadeController();
            var descricaoAtual = _naturalidadeController.Atualizar(idAtual, txtDescricao.Text);
        }

        /// <summary>
        /// Instancia o método NaturalidadeController, para excluir uma Naturalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var control = new NaturalidadeController();
            var removeu = _naturalidadeController.Remover(txtDescricao.Text);
            if (removeu)
            {
                MessageBox.Show("Naturalidade excluída com sucesso!");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao excluir no banco de dados.");
            }
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
        /// Evento criado para fechar o frmNaturalidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            Close();
        }     
    }
}
