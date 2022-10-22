using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNaturalidade;
        } 

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var controller = new NaturalidadeController();
            var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text.ToUpper());
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
    }
}
