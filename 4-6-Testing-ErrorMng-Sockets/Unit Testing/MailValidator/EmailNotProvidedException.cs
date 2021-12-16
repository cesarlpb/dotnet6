using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailValidator
{
public class EmailNotProvidedException : Exception
    {
        public override string Message => "El email no puede estar en blanco.";
    }
}
