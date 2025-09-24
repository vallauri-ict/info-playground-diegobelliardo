using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Es14p51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double multa, costo;
            int giorni;
            bool isCorrect=false;


            Console.OutputEncoding = Encoding.UTF8; // Forza l'encoding della console a UTF8

            do
            {
                Console.Write("Inserisci l'ammontare della multa: ");
                if (double.TryParse(Console.ReadLine(), out multa))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && multa<=0)
                {
                    isCorrect = false;
                    Console.WriteLine("La multa deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);


            do
            {
                Console.Write("Inserisci il numero di giorni: ");
                if (int.TryParse(Console.ReadLine(), out giorni))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && giorni < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero dei giorni deve essere maggiore o uguale a 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            if (giorni > 14) costo = multa + (multa * 0.3);      // costo = multa * 1.3;
            else if (giorni > 7) costo = multa + (multa * 0.1);
            else costo = multa;

            Console.WriteLine("L'ammontare da pagare e pari a: " + costo + "€");
            Console.ReadKey();
        }
    }
}
