using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface_Pagamenti
{
    internal class BonificoBancario : IPagamento
    {
        public void EffettuaPagamento(decimal importo)
        {
            Console.WriteLine("Pagamento effettuato tramite Bonifico di €" + importo);
        }
    }
}
