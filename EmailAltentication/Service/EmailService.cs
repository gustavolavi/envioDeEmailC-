using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace EmailAltentication.Service
{
    public class EmailService
    {
        public void EnviarConfirmacaoPorEmail(string email, int id)
        {
            var body = string.Format("Clique no link para ativar: http://localhost:49482/Home/ativar/{0}", id);

            EnviarEmail(email, "Corfirmar email", body);
        }

        public void ComfirmacaoDeEmailConcluida(string email) {
            EnviarEmail(email, "Confimação Concluida", "Obrigado por fazer parte de nosso site");
        }


        public void EnviarEmail(string email,string title,string body)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress(email));
            message.From = new MailAddress("gustavolaviolasanches@hotmail.com");
            message.Subject = title;
            message.Body = body;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "test@hotmail.com",
                    Password = "servise"
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }

        }

    }
}
