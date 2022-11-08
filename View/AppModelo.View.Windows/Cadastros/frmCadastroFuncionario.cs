using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Crio a instância do Controllador
            var cepController = new ViaCepController();

            //Recebo os dados do metodos obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if(txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo.");
                return;
            }

            //verifica se digitou algum número
            foreach(var letra in txtNome.Text)
            {
                if(char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece estar errado.");
                    return;
                }
            } 
            errorProvider.Clear();
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            if(cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return ;
            }
            errorProvider.Clear();
             
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);
            if(emailEhValido is false)
            {
                errorProvider.SetError(txtEmail, "Email Inválido");
                return;
            }
            errorProvider.Clear();
        }

        //pega a data de hoje e acrescenta 1 dia
        private void txtDataNascimento_Validating(object sender, CancelEventArgs e)
        {
            var dataNascimento = DateTime.Parse(txtDataNascimento.Text);
            //DataTime.Now.AddDays(1);
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            var funController = new FuncionarioController();
            var dataNasc = Convert.ToDateTime(txtDataNascimento.Text);
            int numero = int.Parse(txtEnderecoNumero.Text);
            
            //Recebo os dados do metodo obter para o endereço
            var salvou = funController.SalvarCadastro(txtNome.Text, dataNasc, rbMasculino.Checked, txtCpf.Text, 1, 1, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text, numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text);
            var salvou = funController.SalvarCadastro(txtNome.Text, dataNasc, rbMasculino.Checked, txtCpf.Text, cmbNacionalidade, cmbNaturalidade, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text, numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text);

        }
    }
}
