using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_UnioneVettori
{
    /*
 * Dati due vettori A e B ottenere 
 * un vettore C dato dall'unione dei due precedenti.
 * */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1,v2,v3;
            int n1, n2, n3, pos=0, i2;

            Console.Write("Dimensione vettore A: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dimensione vettore B: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = n1 + n2;


            v1=new int[n1];
            v2=new int[n2];
            v3=new int[n3];

            Console.WriteLine("Inserisci elementi vettore A: ");

            for (int i = 0; i < n1; i++)
            {
                Console.Write((i+1)+": ");
                v1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Inserisci elementi vettore B: ");

            for (int i = 0; i < n2; i++)
            {
                Console.Write((i + 1) + ": ");
                v2[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*  
             *  Soluzione con un solo ciclo
             *  
            for (int i = 0; i < n3; i++)
            {
                if (i == n1) pos = 0;  // Azzero pos per usarlo su v2

                if (i < n1)
                {
                    v3[i] = v1[pos++]; // v1[++pos] NON VA BENE IN QUESTO CASO
                }
                else
                {
                    v3[i] = v2[pos++];
                }
            }

            */

            /*
             * Soluzione con 2 cicli
             */
            for(pos=0; pos < n1; pos++)
            {
                v3[pos] = v1[pos];
            }

            for(i2= 0; i2 < n2; i2++)
            {
                v3[pos++] = v2[i2];
            }

            /*************************************************/


            Console.WriteLine("***   STAMPA   ***");
            for (int i = 0; i < n3; i++)
            {
                Console.WriteLine((i+1)+": " + v3[i]);
            }

            Console.ReadKey();  
        }
    }
}
