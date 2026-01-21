using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Es7pag115
{
    internal class Program
    {
        static string[] nomi = new string[]
        {
            "Alessandro",
            "Andrea",
            "Francesco",
            "Giovanni",
            "Luca",
            "Marco",
            "Matteo",
            "Paolo"
        };

        static string[] cognomi = new string[]
        {
            "Bianchi",
            "Conti",
            "Esposito",
            "Ferrari",
            "Gallo",
            "Romano",
            "Rossi",
            "Verdi"
        };

        static string[] nomi2 = new string[]
        {
            "Christian",
            "Daniele",
            "Davide",
            "Emanuele",
            "Francesco",
            "Gabriele",
            "Nicola",
            "Riccardo",
            "Simone",
            "Stefano"
        };

        static string[] cognomi2 = new string[]
        {
            "Caruso",
            "Conti",
            "Fabbri",
            "Lombardi",
            "Marchetti",
            "Moretti",
            "Pellegrini",
            "Rinaldi",
            "Serra",
            "Sorrentino"
        };

        private static void StampaVettore(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        private static void MergeBase(string[] a, string[] b, string[] c)
        {
            int i, j, k;

            i = j = k = 0;
            do
            {
                if (a[i].CompareTo(b[j]) > 0)
                {
                    c[k] = b[j];
                    j++;
                }
                else
                {
                    if ((a[i].CompareTo(b[j]) == 0))
                    {
                        c[k] = b[j];
                        j++;
                        i++;
                    }
                    else
                    {
                        c[k] = a[i];
                        i++;
                    }
                }

                k++;
            } while (i<a.Length && j<b.Length);

            if (i>=a.Length)
            {
                for (; j < b.Length; j++)
                {
                    c[k++] = b[j];
                }
            }
            else {
                for (; i < a.Length; i++)
                {
                    c[k++] = a[i];
                }
            }

        }
        static void Main(string[] args)
        {
            string[] nomiCompleto = new string[nomi.Length+nomi2.Length];
            string[] cognomiCompleto = new string[cognomi.Length + cognomi2.Length];

            MergeBase(nomi, nomi2, nomiCompleto);
            MergeBase(cognomi, cognomi2, cognomiCompleto);

            StampaVettore(nomi);
            Console.WriteLine("\n");
            StampaVettore(nomi2);
            Console.WriteLine("\n");
            StampaVettore(nomiCompleto);
            Console.WriteLine("\n------------------------------------------------");
            StampaVettore(cognomi);
            Console.WriteLine("\n");
            StampaVettore(cognomi2);
            Console.WriteLine("\n");
            StampaVettore(cognomiCompleto);
            Console.WriteLine("\n");
        }

    }
}
