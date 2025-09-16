using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioneSecondoGrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            do
            {
                Console.Clear();
                Console.Write("Inserisci il coefficiente a (Maggiore di 0): ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a <= 0);
        }
    }
}
