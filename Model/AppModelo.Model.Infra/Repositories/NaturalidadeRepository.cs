using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        /// <summary>
        /// Este método público insere uma nova Naturalidade.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Insere a Naturalidade no banco de dados</returns>
        public bool Inserir(string descricao, bool status) 
        {
            var agora = DateTime.Now.ToString("u");

            var sql = $"INSERT INTO naturalidade (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}', '{agora}', '{agora}', '{status}')";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        /// <summary>
        /// Este método exibe a naturalidade cadastrada em lista.
        /// </summary>
        /// <returns>Mostrar a naturalidade cadastrada na forma de lista no DataGridView</returns>
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao, dataAlteracao, ativo FROM naturalidade ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado; 
        } 
       
        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = "SELECT id, descricao, dataAlteracao, ativo FROM naturalidade ORDER BY descricao ASC WHERE ativo = true";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado; 
        }
        /// <summary>
        /// Este método atualiza a naturalidade cadastrada.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>Atualiza a naturalidade no banco de dados</returns>
        public bool Atualizar(int id, string descricao)
        {
            var sql = $"UPDATE naturalidade SET descricao = ('{descricao}') WHERE id = ('{id}')";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        /// <summary>
        /// Este método apaga a naturalidade cadastrada.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Deleta a naturalidade no banco de dados</returns>
        public bool Remover (string descricao)
        {
            var sql = $"DELETE FROM naturalidade WHERE (descricao) = ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        } 

        public NaturalidadeEntity ObterPorDescricao(string descricao)
        {
            var sql = $"SELECT id, descricao FROM naturalidade WHERE descricao = '{descricao}'";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);

            return resultado; 
        }
    }
      
}
