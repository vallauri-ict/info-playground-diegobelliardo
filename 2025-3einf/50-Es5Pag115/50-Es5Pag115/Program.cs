using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Es5Pag115
{
    internal class Program
    {
        static string[] cognomi = {
            "Rossi",
            "Bianchi",
            "Verdi",
            "Esposito",
            "Ferrari",
            "Romano",
            "Gallo",
            "Conti",
            "DeLuca",
            "Mancini"
        };

        static string[] nomi = {
            "Marco",
            "Luca",
            "Andrea",
            "Giuseppe",
            "Paolo",
            "Antonio",
            "Francesco",
            "Stefano",
            "Matteo",
            "Davide"
        };

        static string[] squadre = {
            "Juventus",
            "Juventus",
            "Juventus",
            "Napoli",
            "Napoli",
            "Napoli",
            "Atalanta",
            "Atalanta",
            "Atalanta",
            "Atalanta"
        };

        private static string LeggiStringa(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        /// <summary>
        /// Ricerca sequenziale per array disordinato e con ripetizioni
        /// </summary>
        /// <param name="vettore">Vettore su cui cercare</param>
        /// <param name="vettorePosizioni">Vettore delle posizioni</param>
        /// <param name="elemento">Elemento da cercare</param>
        /// <returns>Quante volte elemento compare nel vettore</returns>
        private static int RicercaSequenziale(string[] vettore, int[] vettorePosizioni, string elemento)
        {
            int nElementi = 0;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] == elemento)
                {
                    vettorePosizioni[nElementi] = i;
                    nElementi++;
                }
            }

            return nElementi;
        }
        private static int CopiaVettoreParallelo(string[] vet, string valore, string[] sorgente, string[] destinazione)
        {
            int[] pos=new int[vet.Length];

            int n = RicercaSequenziale(vet, pos, valore);
            for (int i = 0; i < n; i++)
            {
                destinazione[i] = sorgente[pos[i]];
            }
            return n;
        }
        private static void StampaVettoriParalleli(string[] a, string[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " " + b[i]);
            }
        }
        private static void StampaVettoriParalleli(string[] a, string[] b, string[] c)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " " + b[i] + " " + c[i]);
            }
        }
        static void Bubble(string[] vet, string[] vet2)
        {
            int i = -1;
            bool scambio;

            do
            {
                i++;
                scambio = false;
                for (int j = vet.Length - 2; j >= i; j--)
                {
                    if (vet[j].CompareTo(vet[j + 1]) > 0)
                    {
                        string aus = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aus;

                        aus = vet2[j];
                        vet2[j] = vet2[j + 1];
                        vet2[j + 1] = aus;


                        scambio = true;
                    }
                }
            } while (scambio && i < vet.Length - 1);
        }
        static void Main(string[] args)
        {
            string[] cognomiOrdinati = new string[cognomi.Length];
            string[] nomiOrdinati = new string[nomi.Length];

            StampaVettoriParalleli(cognomi, nomi, squadre);
            Console.WriteLine();
            string squadra = LeggiStringa("Inserisci la squadra: ");
            int n=CopiaVettoreParallelo(squadre, squadra, cognomi, cognomiOrdinati);
            CopiaVettoreParallelo(squadre, squadra, nomi, nomiOrdinati);
            Console.WriteLine();
            StampaVettoriParalleli(cognomiOrdinati, nomiOrdinati);
            //Supponiamo non ci siano cognomi ripetuti
            Bubble(cognomiOrdinati, nomiOrdinati);
        }

    }
}
