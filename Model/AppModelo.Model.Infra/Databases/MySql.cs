using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.DataBases
{
    public static class MySql 
    {
        /// <summary>
        /// Classe destinada a fazer conexão com o banco de dados.
        /// </summary>
        /// <returns>Este método faz conexão com o banco de dados</returns>
        public static string ConectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline02;uid=wwonline02;password=aluno22senai;";
            return conn;
        }
    } 
}
