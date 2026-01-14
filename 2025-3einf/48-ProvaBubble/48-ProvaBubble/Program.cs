using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_ProvaBubble
{
    internal class Program
    {
        static string[] vet = { "Barbara", "Alberto", "Paola", "Domenico", "Vincenzo", "Beatrice" };

        static void Bubble(string[] vet)
        {
            int i = -1;
            bool scambio;

            do
            {
                i++;
                scambio = false;
                for (int j = vet.Length - 2; j >= i; j--)
                {
                    if (vet[j].CompareTo(vet[j + 1]) > 0)
                    {
                        string aus = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aus;

                        scambio = true;
                    }
                }
            } while (scambio && i < vet.Length - 1);
        }

        private static void StampaVettore(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            StampaVettore(vet);
            Bubble(vet);
            Console.WriteLine();
            StampaVettore(vet);

            Console.ReadKey();
        }
    }
}
