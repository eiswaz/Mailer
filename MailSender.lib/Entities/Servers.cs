using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    public class Servers
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool UsedSSL { get; set; }
        public int SendPort { get; set; }
    }
}
