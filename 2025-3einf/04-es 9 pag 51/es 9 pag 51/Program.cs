using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_9_pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int UnGusto; 
            int DueGusti; 
            int amici;

            do {
                Console.Write("Quanti sono gli amici? ");
                amici = int.Parse(Console.ReadLine());
            } while (amici <= 0);

            Console.Write("Quanti gelati sono con un gusto? ");
            UnGusto = int.Parse(Console.ReadLine());

            Console.Write("Quanti gelati sono con due gusti? ");
            DueGusti=int.Parse(Console.ReadLine());

            Console.WriteLine("La spesa totale è "+((1.20 * UnGusto) + (2.00 * DueGusti)));
            
            Console.WriteLine("Programma terminato.");

            Console.ReadKey();
        }
    }
}
