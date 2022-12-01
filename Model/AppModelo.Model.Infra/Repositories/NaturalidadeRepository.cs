﻿using AppModelo.Model.Domain.Entities;
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

        public bool Atualizar()
        {
            return false;
        }
        public bool Remover()
        {
            return false;
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
