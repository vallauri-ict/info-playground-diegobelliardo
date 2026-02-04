using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Es15Pag115
{
    internal class Program
    {
        static string[] nominativi = new string[]
        {
            "Marco Rossi",
            "Luca Bianchi",
            "Andrea Verdi",
            "Paolo Neri",
            "Giovanni Gallo",
            "Matteo Conti",
            "Alessandro Fontana",
            "Davide Ricci",
            "Simone Moretti",
            "Federico Lombardi"
        };

        static int[] distanzeCm = new int[]
        {
            642,
            655,
            671,
            689,
            702,
            715,
            728,
            734,
            751,
            768
        };
        private static void StampaPodio()
        {
            int posPrimo=PosMax(int.MaxValue);
            int posSecondo = PosMax(distanzeCm[posPrimo]);
            int posTerzo = PosMax(distanzeCm[posSecondo]);

            // TODO Stampa
            Console.WriteLine($"Il primo è {nominativi[posPrimo]}" +
                $" ed ha saltato {distanzeCm[posPrimo]} cm");
            Console.WriteLine($"Il secondo è {nominativi[posSecondo]}" +
                $" ed ha saltato {distanzeCm[posSecondo]} cm");
            Console.WriteLine($"Il terzo è {nominativi[posTerzo]}" +
                $" ed ha saltato {distanzeCm[posTerzo]} cm");
        }

        private static int PosMax(int maxValue)
        {
            int posMax=0;

            for (int i = 0; i < distanzeCm.Length; i++)
            {
                if (distanzeCm[i] > distanzeCm[posMax] &&
                    distanzeCm[i] < maxValue)
                {
                    posMax = i;
                }
            }
            return posMax;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("I primi tre classificati sono:");

            StampaPodio();
        }

    }
}
