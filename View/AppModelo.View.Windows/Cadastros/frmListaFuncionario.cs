
using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
