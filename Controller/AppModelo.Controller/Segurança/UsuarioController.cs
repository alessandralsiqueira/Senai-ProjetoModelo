using AppModelo.Model.Infra.Repositories;
using AppModelo.Model.Infra.Services;
using System;

namespace AppModelo.Controller.Segurança
{
    public class UsuarioController
    {
        /// <summary>
        /// Método público que efetua login do usuário utilizando usuário e senha.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns>Este método efetua login do usuário chamando do UsuarioRepository</returns>
        public bool EfetuarLogin(string usuario, string senha)
        {
            var repositorio = new UsuarioRepository();
            var usuarioEncontrado = repositorio.Obter(usuario, senha);

            if(usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        /// <summary>
        /// Método público que recupera senha do usuário utilizando o parâmetro email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Este método efetua a recuperação de senha do usuário chamando do UsuarioRepository</returns>
        public string RecuperarSenha(string email)
        {
            // 1 PASSO VERIFICAR SE É UM EMAIL VÁLIDO
            var repositorio = new UsuarioRepository();
            var usuario = repositorio.ObterPorEmail(email); 
            if(usuario is null) 
            {
                return "Usuário não foi encontrado"; 
            }
            // 2 PASSO GERAR UMA SENHA NOVA E GRAVAR NO BANCO DE DADOS
            var novaSenha = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            var atualizouSenha = repositorio.AtualizarSenha(email, novaSenha);
            if(atualizouSenha is false)
            {
                return "Programador fez errado "; 
            }
            // 3 PASSO MANDAR A NOVA SENHA PARA O EMAIL
            var emailService = new EmailService();
            var mensagemHtml = @"<p><b>Criamos uma nova senha para você.</b></p><p>Sua nova senha é: <b>" + novaSenha + "</b></p>";
            var emailEnviado = emailService.EnviarEmail(usuario.Nome, usuario.Email, "Recuperação de Senha", mensagemHtml);
            return ""; 
        }
    }
}
