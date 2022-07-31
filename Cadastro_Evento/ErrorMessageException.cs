using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Evento
{
    public class ErrorMessageException : Exception
    {
        public ErrorMessageException() { }

        public ErrorMessageException(string message)
            : base(message)
        { }

    }
}
