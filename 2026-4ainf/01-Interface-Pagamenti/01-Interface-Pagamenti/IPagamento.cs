using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface_Pagamenti
{
    internal interface IPagamento
    {
        void EffettuaPagamento(decimal importo);
    }
}
