using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_RicercaSequenziale
{
    internal class Program
    {
        
        private static int RicercaSequenziale(string[] v, string nome)
        {
            int i = 0;

            // while (v[i]!=nome && i<v.Length)
            while (!(v[i]==nome || i==(v.Length-1)))
            {
                i++;
            }
            if (v[i] == nome)
            {
                return i;
            }
            else return -1;
        }
        static void Main(string[] args)
        {
            string[] v = new string[] 
                    { "Rossi", "Gallo", "Devirgilio", "Melandri", "Fabbri", "Chiera" };

            Console.WriteLine("Inserisci il nome da cercare: ");
            string nome = Console.ReadLine();

            int pos = RicercaSequenziale(v, nome);

            if (pos==-1)
            {
                Console.WriteLine($"Nome: {nome} NON presente!");
            }
            else
            {
                Console.WriteLine($"Nome: {nome} TROVATO in posizione: {pos}");
            }

            Console.ReadKey();
        }

    }
}
