using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Verifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, errore;

            Console.Write("Inserisci il primo numero: ");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci il secondo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 < 0 || n1 > 12)
                Console.WriteLine("Il primo numero deve essere tra 0 e 12");
            else errore = FattorialeIterativo(n1);



        }

        private static int FattorialeIterativo(int n1)
        {
            throw new NotImplementedException();
        }
    }
}
