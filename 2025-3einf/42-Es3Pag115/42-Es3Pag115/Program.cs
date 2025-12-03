using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Es3Pag115
{
    internal class Program
    {
        /// <summary>
        /// Ricerca sequenziale per array disordinato e con ripetizioni
        /// </summary>
        /// <param name="vettore">Vettore su cui cercare</param>
        /// <param name="vettorePosizioni">Vettore delle posizioni</param>
        /// <param name="elemento">elemento da cercare</param>
        /// <returns>Quante volte compare nel vettore</returns>
        private static int RicercaSequenziale(string[] vettore, int[] vettorePosizioni, string elemento)
        {
            bool superato = false;
            int i = 0, j = 0;
            while (!superato && i < vettore.Length)
            {
                if (vettore[i] == elemento)
                {
                    vettorePosizioni[j] = i;
                    j++;
                }
                else
                {
                    if (elemento.CompareTo(vettore[i]) < 0)
                    {
                        superato = true;
                    }
                }
                i++;
            }
            return j;
        }
        /// <summary>
        /// Ordina in modo crescente 2 vettori; 
        /// a parità di elementi sul primo vettori verifica il secondo
        /// </summary>
        /// <param name="vettore1"></param>
        /// <param name="vettore2"></param>
        /// <param name="vettoreUnione">Vettore su cui eseguire l'ordinamento</param>
        /// <param name="inizio">Posizione iniziale della porzione di vettore da ordinare</param>
        /// <param name="fine">Posizione finale della porzione di vettore da ordinare</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void OrdinaVettori(string[] vettore1, string[] vettore2, string[] vettoreUnione, int inizio, int fine)
        {
            // Ordino vettoreUnione e contemporaneamente vado a sistemare anche vettore1 e vettore2

        }
        /// <summary>
        /// Unisce, ad uno ad uno, 2 vettori di stringhe in un terzo vettore di stringhe
        /// </summary>
        /// <param name="vettore1"></param>
        /// <param name="vettore2"></param>
        /// <param name="vettoreUnione"></param>
        private static void UnisciVettori(string[] vettore1, string[] vettore2, string[] vettoreUnione)
        {
            for (int i = 0; i < vettore1.Length; i++)
            {
                vettoreUnione[i] = vettore1[i] + " " + vettore2[i];
            }
        }
        static void Main(string[] args)
        {
            string[] cognomi = { "Barbieri", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            string[] nomi = { "Andrea", "Alessandro", "Anna", "Chiara", "Daniela", "Davide", "Elena", "Federico", "Filippo", "Francesca", "Giacomo", "Giorgia", "Luca", "Marco", "Martina", "Matteo", "Michele", "Sara", "Simone", "Valentina" };
            string[] classi = { "1A", "1A", "1A", "1A", "1A", "1A", "1A", "1A", "2A", "2A", "2A", "2A", "2A", "2A", "2A", "2A", "2A", "3A", "3A", "3A" };
            string[] cognomiNomi = new string[cognomi.Length];
            int[] vPos = new int[nomi.Length];

            Console.WriteLine("Inserisci la classe da cercare: ");
            string nome = Console.ReadLine().ToUpper();

            int nElementi = RicercaSequenziale(classi, vPos, nome);

            UnisciVettori(cognomi, nomi, cognomiNomi);
            OrdinaVettori(cognomi, nomi, cognomiNomi, vPos[0], nElementi + vPos[0]);
        }

    }
}
