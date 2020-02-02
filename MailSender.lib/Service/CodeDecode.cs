using System.Linq;

namespace MailSender.lib.Service
{
    public static class CodeDecode
    {
        public static string PassCodeDecode(this string Source, int key) => new string(Source.Select(c => (char)(c ^ key)).ToArray());
    }
}
