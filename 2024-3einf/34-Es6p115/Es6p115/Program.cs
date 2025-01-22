using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es6p115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomi = new string[]
           {
                "Marco", "Luca", "Giovanni", "Alessandro", "Francesco",
                "Matteo", "Andrea", "Roberto", "Giuseppe", "Daniele",
                "Davide", "Simone", "Stefano", "Antonio", "Giulio",
                "Federico", "Paolo", "Leonardo", "Giorgio", "Salvatore"
           };

            string[] cognomi = new string[]
            {
                "Rossi", "Bianchi", "Verdi", "Neri", "Gialli",
                "Marini", "Romano", "Esposito", "Ferrari", "Conti",
                "Giordano", "Ricci", "Lombardi", "Sorrentino", "Barbieri",
                "Corsi", "De Luca", "Vitali", "Pellegrini", "Santoro"
            };

            string[] squadre = new string[]
            {
                "Juve", "Roma", "Roma", "Milan", "Milan",
                "Juventus", "Juve", "Roma", "Napoli", "Milan",
                "Juventus", "Juventus", "Juve", "Napoli", "Milan",
                "Juventus", "Roma", "Roma", "Napoli", "Milan"
            };
            string[] temp = new string[] { "Juventus", "Roma", "Milan", "Napoli", "Juve" };
            int[] numeri = new int[temp.Length];
           
            for(int i = 0; i < temp.Length; i++)
            {
                numeri[i] = 0;   //Inizializzo il vettore a 0
                for(int j = 0; j < squadre.Length; j++)
                {
                    if (squadre[j] == temp[i])
                    {
                        numeri[i] = numeri[i] + 1;
                    }
                }
            }

            Stampa3Vet("Lista completa giocatori:",cognomi, nomi, squadre);

            Array.Sort(numeri,temp);
            Array.Reverse(numeri);
            Array.Reverse(temp);

           // BubbleSort(numeri, temp);

            Console.WriteLine("SQUADRE: \n");
            for(int i=0;i< temp.Length; i++)
            {
                Console.WriteLine($"{temp[i]}: {numeri[i]}");
            }

            Console.ReadKey();

        }

        private static void Stampa3Vet(string v, string[] vet1, string[] vet2, string[] vet3)
        {
            Console.WriteLine(v);
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{vet1[i]} {vet2[i]}, nella squadra {vet3[i]}");
            }
            Console.WriteLine();
        }

        private static void BubbleSort(int[] numeri, string[]temp)
        {
            int n = numeri.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1 - i; j++)
                {
                    if (numeri[j] < numeri[j+1])
                    {
                        int aus = numeri[j];
                        numeri[j] = numeri[j + 1];
                        numeri[j + 1] = aus;


                        string aus2 = temp[j];
                        temp[j] = temp[j + 1];
                        temp[j + 1] = aus2;
                    }
                }
            }
        }
    }
}
