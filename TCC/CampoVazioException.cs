using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    internal class CampoVazioException : Exception
    {
        public CampoVazioException(string message)
            : base(message)
        {
        }
    }
}
