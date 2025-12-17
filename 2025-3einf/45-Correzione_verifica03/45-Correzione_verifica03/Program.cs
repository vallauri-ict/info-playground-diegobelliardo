using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Correzione_verifica03
{
    internal class Program
    {
        private static void CercaEStampa(string[] vet, string nome)
        {
            int[] pos = new int[vet.Length];
            int j = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i]==nome)
                {
                    pos[j] = i;
                    j++;
                }
            }
            if (j>0)
            {
                Console.Write($"{nome} trovato nella/e posizione/i: ");
                Array.Resize(ref pos, j);
                StampaVettore(pos);
            }
            else Console.WriteLine($"{nome} non trovato!");
        }
        private static void StampaVettore(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            string[] vet = { "Luca", "Danilo", "Stefano", "Luigi", "Marco", "Manuel", 
                            "Mirco", "Danilo", "Danilo", "Andrea" };

            Console.Write("Inserisci il nome da cercare: ");
            string nome=Console.ReadLine();

            CercaEStampa(vet,nome);
        }

    }
}
