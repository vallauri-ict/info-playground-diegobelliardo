using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafiDijkstra
{
    class Grafo
    {
        private Dictionary<int, List<Arco>> adj = new Dictionary<int, List<Arco>>();

        public void AggiungiNodo(int nodo)
        {
            if (!adj.ContainsKey(nodo))
                adj[nodo] = new List<Arco>();
        }

        public void AggiungiArco(int da, int a, int peso)
        {
            adj[da].Add(new Arco(a, peso));
            adj[a].Add(new Arco(da, peso)); // rimuovi se orientato
        }

        public Dictionary<int, int> Dijkstra(int sorgente)
        {
            var distanze = new Dictionary<int, int>();
            var visitati = new HashSet<int>();

            // inizializzazione
            foreach (var nodo in adj.Keys)
                distanze[nodo] = int.MaxValue;

            distanze[sorgente] = 0;

            while (visitati.Count < adj.Count)
            {
                // trova nodo con distanza minima non visitato
                int nodoCorrente = -1;
                int minDistanza = int.MaxValue;

                foreach (var nodo in adj.Keys)
                {
                    if (!visitati.Contains(nodo) && distanze[nodo] < minDistanza)
                    {
                        minDistanza = distanze[nodo];
                        nodoCorrente = nodo;
                    }
                }

                if (nodoCorrente == -1)
                    break;

                visitati.Add(nodoCorrente);

                // aggiorna i vicini
                foreach (var arco in adj[nodoCorrente])
                {
                    int nuovaDistanza = distanze[nodoCorrente] + arco.Peso;

                    if (nuovaDistanza < distanze[arco.Destinazione])
                    {
                        distanze[arco.Destinazione] = nuovaDistanza;
                    }
                }
            }

            return distanze;
        }
    }
}
