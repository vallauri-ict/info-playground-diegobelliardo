using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_RicercaSequenziale4
{
    internal class Program
    {
        /// <summary>
        /// Ricerca sequenziale per array ordinato e con ripetizioni
        /// </summary>
        /// <param name="vettore">Vettore su cui cercare</param>
        /// <param name="vettorePosizioni">Vettore delle posizioni</param>
        /// <param name="elemento">Elemento da cercare</param>
        /// <returns>Quante volte elemento compare nel vettore</returns>
        private static int RicercaSequenzialeCaso4(string[] vettore, int[] vettorePosizioni, string elemento)
        {
            bool superato=false;
            int i=0,j=0;

            while (i<vettore.Length && !superato)
            {
                if (vettore[i] == elemento)
                {
                    vettorePosizioni[j] = i;
                    j++;
                }
                else {
                    if (elemento.CompareTo(vettore[i])<0)
                    {
                        superato = true;
                    }
                }
                i++;
            }
            return j;
        }
        static void Main(string[] args)
        {
            string[] v = { "Bianchi", "Bruni", "Neri", "Neri", "Ratti", "Stoppa" };
            string elemento = "Neri";
            int[] vPos = new int[v.Length];

            int nElementi=RicercaSequenzialeCaso4(v, vPos, elemento);

            Console.WriteLine($"Sono stati trovati {nElementi} nomi uguali a {elemento} nelle posizioni:\n");

            for (int i = 0; i < nElementi; i++)
            {
                Console.Write(vPos[i] + " ");
            }
        }
    }
}
