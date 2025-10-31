using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interfacce01_Pagamenti
{
    internal class BonificoBancario : IPagamento
    {
        public void EffettuaPagamento(decimal importo)
        {
            Console.WriteLine("Pagamento effettuato tramite Bonifico di €" + importo);
        }
    }
}
