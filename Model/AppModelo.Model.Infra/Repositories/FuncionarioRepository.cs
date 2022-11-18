using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        /// <summary>
        /// esse método faz uma inserção no banco de dados com os parâmetros 
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
        /// <returns></returns>
        public bool Inserir(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionario (nomeCompleto, dataNascimento, sexo, email, telefone, telefoneContato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidades, naturalidade) VALUES ('{nome}', '{dataConvertida}', {sexo}, '{email}', '{telefone}', '{telefone_contato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {nacionalidade}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        public bool Atualizar()
        {
            return false;
        }
        public bool Remover()
        {
            return false;
        }
        public IEnumerable<FuncionarioEntity> ObterTodos()
        {
            var sql = "SELECT Id, Descricao FROM nacionalidades ORDER BY descricao ASC";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);
            return resultado;
        }
        public FuncionarioEntity ObterPorId()
        {
            return new FuncionarioEntity();
        }
    }
}
    

