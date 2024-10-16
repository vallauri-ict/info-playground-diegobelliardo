using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Caricare un vettore, chiedendo la lunghezza(numero pari), con numeri casuali 
 * tra 0 e 100. Quindi copiare la prima metà degli elmenti del vettore in un 
 * vettore B in ordine inverso e copiare la seconda metà del vettore in un vettore
 *  C iserendo in modo alternato il primo e l'ultimo elemento, il secondo e il
 *  penultimo e così via
 */


namespace _09_MetaVettore
{
    internal class Program
    {
        Random rnd = new Random();  //Variabile globale
        static void Main(string[] args)
        {
            int n; // Variabile locale

            Console.Write("Inserisci la lunghezza del vettore (numero pari): ");
            Console.ReadLine();
        }
    }
}
