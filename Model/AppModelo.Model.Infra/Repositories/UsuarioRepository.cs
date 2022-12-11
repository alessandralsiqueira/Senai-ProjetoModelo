using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class UsuarioRepository
    {
        /// <summary>
        /// Este método público faz uma busca no banco de dados com os parâmetros "usuario" e "senha".
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns>Faz uma busca com "usuario" e "senha" cadastrados no banco de dados</returns>
        public UsuarioEntity Obter(string usuario, string senha)
        {
            var sql = $"SELECT email,senha FROM usuarios WHERE email = '{usuario}' AND senha = '{senha}';";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado; 
        }

        /// <summary>
        /// Este método público faz uma busca no banco de dados com o parâmetro "email"
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Faz uma busca com o "email" cadastrado no banco de dados</returns>
        public UsuarioEntity ObterPorEmail(string email)
        {
            var sql = $"SELECT email, nome FROM usuarios WHERE email = '{email}';";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;
        }

        /// <summary>
        /// Este método público faz uma busca no banco de dados com o parâmetro "email" para encontrar
        /// usuario cadastrado para enviar link e criar uma nova senha
        /// </summary>
        /// <param name="email"></param>
        /// <param name="novaSenha"></param>
        /// <returns>Faz uma busca com o "email" cadastrado no banco de dados para enviar link e criar uma nova senha</returns>
        public bool AtualizarSenha(string email, string novaSenha) 
        {
            var sql = $"UPDATE usuarios SET senha = '{novaSenha} WHERE email = '{email}';";

            using IDbConnection conexaoBd = new MySqlConnection(DataBases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0; 
        }
    } 

}
