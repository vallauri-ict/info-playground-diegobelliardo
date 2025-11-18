using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Verifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, errore;

            Console.Write("Inserisci il primo numero: ");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci il secondo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 < 0 || n1 > 12)
                Console.WriteLine("Il primo numero deve essere tra 0 e 12");
            else
            {
                errore = FattorialeIterativo(n1);
                if (errore == -1) Console.WriteLine("Il fattoriale di un numero negativo non può essere calcolato");
                else Console.WriteLine($"Il fattoriale di {n1} vale: {errore}");
            }


            Console.WriteLine($"Prima della funzione per valore:\nn1: {n1}\nn2: {n2}\n");
            ScambiaPerValore(n1, n2);
            Console.WriteLine($"Dopo la funzione per valore:\nn1: {n1}\nn2: {n2}\n");

            Console.WriteLine($"Prima della funzione per riferimento:\nn1: {n1}\nn2: {n2}\n");
            ScambiaPerRiferimento(ref n1, ref n2);
            Console.WriteLine($"Dopo la funzione per riferimento:\nn1: {n1}\nn2: {n2}\n");

        }

        private static void ScambiaPerRiferimento(ref int n1, ref int n2)
        {
            int aus = n1;
            n1 = n2;
            n2 = aus;
            Console.WriteLine($"Dentro la funzione per riferimento:\nn1: {n1}\nn2: {n2}\n");
        }

        private static void ScambiaPerValore(int n1, int n2)
        {
            int aus = n1;
            n1 = n2;
            n2 = aus;
            Console.WriteLine($"Dentro la funzione per valore:\nn1: {n1}\nn2: {n2}\n");
        }

        private static int FattorialeIterativo(int n1)
        {
            int fattoriale = 1;

            if (n1<0)
            {
                return -1;
            }
            for (int i = 2; i <= n1; i++)
            {
                fattoriale *= i;
            }

            return fattoriale;
        }
    }
}
