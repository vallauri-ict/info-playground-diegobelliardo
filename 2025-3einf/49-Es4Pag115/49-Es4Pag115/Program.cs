using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Es4Pag115
{
    internal class Program
    {
        static string[] cognomi = { "AIGOTTI", "FRUA", "BOGGETTI", "ISAIA", "COCCIONI", "GIRAUDO" };
        static string[] nomi = { "DAVIDE", "MATHIAS", "LEONARDO", "PIETRO", "RICCARDO", "LORIS" };
        
        /// <summary>
        /// Ordinamento Selection Sort su vettori paralleli con
        /// elementi distinti
        /// </summary>
        /// <param name="vet1"></param>
        /// <param name="vet2"></param>
        static void SelectionSort(string[] vet1, string[] vet2)
        {
            int posMin;

            for (int i = 0; i < vet1.Length - 1; i++)
            {
                posMin = i;
                for (int j = i+1; j < vet1.Length; j++)
                {
                    if (vet1[posMin].CompareTo(vet1[j])>0)
                    {
                        posMin = j;
                    }
                }
                if (posMin != i)
                {
                    string aus1 = vet1[i];
                    string aus2 = vet2[i];
                    vet1[i]=vet1 [posMin];
                    vet2[i] = vet2[posMin];
                    vet1[posMin] = aus1;
                    vet2[posMin] = aus2;
                }
            }
        }

        private static void StampaVettoriParalleli(string[] a, string[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " " + b[i]);
            }
        }
        private static string LeggiStringa(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        private static int RicercaDicotomica(string[] vettore, string nomeDaCercare)
        {
            int posizione = -1, min = 0, max = vettore.Length - 1;
            int meta;

            while (min <= max)
            {
                meta = (max + min) / 2;
                if (vettore[meta] == nomeDaCercare)
                {
                    return meta;
                }
                else
                {
                    if (nomeDaCercare.CompareTo(vettore[meta]) > 0)
                    {
                        min = meta + 1;
                    }
                    else // In questo caso nomeDaCercare sarà sicuramente più piccolo
                         // Se fosse stato = a vettore[i] sarei già uscito al return sopra
                    {
                        max = meta - 1;
                    }
                }
            }

            return posizione;
        }
        static void Main(string[] args)
        {
            StampaVettoriParalleli(cognomi, nomi);
            SelectionSort(cognomi, nomi);
            Console.WriteLine("\n");
            StampaVettoriParalleli(cognomi, nomi);

            string cognome = LeggiStringa("Inserisci il cognome: ");
            string nome = LeggiStringa("Inserisci il nome: ");
            int pos=RicercaDicotomica(cognomi,cognome);
            if (pos==-1)
            {
                Console.WriteLine($"Non trovato Cognome: {cognome} - Nome: {nome}");
            }
            else
            {
                if (nomi[pos].CompareTo(nome)==0)
                {
                    Console.WriteLine($"Trovato Cognome: {cognome} - Nome: {nome}\nin posizione: {pos}");
                }
                else
                    Console.WriteLine($"Non trovato Cognome: {cognome} - Nome: {nome}");
            }
        }

    }
}
