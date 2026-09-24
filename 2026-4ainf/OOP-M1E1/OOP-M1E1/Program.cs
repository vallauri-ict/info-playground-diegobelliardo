using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_M1E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont;

            Persona p1;
            p1 = new Persona("Aldo", "Rossi", 32);
            Persona p2 = new Persona("Marco", "Bianchi", -38);

            Console.WriteLine($"Persona 1: \nNome: {p1.Nome}" +
                $"\nCognome: {p1.Cognome}\nEtà: {p1.Eta}");
            Console.WriteLine($"Persona 2: \nNome: {p2.Nome}" +
                $"\nCognome: {p2.Cognome}\nEtà: {p2.Eta}");

            Console.ReadKey();
        }
    }
}
