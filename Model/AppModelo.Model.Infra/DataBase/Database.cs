using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.DataBase
{
    public static class Database
    {
        public static string MySqlConection()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline02;uid=wwonline02;password=aluno22senai;";
            return conn;
        }
    }
}
