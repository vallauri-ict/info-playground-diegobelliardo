using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal class PluginCalcolatrice : IPlugin
    {
        public string Nome => "Calcolatrice";

        public string Versione => "1.0.0";

        public string Descrizione => "Esegue operazioni matematiche di base";

        public void Esegui()
        {
            bool fine=false;

            Console.WriteLine($"\n=== {Nome} v{Versione} ===");
            Console.WriteLine(Descrizione);
            Console.WriteLine("\nInserisci operazione (es: 5 + 3) o 'esci' per terminare:");

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
                    try
                    {
                        string[] parti = input.Split(' ');
                        if (parti.Length == 3)
                        {
                            double num1 = double.Parse(parti[0]);
                            string operatore = parti[1];
                            double num2 = double.Parse(parti[2]);

                            double risultato = 0;

                            switch (operatore)
                            {
                                case "+":
                                    risultato = num1 + num2;
                                    break;
                                case "-":
                                    risultato = num1 - num2;
                                    break;
                                case "*":
                                    risultato = num1 * num2;
                                    break;
                                case "/":
                                    if (num2 != 0)
                                    {
                                        risultato = num1 / num2;
                                    }
                                    else throw new DivideByZeroException();
                                    break;
                                default:
                                    throw new InvalidOperationException("Operatore non valido");
                            }

                            Console.WriteLine($"Risultato: {risultato}");
                        }
                        else
                        {
                            Console.WriteLine("Formato non valido. Usa: numero operatore numero");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore: {ex.Message}");
                    }
                }
            }
        }
    }
}
