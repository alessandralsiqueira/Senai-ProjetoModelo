using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {
        /// <summary>
        /// Inserir uma nova Nacionalidade.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Insere a Nacionalidade no banco de dados</returns>
        public bool Inserir(string descricao) 
        {
            //string interpolation $
            var sql = $"INSERT INTO nacionalidades (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0; 
        }

        /// <summary>
        /// Este método atualiza a nacionalidade cadastrada.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>Atualiza a Nacionalidade no banco de dados</returns>
        public bool Atualizar(int id, string descricao) 
        {
            var sql = $"UPDATE nacionalidades SET descricao = ('{descricao}') WHERE id = ('{id}')"; 
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0; 
        }

        /// <summary>
        /// Este método apaga a nacionalidade cadastrada.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Deleta a Nacionalidade no banco de dados</returns>
        public bool Remover(string descricao) 
        {
            var sql = $"DELETE FROM nacionalidades WHERE (descricao) = ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0; 
        }

        /// <summary>
        /// Este método exibe a nacionalidade cadastrada em lista.
        /// </summary>
        /// <returns>Mostrar a Nacionalidade cadastrada na forma de lista no DataGridView</returns>
        public IEnumerable<NacionalidadeEntity> ObterTodos() 
        {
            var sql = "SELECT id, descricao FROM nacionalidades ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);
            
            return resultado;

        } 
    }
}
