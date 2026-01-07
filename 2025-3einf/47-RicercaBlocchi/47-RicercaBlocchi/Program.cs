using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_RicercaBlocchi
{
    internal class Program
    {
        static Random rnd = new Random();
        bool esci=false;
        private static int LeggiNumero(string messaggio)
        {
            string n;
            int num = 0;
            bool ok;
            do
            {
                Console.Write(messaggio);
                n = Console.ReadLine();

                ok = int.TryParse(n, out num);

                if (num <= 3) ok = false;    // Il vettore deve avere almeno 3 elementi

                if (!ok)
                {
                    Console.WriteLine("ERRORE: valore non valido!");
                }
            } while (!ok);

            return num;
        }
        private static void CaricaVet(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(100);
            }
        }

        static void Main(string[] args)
        {
            bool trovato = false;
            int n = LeggiNumero("Dimensione vettore: ");
            int[] vet = new int[n];

            int elemento = LeggiNumero("Elemento da cercare: ");
            CaricaVet(vet);
            double lunghezzaBlocco = Math.Sqrt(n);

        }
    }
}
