using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es63_generalizzato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_STRINGS = 10;
            string[] vettore = new string[MAX_STRINGS];
            int count;

            vettore[0] = "Ciao";
            vettore[1] = "Cane";
            vettore[2] = "Casa";
            count = 3;  // Numero di stringhe inserite

            // Ordinamento con Selection Sort
            for (int i = 0; i < count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (IsFirstStringSmaller(vettore[j], vettore[minIndex]))
                    {
                        minIndex = j;
                    }
                }

                // Scambia le stringhe
                if (minIndex != i)
                {
                    string temp = vettore[i];
                    vettore[i] = vettore[minIndex];
                    vettore[minIndex] = temp;
                }
            }

            // Stampa delle stringhe ordinate
            Console.WriteLine("\nLe stringhe ordinate in ordine alfabetico crescente sono:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(vettore[i]);
            }

            Console.ReadKey();
        }

        // Metodo per confrontare due stringhe senza CompareTo
        static bool IsFirstStringSmaller(string a, string b)
        {
            int minLength = Math.Min(a.Length, b.Length);

            for (int i = 0; i < minLength; i++)
            {
                char charA = char.ToLower(a[i]); // Confronto case-insensitive
                char charB = char.ToLower(b[i]);

                if (charA < charB)
                {
                    return true;
                }
                else if (charA > charB)
                {
                    return false;
                }
            }

            // Se i primi caratteri sono uguali, confronta le lunghezze
            return a.Length < b.Length;
        }
    }
}
