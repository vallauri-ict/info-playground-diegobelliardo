using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_EsFuzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            do
            {
                scelta = visualizzaMenu();
                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Ciao ciao...");
                        break;
                    case 1:
                        Console.WriteLine("Caso 1");
                        break;
                    case 2:
                        Console.WriteLine("Caso 2");
                        break;
                    default:
                        Console.WriteLine("Scelta non disponibile!");
                        break;
                }
                Console.ReadKey();
            }
            while (scelta != 0);
        }

        private static int visualizzaMenu()
        {
            int scelta;
            Console.Clear();
            Console.WriteLine("******  FUSIONE DI VETTORI  ******");
            Console.WriteLine("1) Metodo Base");
            Console.WriteLine("2) Merge con Tappo");
            Console.WriteLine("0) ESCI");
            Console.WriteLine("\nScelta > ");
            while (!int.TryParse(Console.ReadLine(), out scelta));

            return scelta;
        }
    }
}
