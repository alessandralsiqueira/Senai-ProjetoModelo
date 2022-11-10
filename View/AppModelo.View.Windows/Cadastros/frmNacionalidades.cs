using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var idAtual = int.Parse(txtId.Text); 
            var controller = new NacionalidadeController();
            var descricaoAtual = _nacionalidadeController.Atualizar(idAtual, txtDescricao.Text);
            
        }
    }
}
