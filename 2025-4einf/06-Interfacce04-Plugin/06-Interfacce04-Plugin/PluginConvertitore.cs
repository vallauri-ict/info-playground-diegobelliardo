using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal class PluginConvertitore : IPlugin
    {
        public string Nome => "Convertitore";

        public string Versione => "1.0.0";

        public string Descrizione => "Converte tra diverse unità di misura";

        public void Esegui()
        {
            string scelta = "";
            Console.WriteLine($"\n=== {Nome} v{Versione} ===");
            Console.WriteLine(Descrizione);
            Console.WriteLine("\nConversioni disponibili:");
            Console.WriteLine("1. km -> miglia");
            Console.WriteLine("2. miglia -> km");
            Console.WriteLine("3. kg -> libbre");
            Console.WriteLine("4. libbre -> kg");
            Console.WriteLine("5. °C -> °F");
            Console.WriteLine("6. °F -> °C");
            
            while (scelta != "0")
            {
                Console.WriteLine("\nScegli conversione (1-6) o 0 per uscire: ");
                scelta=Console.ReadLine();

                Console.WriteLine("Inserisci un valore: ");

                if (double.TryParse(Console.ReadLine(), out double valore))
                {
                    double risultato = 0.0;
                    string unita = "";

                    switch (scelta)
                    {
                        case "1":
                            risultato = valore * 0.62;
                            break;
                        case "2":
                            risultato = valore * 1.61;
                            break;
                        case "3":
                            risultato = valore * 2.2;
                            break;
                        case "4":
                            risultato = valore * 0.45;
                            break;
                        case "5":
                            risultato = (valore * 9 / 5) + 32;
                            break;
                        case "6":
                            risultato = (valore - 32) * 5 / 9;
                            break;
                        default:
                            risultato = 0;
                            break;
                    }
                    switch (scelta)
                    {
                        case "1":
                            unita = "migliaia";
                            break;
                        case "2":
                            unita = "km";
                            break;
                        case "3":
                            unita = "Libbre";
                            break;
                        case "4":
                            unita = "kg";
                            break;
                        case "5":
                            unita = "°F";
                            break;
                        case "6":
                            unita = "°C";
                            break;
                        default:
                            unita = "?";
                            break;
                    }

                    Console.WriteLine($"Risultato: {risultato:F2} {unita}");
                }
                
            }
        }
    }
}
