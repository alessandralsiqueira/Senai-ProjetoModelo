﻿using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class UsuarioRepository
    {
        public UsuarioEntity Obter(string usuario, string senha)
        {
            var sql = $"SELECT email,senha FROM usuarios WHERE email = '{usuario}' AND senha = '{senha}';";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado; 
        }
    } 
}