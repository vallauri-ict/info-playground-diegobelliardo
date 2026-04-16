using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafiDijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo g = new Grafo();

            g.AggiungiNodo(1);
            g.AggiungiNodo(2);
            g.AggiungiNodo(3);
            g.AggiungiNodo(4);

            g.AggiungiArco(1, 2, 4);
            g.AggiungiArco(1, 3, 2);
            g.AggiungiArco(2, 3, 5);
            g.AggiungiArco(2, 4, 10);
            g.AggiungiArco(3, 4, 3);

            var distanze = g.Dijkstra(1);

            foreach (var d in distanze)
            {
                Console.WriteLine($"Nodo {d.Key} distanza: {d.Value}");
            }

            Console.ReadKey();
        }
    }
}
