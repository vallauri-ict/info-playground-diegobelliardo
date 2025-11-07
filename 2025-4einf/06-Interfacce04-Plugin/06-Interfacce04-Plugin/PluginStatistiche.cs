using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal class PluginStatistiche : IPlugin
    {
        public string Nome => "Statistiche";

        public string Versione => "2.0.1";

        public string Descrizione => "Calcola statistiche su una serie di numeri";

        public void Esegui()
        {
            Console.WriteLine($"\n=== {Nome} v{Versione} ===");
            Console.WriteLine(Descrizione);
            Console.WriteLine("\nInserisci numeri separati da spazio:");
            Console.WriteLine("> ");

            string input=Console.ReadLine();

            try
            {
                List<double> numeri=new List<double>();
                string[] strs = input.Split(' ');
                foreach (string str in strs)
                {
                    numeri.Add(double.Parse(str));
                }

                if (numeri.Count==0)
                {
                    Console.WriteLine("Nessun numero inserito.");
                }
                else{ 
                    double media = numeri.Average();
                    double somma = numeri.Sum();
                    double min = numeri.Min();
                    double max = numeri.Max();

                    Console.WriteLine("\n---  RISULTATI  ---");
                    Console.WriteLine($"Conteggio: {numeri.Count}");
                    Console.WriteLine($"Somma: {somma:F2}");
                    Console.WriteLine($"Media: {media:F2}");
                    Console.WriteLine($"Minimo: {min:F2}");
                    Console.WriteLine($"Massimo: {max:F2}");
                    Console.WriteLine($"Range: {max - min:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine ($"Errore: {ex.Message}");
            }

        }
    }
}
