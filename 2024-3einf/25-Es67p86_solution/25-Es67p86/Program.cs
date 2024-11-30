using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Es67p86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            
            Console.Write("Inserisci la prima stringa: ");
            s1=Console.ReadLine();
            Console.Write("Inserisci la stringa da ricercare: ");
            s2=Console.ReadLine();

            Console.WriteLine($"La stringa è stata trovata {Ricerca(s1, s2)} volte");

            Console.ReadKey();
        }

        private static int Ricerca(string s1, string s2)
        {
            int cont = 0,pos;

            do
            {
                pos = s1.IndexOf(s2);
                if (pos != -1)
                {
                    cont++;
                    s1=s1.Substring(pos+s2.Length);
                }
            } while (pos != -1);

            return cont;
        }
    }
}
