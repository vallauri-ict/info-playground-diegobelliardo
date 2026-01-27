using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Es10Pag115
{
    internal class Program
    {
        static string[] titoli = new string[]
        {
            "Il Signore degli Anelli: La Compagnia dell'Anello",
            "Inception",
            "Il Gladiatore",
            "Forrest Gump",
            "Matrix",
            "Titanic",
            "Interstellar",
            "Pulp Fiction",
            "La vita è bella",
            "Il Cavaliere Oscuro"
        };

        static int[] anniPubblicazione = new int[]
        {
            2001,
            2010,
            2000,
            1994,
            1999,
            1997,
            2014,
            1994,
            1997,
            2008
        };

        static string[] registi = new string[]
        {
            "Peter Jackson",
            "Christopher Nolan",
            "Ridley Scott",
            "Robert Zemeckis",
            "Lana e Lilly Wachowski",
            "James Cameron",
            "Christopher Nolan",
            "Quentin Tarantino",
            "Roberto Benigni",
            "Christopher Nolan"
        };

        /// <summary>
        /// Legge un numero da tastiera e lo restituisce, se valido.
        /// </summary>
        /// <param name="messaggio">Messaggio visualizzato</param>
        /// <param name="soloPositivi">[Opsionale] Se true accetta solo positivi</param>
        /// <param name="valMin">[Opsionale] Se diverso da 0 il numero inserito deve essere > di valMin</param>
        /// <returns>Numero inserito da tastiera</returns>
        static int LeggiNumero(string messaggio, bool soloPositivi = true, int valMin = 0)
        {
            int numero;
            bool isCorrect;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!isCorrect);
            return numero;
        }

        static void Main(string[] args)
        {
            Console.Write("Inserisci il regista: ");
            string regista=Console.ReadLine();

            int daAnno = LeggiNumero("Anno inizio pubblicazione: ");
            int aAnno = LeggiNumero("Anno fine pubblicazione: ");

        }
    }
}
