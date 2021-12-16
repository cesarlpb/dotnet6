using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MailValidator
{
    public class MailValidator
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new EmailNotProvidedException();
            }
            Regex regex = new Regex(@"^[\w0-9._%+-]+@([\w0-9.-]+\.)+[\w]{2,6}$");
            return regex.IsMatch(email);
        }
        public string IsSpam(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new EmailNotProvidedException();
            }
            List<string> dominiosSpam = new List<string>() { "estoesspam.com", "mispam.es", "goodspam.com" };
            return dominiosSpam.Any(d => email.Contains(d)) ? "SPAM" : "INBOX";
        }
    }
}
