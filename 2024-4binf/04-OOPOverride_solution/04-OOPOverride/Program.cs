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

            Mannaro u = new Mannaro();
            //u.Verso();
            lstMostri.Add(u);

            Licantropo l = new Licantropo();
            lstMostri.Add(l);


            foreach (Mostro mostro in lstMostri)
            {
                mostro.Verso();
            }

            Console.ReadKey();
        }
    }
}
