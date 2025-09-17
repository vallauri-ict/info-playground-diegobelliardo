using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Parchimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oraI, oraF, numOre;

            do
            {
                Console.Write("Inserire l'ora di ingresso: ");
                oraI = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserire l'ora di uscita: ");
                oraF = Convert.ToInt32(Console.ReadLine());

            } while (oraI < 0 || oraF < 0);

            numOre = oraF - oraI;

            if (numOre == 1)
            {
                Console.WriteLine("Costo: 4€");
            }
            else
            {
                if (numOre <= 5)
                {
                    Console.WriteLine("Costo: " + (4 + 3 * (numOre - 1)));
                }
                else Console.WriteLine("Costo: " + (4 + 3 * 4 + 2 * (numOre - 5)));
            }

            Console.ReadKey();
        }
    }
}
