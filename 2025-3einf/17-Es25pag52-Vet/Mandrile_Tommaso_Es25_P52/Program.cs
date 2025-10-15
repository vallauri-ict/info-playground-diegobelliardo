using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandrile_Tommaso_Es25_P52
{
    internal class Program
    {
        static double media = 0;
        static double nNumeri;


        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            bool isCorrect = false;
            int numero;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il prezzo deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return numero;
        }
        static void Main(string[] args)
        {

            nNumeri = LeggiNumero("Di quanti numeri vuoi fare la media?\n");
            for (int i = 1; i <= nNumeri; i++)
            {
                media += LeggiNumero($"Inserisci un numero {i}: ", false);
            }
            Console.WriteLine($"La media dei numeri è uguale a {media / nNumeri}");
            Console.ReadKey();

        }
    }
}
