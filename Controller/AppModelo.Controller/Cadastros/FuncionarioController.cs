using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        /// <summary>
        /// Instancia objeto do tipo funcionarioRepository enviando parâmetros advindos do formulário frmCadastro.
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
        /// <returns>Retorna uma variável que contém os parâmetros necessários para a instanciação do método Inserir no FuncionarioRepository</returns>
        public bool Cadastrar(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataNascimento, sexo, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidade, naturalidade);
            return resposta; 
        }

        /// <summary>
        /// List - Instancia uma List FuncionarioEntity e busca o repositório onde se encontram as informações.
        /// </summary>
        /// <returns>Chama a lista que se encontra registrada no banco de dados e faz uma lista de todos os funcionários</returns>
        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterFuncionarios();
            return (List<FuncionarioEntity>)resposta; 
        }

        /// <summary>
        /// Atualiza o cadastro de um funcionário no FuncionarioRepository
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <returns>Atualiza o cadastro de um funcionário no banco de dados</returns>
        public bool Atualizar(int id, string nome)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Atualizar(id, nome);
            return resposta;
        }

        /// <summary>
        /// Exclui o cadastro de um funcionário no FuncionarioRepository
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Exclui o cadastro de um funcionário no banco de dados</returns>
        public bool Remover(int id)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Remover(id);
            return resposta;
        }
    }
} 
