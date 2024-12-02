using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EsPag91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] v = {"Bianchi", "Devirgilio", "Fabbri", "Gallo",
                "Melandri", "Varese" };
            string nome = "";
            int i = 0;

            Console.Write("Insersci il nome da cercare: ");
            nome=Console.ReadLine();

            //while (i < v.Length && v[i] != nome)
            //{
            //    i++;
            //}
            //if (i<v.Length) Console.WriteLine($"Elemento trovato in posizione {i}");
            //else Console.WriteLine("Elemento NON trovato");

            // Soluzione 2
            while (i < v.Length-1 && v[i] != nome)
            {
                i++;
            }
            
            if (v[i]==nome) Console.WriteLine($"Elemento trovato in posizione {i}");
            else Console.WriteLine("Elemento NON trovato");

            Console.ReadKey();
        }
    }
}
