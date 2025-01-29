using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _35_EsFuzione
{
    internal class Program
    {
        static string[] a = new string[]
           {
                "Marco", "Luca", "Giovanni", "Alessandro", "Francesco",
                "Matteo", "Andrea", "Roberto", "Giuseppe", "Daniele",
                "Davide", "Simone", "Stefano", "Antonio", "Giulio",
                "Federico", "Paolo", "Leonardo", "Giorgio", "Salvatore"
           };

        static string[] b = new string[]
        {
                "Rossi", "Bianchi", "Verdi", "Neri", "Gialli",
                "Marini", "Romano", "Esposito", "Ferrari", "Conti",
                "Giordano", "Simone", "Leonardo", "Sorrentino", "Barbieri",
                "Corsi", "De Luca", "Vitali", "Pellegrini", "Santoro"
        };
        static void Main(string[] args)
        {
            // ordino i vettori perché non lo sono
            Array.Sort(a);
            Array.Sort(b);

            int scelta;
            do
            {
                scelta = visualizzaMenu();
                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Ciao ciao...");
                        break;
                    case 1:
                        Console.WriteLine("Caso 1");
                        FusioneBase();
                        break;
                    case 2:
                        Console.WriteLine("Caso 2");
                        FusioneTappo();
                        break;
                    default:
                        Console.WriteLine("Scelta non disponibile!");
                        break;
                }
                Console.ReadKey();
            }
            while (scelta != 0);
        }

        private static void FusioneTappo()
        {
            StampaVet(a, "Vettore a:");
            StampaVet(b, "Vettore b:");

            const string TAPPO = "zzz";

            Array.Resize(ref a, a.Length + 1);
            Array.Resize(ref b, b.Length + 1);

            a[a.Length-1] = b[b.Length-1] = TAPPO;

            string[] c = new string[a.Length + b.Length];

            int i = 0; int j = 0; 

            for (int k = 0; k < c.Length; k++)
            {
                if (a[i].CompareTo(b[j]) > 0)
                {
                    c[k] = b[j];
                    j++;
                }
                else
                {
                    c[k] = a[i];
                    i++;
                }
            }

            StampaVet(c, "Vettore C: ");
        }

        private static void FusioneBase()
        {
            StampaVet(a, "Vettore a:");
            StampaVet(b, "Vettore b:");

            string[] c = new string[a.Length+b.Length];

            int i = 0; int j = 0; int k = 0;
            do
            {
                if (a[i].CompareTo(b[j]) > 0)
                {
                    c[k] = b[j];
                    j++;
                }
                else
                {
                    if (a[i].CompareTo(b[j]) == 0)
                    {
                        c[k] = a[i];
                        i++; j++;
                    }
                    else
                    {
                        c[k] = a[i];
                        i++;
                    }
                }
                k++;
            } 
//            while(k< a.Length + b.Length)   NON FUNZIONA CON ELEMENTI UNGAULI
//                                            NEI VETTORI a E b
            while((i<a.Length) && (j<b.Length));

            if (i>=a.Length)
            {
                for (int h = j; h < b.Length; h++)
                {
                    c[k] = b[h];
                    k++;
                }
            }
            else
            {
                for (int h = i; h < a.Length; h++)
                {
                    c[k] = a[h];
                    k++;
                }
            }
            Array.Resize(ref c, k);
            StampaVet(c, "\nVettore c: ");
        }

        private static void StampaVet(string[] a, string message)
        {
            Console.WriteLine(message);
            a=new string[3];
            for (int i = 0; i < a.Length; i++) { 
                Console.Write(a[i].PadLeft(12));
                if ((i + 1) % 6 == 0) { 
                    Console.WriteLine();
                }
            }
            Console.WriteLine() ;   
        }

        private static int visualizzaMenu()
        {
            int scelta;
            Console.Clear();
            Console.WriteLine("******  FUSIONE DI VETTORI  ******");
            Console.WriteLine("1) Metodo Base");
            Console.WriteLine("2) Merge con Tappo");
            Console.WriteLine("0) ESCI");
            Console.WriteLine("\nScelta > ");
            while (!int.TryParse(Console.ReadLine(), out scelta));

            return scelta;
        }
    }
}
