using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        /// <summary>
        /// Instancia objeto do tipo funcionarioRepository enviamdo parametrod advindos do formulario frmCadastro
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="telefone_contato"></param>
        /// <param name="cep"></param>
        /// <param name="logradouro"></param>
        /// <param name="numero"></param>
        /// <param name="complemento"></param>
        /// <param name="bairro"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
        /// <param name="nacionalidade"></param>
        /// <param name="naturalidade"></param>
        /// <returns></returns>Retorna uma variavel que contem os parametros nrcessarios para a instanciação do metodo FuncionarioRepository
        public bool Cadastrar(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataNascimento, sexo, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidade, naturalidade);
            return resposta; 
        }

        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterFuncionarios();
            return (List<FuncionarioEntity>)resposta; 
        } 
    }
} 
