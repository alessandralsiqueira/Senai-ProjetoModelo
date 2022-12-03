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
    public partial class frmRelatorios : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public frmRelatorios()
        {
            InitializeComponent();
            dgvRelatorioFuncionarios.DataSource = _funcionarioController.ObterTodosFuncionarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
            form.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmRelatorios();
            Close();
        }
    }
}
