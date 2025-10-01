using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Es18p51
{
    internal class Program
    {
        static int LeggiNumero(string messaggio)
        {
            bool isCorrect=false;
            int numero;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(),out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero Intero!!!");
                }
            } while (!isCorrect);

            return numero;
        }
        static void Main(string[] args)
        {
            int nHamburger, nCheesburger, nMilkshake;

            nHamburger = LeggiNumero("Dimmi quanti Hamburger vuoi: ");
            nCheesburger = LeggiNumero("Dimmi quanti Cheesburger vuoi: ");
            nMilkshake = LeggiNumero("Dimmi quanti Milkshake vuoi: ");

            double costoTotale = nHamburger * 3.5 + nCheesburger * 4.2 + nMilkshake * 1.8;
            Console.WriteLine($"La spesa totale è: {costoTotale}");

            Console.ReadKey();
        }
    }
}
