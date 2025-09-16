using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BollettaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroScatti;
            double costo;

            do
            {
                Console.Clear();
                Console.Write("Inserisci il numero di scatti (Maggiore di 0): ");
                numeroScatti = Convert.ToInt32(Console.ReadLine());
            } while (numeroScatti <= 0);

            if (numeroScatti <= 30)
            {
                costo = (numeroScatti * 0.2) + 2.5;
            }
            else if (numeroScatti > 30 && numeroScatti <= 100)
            {
                costo = 6 + (numeroScatti - 30) * 0.15 + 2.5;
            }
            else
            {
                costo = 16.5 + (numeroScatti - 100) * 0.1 + 2.5;
            }
            Console.WriteLine("Costo totale: " + costo);

            Console.ReadKey();
        }
    }
}
