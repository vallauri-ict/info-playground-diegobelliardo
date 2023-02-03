using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ControlloPersonalizzato
{
    public class ErrorEventArgs:EventArgs
    {
        public string ErrorMessage { get; }

        public ErrorEventArgs(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
