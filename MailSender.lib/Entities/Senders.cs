using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    public class Senders
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public override string ToString() => $"{Name}:{Email}";
    }
}
