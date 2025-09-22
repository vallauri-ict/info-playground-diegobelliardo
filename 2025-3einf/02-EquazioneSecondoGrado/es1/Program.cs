using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;

            Console.WriteLine("Risolvere l'equazione di secondo grado ax^2 + bx + c = 0");
            do {
                Console.Write("Inserisci il valore di a: ");
                a = Convert.ToDouble(Console.ReadLine());
            } while (a == 0);

            Console.Write("Inserisci il valore di b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserisci il valore di c: ");
            double c = Convert.ToDouble(Console.ReadLine());


            double discriminante = b * b - 4 * a * c;


            if (discriminante > 0)
            {

                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"Le soluzioni reali sono: x1 = {x1} e x2 = {x2}");
            }
            else if (discriminante == 0)
            {

                double x = -b / (2 * a);
                Console.WriteLine($"L'unica soluzione reale è: x = {x}");
            }
            else
            {
                double parteReale = -b / (2 * a);
                double parteImmaginaria = Math.Sqrt(-discriminante) / (2 * a);
                Console.WriteLine($"Le soluzioni complesse sono: x1 = {parteReale} + {parteImmaginaria}");
            }

            Console.ReadKey();
        }
    }
}
