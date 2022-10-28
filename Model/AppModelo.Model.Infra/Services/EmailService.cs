using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppModelo.Model.Infra.Services
{
    public class EmailService
    {
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

                    client.Authenticate("user_senai_temp@faceli.edu.br", "senai@2022");

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
