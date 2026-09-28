using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_M2E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcolatore s = new Calcolatore();

            Console.WriteLine($"La somma di 2 + 3 fa: {s.Somma(2, 3)}");
            Console.WriteLine($"La somma di 2,2 + 3,4 fa: {s.Somma(2.2, 3.4)}");
            Console.WriteLine($"La somma di 2 + 3 + 1 fa: {s.Somma(2, 3, 1)}");

            Console.ReadKey();
        }
    }
}
