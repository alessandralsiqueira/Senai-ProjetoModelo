using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        public bool Inserir(string descricao)
        {
            var sql = $"INSERT INTO naturalidade (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0; 
        } 
        public bool Selecionar() 
        {
            var sql = "SELECT id, descricao FROM naturalidade ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());
        }
        public bool Atualizar()
        {
            return false;
        }
        public bool Remover()
        {
            return false;
        }

    }
}
