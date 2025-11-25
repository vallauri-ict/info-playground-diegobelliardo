using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_RicercaSequenziale2
{
    internal class Program
    {
        /// <summary>
        /// Ricerca sequenziale per array disordinato e con ripetizioni
        /// </summary>
        /// <param name="vettore">Vettore su cui cercare</param>
        /// <param name="vettorePosizioni">Vettore delle posizioni</param>
        /// <param name="elemento">Elemento da cercare</param>
        /// <returns>Quante volte elemento compare nel vettore</returns>
        private static int RicercaSequenziale(string[] vettore, int[] vettorePosizioni, string elemento)
        {
            int nElementi = 0;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i]==elemento)
                {
                    vettorePosizioni[nElementi] = i;
                    nElementi++;
                }
            }

            return nElementi;
        }
        static void Main(string[] args)
        {
            string[] v = new string[]
                    { "Rossi", "Gallo", "Rossi", "Melandri", "Gallo", "Chiera", "Gallo" };
            int[] vPos = new int[v.Length];

            Console.Write("Inserisci il nome da cercare: ");
            string nome = Console.ReadLine();

            int nElementi = RicercaSequenziale(v, vPos, nome);
            if ( nElementi == 0)
            {
                Console.WriteLine($"Nome: {nome} NON presente!");
            }
            else
            {
                Console.WriteLine($"Nome: {nome} trovato nelle seguenti posizioni:\n");
                for (int i = 0; i < nElementi; i++)
                {
                    Console.Write(vPos[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
