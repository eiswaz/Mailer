using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;
using MailSender.lib.Service;

namespace MailSender.lib.Data
{
    class Data
    {
        public static List<Servers> Servers { get; } = new List<Servers>
        {
            new Servers { Name = "Yandex", Address = "smtp.yandex.ru", SendPort=465, UsedSSL=true, Login = "", Password="Password".PassCodeDecode(5)},
            new Servers { Name = "Google SSL", Address = "smtp.gmail.com", SendPort=465, UsedSSL=true, Login = "", Password="Password".PassCodeDecode(5)},
            new Servers { Name = "Google TLS", Address = "smtp.gmail.com", SendPort=587, UsedSSL=false, Login = "", Password="Password".PassCodeDecode(5)},
            new Servers { Name = "Mail", Address = "smtp.mail.ru", SendPort=465, UsedSSL=true, Login = "", Password="Password".PassCodeDecode(5)},
        };
        public static List<Senders> Senders { get; } = new List<Senders>
        {
            new Senders { Name = "Пушкин", Email = "a.s@pishkin.ru"},
            new Senders { Name="Лермонтов", Email ="m.yu@lermantov.ru"},
            new Senders { Name="Стругацкие", Email="a.b@strigatskie.ru"},
        };
        public static List<Recepients> Recepients { get; } = new List<Recepients>
        {
            new Recepients { Name = "Пушкин", Email = "a.s@pishkin.ru"},
            new Recepients { Name="Лермонтов", Email ="m.yu@lermantov.ru"},
            new Recepients { Name="Стругацкие", Email="a.b@strigatskie.ru"},
        };
    }
}
