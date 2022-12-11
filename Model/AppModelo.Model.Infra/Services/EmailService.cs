using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;


namespace AppModelo.Model.Infra.Services
{
    public class EmailService
    {
        /// <summary>
        /// Método público criado utilizando os parâmetros "nome, email, assunto, mensagem"; para envio de emails
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="assunto"></param>
        /// <param name="mensagem"></param>
        /// <returns>Método criado para envio de emails</returns>
        public bool EnviarEmail(string nome, string email,string assunto, string mensagem)
        {
            try
            {
                var mimeMensage = new MimeMessage();
                mimeMensage.From.Add(new MailboxAddress("Sistema Senai", "user_senai_temp@faceli.edu.br"));
                mimeMensage.To.Add(new MailboxAddress(nome, email));
                mimeMensage.Subject = assunto;

                mimeMensage.Body = new TextPart("html")
                {
                    Text = mensagem
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.Auto);

                    client.Authenticate("user_senai_temp@faceli.edu.br", "senai@2022");
                    client.Authenticate("welton.castoldi@docente.senai.br", "thjqhgtpctrhbugt");

                    client.Send(mimeMensage);
                    client.Disconnect(true); 
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           

        }
    }
}
