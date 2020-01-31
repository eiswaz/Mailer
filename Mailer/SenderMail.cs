using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Windows;

namespace Mailer
{
    class SenderMail
    {
        //private int port = 25, PrrtSmtps = 465, PortTls = 587;
        public static void Sender (string Server ,string From, string To, string Subject, string Body, int PortSend/*, string Attach, string login*/, SecureString Password, bool Chk)
        {
            using (var message = new MailMessage(From, To))
            {
                message.Subject = Subject;
                message.Body = Body;

                using (var client = new SmtpClient(Server, PortSend))
                {
                    client.EnableSsl = true;
                    string name = From.Split('@')[0].ToString();
                    client.Credentials = new NetworkCredential(name, Password);
                    client.Send(message);
                }
            }

            
        }
    }
}
