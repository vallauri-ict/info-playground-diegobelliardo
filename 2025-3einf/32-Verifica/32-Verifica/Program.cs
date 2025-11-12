using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Verifica
{
    internal class Program
    {
        private static double CalcolaMedia(int somma, int conteggio)
        {
            if (conteggio == 0) return 0.0;
            return (double)somma/conteggio;
        }

        private static void LeggiNumeriEDammiStatistiche(ref int conteggio, ref int somma, ref int massimo, ref int minimo)
        {
            bool continua = true;
            int numero;

            while (continua)
            {
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero == 0)
                    {
                        continua = false;
                    }
                    else
                    {
                        conteggio++;
                        somma += numero;
                        if (numero > massimo) massimo = numero;
                        if (numero < minimo) minimo = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Errore nell'inserimento del numero");
                }
            }
        }
        static void Main(string[] args)
        {
            int conteggio=0, somma=0, massimo=int.MinValue, minimo=int.MaxValue;
            double media;

            Console.WriteLine("Input:");
            LeggiNumeriEDammiStatistiche(ref conteggio, ref somma, ref massimo, ref minimo);
            media = CalcolaMedia(somma, conteggio);
            Console.WriteLine("\n\nOutput:");
            Console.WriteLine($"Conteggio: {conteggio}; Somma: {somma}; Media: {media:F2}; Massimo: {massimo}; Minimo: {minimo}");

            Console.ReadKey();
        }

    }
}
