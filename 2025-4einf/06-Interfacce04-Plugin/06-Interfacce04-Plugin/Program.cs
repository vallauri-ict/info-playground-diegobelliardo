using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("**   SISTEMA DI PLUGIN ESTENSIBILE   **");
            Console.WriteLine("***************************************");

            //Gestore
            GestorePlugin gestore = new GestorePlugin();

            Console.WriteLine("Caricamento plugin...\n");
            gestore.CaricaPlugin(new PluginCalcolatrice());

            PluginLogger plgLogger = new PluginLogger();
            plgLogger.Configura(new Dictionary<string, string> 
            {
                { "percorso","MioLog.log" },
                { "console","true" }
            });
            gestore.CaricaPlugin(new PluginLogger());
            
            gestore.CaricaPlugin(new PluginStatistiche());
            gestore.CaricaPlugin(new PluginConvertitore());

            while (true) {
                Console.WriteLine("****************************");
                Console.WriteLine("***    MENU PRINCIPALE   ***");
                Console.WriteLine("****************************\n\n");
                Console.WriteLine("1. Elenca plugin");
                Console.WriteLine("2. Esegui plugin");
                Console.WriteLine("3. Rimuovi plugin");
                Console.WriteLine("0. Esci");
                Console.WriteLine("\nScelta: ");

                string scelta=Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        gestore.ElencoPlugin();
                        break;
                    case "2":
                        gestore.ElencoPlugin();
                        Console.WriteLine("\nInserisci il nome del plugin da eseguire: ");
                        string nomePlugin=Console.ReadLine();
                        gestore.EseguiPlugin(nomePlugin);
                        break;
                    case "3":
                        gestore.ElencoPlugin();
                        Console.WriteLine("\nInserisci il nome del plugin da rimuovere: ");
                        string daRimuovere = Console.ReadLine();
                        gestore.RimuoviPlugin(daRimuovere);
                        break;
                    case "0":
                        Console.WriteLine("Grazie grazie!");
                        return;
                    default:
                        Console.WriteLine("Scelta non valida!!!");
                        break;
                }


            }
        }
    }
}
