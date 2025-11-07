using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal class PluginLogger : IPluginConfigurable
    {
        public string Nome => "Logger";

        public string Versione => "1.0.0";

        public string Descrizione => "Registra messaggi con diversi livelli di gravità";
        private string percorsoFile = "log.txt";
        private bool consoleOutput = true;

        public void Configura(Dictionary<string, string> parametri)
        {
            if (parametri.ContainsKey("percorso"))
            {
                percorsoFile = parametri["percorso"];
            }

            if (parametri.ContainsKey("console"))
            {
                consoleOutput = bool.Parse(parametri["console"]);
            }

            Console.WriteLine($"Logger configurato: File={percorsoFile}, Console={consoleOutput}");
        }

        public void Esegui()
        {
            bool fine = false;

            Console.WriteLine($"\n=== {Nome} v{Versione} ===");
            Console.WriteLine(Descrizione);
            Console.WriteLine("\nComandi: INFO <msg>, WARN <msg>, ERROR <msg>, VISUALIZZA, ESCI");

            List<string> logs = new List<string>();

            while (!fine)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input.ToLower() == "esci")
                {
                    fine = true;
                }
                else
                {
                    if (input.ToLower() == "visualizza")
                    {
                        Console.WriteLine("\n--- LOG REGISTRATI ---");
                        foreach (var log in logs)
                        {
                            Console.WriteLine(log);
                        }
                        Console.WriteLine("---------------------------");
                    }
                    else
                    {
                        string[] parti = input.Split(new[] { ' ' },2);
                        if(parti.Length == 2)
                        {
                            string livello  = parti[0].ToUpper();
                            string messaggio = parti[1];
                            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            string logEntry = $"[{timestamp}] [{livello}] {messaggio}";

                            logs.Add(logEntry);

                            if (consoleOutput)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                switch (livello)
                                {
                                    case "INFO":
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                    case "WARN":
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        break;
                                    case "ERROR":
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                };
                                Console.WriteLine(logEntry);
                                Console.ResetColor();
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"\nTotale messaggi registrati: {logs.Count}");
        }
    }
}
