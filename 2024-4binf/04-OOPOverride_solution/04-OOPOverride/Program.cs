using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOPOverride
{
    internal class Program
    {
        static List<Mostro> lstMostri = new List<Mostro>();
        static void Main(string[] args)
        {
            Mostro m = new Mostro();
            //m.Verso();

            lstMostri.Add(m);

            // (m as Licantropo).Verso();   NO!!!

            Mannaro u = new Mannaro();
            //u.Verso();
            lstMostri.Add(u);

            (u as Mostro).Verso();  //OK

            Licantropo l = new Licantropo();
            lstMostri.Add(l);


            foreach (Mostro mostro in lstMostri)
            {
                mostro.Verso();
                if (mostro is Licantropo)
                {
                    Console.WriteLine("Si tratta di un Licantropo: "+ (mostro as Licantropo).Punti());
                    // mostro.Punti()       NON E' POSSIBILE
                }
                if (mostro is Mannaro)
                {
                    Console.WriteLine("Si tratta di un Mannaro");
                }
            }

            Console.ReadKey();
        }
    }
}
