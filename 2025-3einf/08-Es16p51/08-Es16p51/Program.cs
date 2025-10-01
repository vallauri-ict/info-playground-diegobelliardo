using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Es16p51
{
    internal class Program
    {
        static Random rnd = new Random();  //globale

        static int NumeroCasuale(int min, int max)
        {
            int val=rnd.Next(min, max);
            return val;
        }

        static void Main(string[] args)
        {
            int faccia1,faccia2;   // locale

            faccia1 = NumeroCasuale(1, 7);
            faccia2 = NumeroCasuale(1, 7);

            if (faccia1 == faccia2)
                Console.WriteLine($"Hai fatto coppia!\nN1: {faccia1} - N2: {faccia2}");
            else Console.WriteLine($"NON hai fatto coppia!\nN1: {faccia1} - N2: {faccia2}");

            Console.ReadKey();
        }



    }
}
