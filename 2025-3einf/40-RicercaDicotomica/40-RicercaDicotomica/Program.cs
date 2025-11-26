using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _40_RicercaDicotomica
{
    internal class Program
    {
        private static int RicercaDicotomica(string[] vettore, string nomeDaCercare)
        {
            int posizione = -1,min=0,max= vettore.Length-1;
            int meta;

            while (min<=max)
            {
                meta = (max + min) / 2;
                if (vettore[meta]==nomeDaCercare)
                {
                    return meta;
                }
                else
                {
                    if (nomeDaCercare.CompareTo(vettore[meta])>0)
                    {
                        min = meta + 1;
                    }
                    else // In questo caso nomeDaCercare sarà sicuramente più piccolo
                         // Se fosse stato = a vettore[i] sarei già uscito al return sopra
                    {
                        max= meta - 1;
                    }
                }
            }

            return posizione;
        }
        static void Main(string[] args)
        {
            string[] v = { "Agosti", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            string nomeDaCercare = "Agosti";

            int pos = RicercaDicotomica(v, nomeDaCercare);

            if (pos == -1)
            {
                Console.WriteLine($"{nomeDaCercare} non presente nell'insieme");
            }
            else
            {
                Console.WriteLine($"{nomeDaCercare} è stato trovato alla posizione {pos}");
            }
        }

    }
}
