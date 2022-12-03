﻿
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
