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

            SmtpClient client = new SmtpClient(Server, PortSend);
            client.Credentials = new NetworkCredential(From, Password);
            if (Chk)
            {
                client.EnableSsl = true;
            }
            MailMessage pismo = new MailMessage(From, To, Subject, Body);
            /*if (!string.IsNullOrEmpty(Attach))
            {
                Attachment att = new Attachment(@Attach);
                pismo.Attachments.Add(att);
            }*/
            try
            {
                
                client.Send(pismo);
                MessageBoxResult result = MessageBox.Show("Mail Send");
            }
            catch(Exception ex)
            {
                MessageBoxResult result = MessageBox.Show(ex.ToString());
            }
        }
    }
}
