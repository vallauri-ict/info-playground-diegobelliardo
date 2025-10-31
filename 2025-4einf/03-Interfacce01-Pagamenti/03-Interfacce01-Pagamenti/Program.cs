using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interfacce01_Pagamenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BonificoBancario b = new BonificoBancario();
            PayPal p = new PayPal();
            CartaDiCredito c = new CartaDiCredito();

            Console.OutputEncoding = Encoding.UTF8;
            
            b.EffettuaPagamento(127.3m);
            p.EffettuaPagamento(27.5m);
            c.EffettuaPagamento(27.0m);

            Console.ReadKey();
        }
    }
}
