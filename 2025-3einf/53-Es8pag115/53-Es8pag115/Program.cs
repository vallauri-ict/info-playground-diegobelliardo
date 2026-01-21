using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Es8pag115
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
            "Federico",
            "Gabriele",
            "Nicola",
            "Riccardo",
            "Simone",
            "Stefano"
        };

        static string[] cognomi2 = new string[]
        {
            "Caruso",
            "Correndo",
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
        private static void MergeTappo(string[] a, string[] b, string[] c)
        {
            int i, j;

            i = j = 0;
            Array.Resize(ref a, a.Length+1);
            Array.Resize(ref b, b.Length+1);

            a[a.Length-1] = "Zz";
            b[b.Length-1] = "Zz";

            for (int k = 0; k < a.Length+b.Length-2; k++)
            {
                if (a[i].CompareTo(b[j]) > 0)
                {
                    c[k++] = b[j++];
                }
                else c[k++] = a[i++];
            }
        }
        static void Main(string[] args)
        {
            string[] nomiCompleto = new string[nomi.Length + nomi2.Length];
            string[] cognomiCompleto = new string[cognomi.Length + cognomi2.Length];

            MergeTappo(nomi, nomi2, nomiCompleto);
            MergeTappo(cognomi, cognomi2, cognomiCompleto);



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
