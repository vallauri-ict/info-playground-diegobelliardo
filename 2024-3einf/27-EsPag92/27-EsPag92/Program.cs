using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_EsPag92
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] v = {"Bianchi", "Devirgilio", "Gallo",
                "Melandri", "Fabbri", "Varese", "Bianchi" };
            string nome = "";
            bool trovato = false;

            Console.Write("Insersci il nome da cercare: ");
            nome = Console.ReadLine();

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == nome)
                {
                    Console.WriteLine("Elemento trovato in posizione " + i);
                    trovato = true;
                }
            }

            if (!trovato)
                Console.WriteLine("Elemento non trovato");

            Console.ReadKey();
        }
    }
}
