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
        /// <summary>
        /// Este método atualiza o funcionário cadastrado.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <returns>Atualiza o funcionário cadastrado no banco de dados</returns>
        public bool Atualizar(int id, string nome)
        {
            var sql = $"UPDATE funcionario SET nomeCompleto = ('{nome}') WHERE id = ('{id}')";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        /// <summary>
        /// Este método exclui o funcionário cadastrado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Exclui o funcionário cadastrado no banco de dados</returns>
        public bool Remover(int id)
        {
            var sql = $"DELETE FROM funcionario WHERE (id) = ('{id}')";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        /// <summary>
        /// Este método exibe os funcionários cadastrados em lista.
        /// </summary>
        /// <returns>Mostrar os funcionarios cadastrados na forma de lista no DataGridView</returns>
        public IEnumerable<FuncionarioEntity> ObterFuncionarios()
        {
            var sql = $"SELECT * FROM funcionario ORDER BY id";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }
    }
}


