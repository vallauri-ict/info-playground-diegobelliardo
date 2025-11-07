using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal class PluginConvertitore : IPlugin
    {
        public string Nome => "Convertitore Unità di Misura";

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

                Console.WriteLine("Terminare a casa.....");
            }
        }
    }
}
