using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Es22pag52
{
    internal class Program
    {
        static int nNumeriPari=0;
        static int cont = 2;
        const int NUMERI_PARI = 100;
        static void Main(string[] args)
        {
            do
            {
                if(cont % 2 == 0)
                {
                    nNumeriPari++;
                    Console.WriteLine($"Numero pari: {cont}");
                }
                cont++;
            } while (nNumeriPari < NUMERI_PARI);

            Console.ReadKey();
        }
    }
}
