using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro.exceptions
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string message)
            : base(message)
        {
        }
    }
}
