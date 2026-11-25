using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface_FormeGeometriche
{
    internal class Program
    {
        static List<IFormaGeometrica>lstForme = new List<IFormaGeometrica>();
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio(3);
            Rettangolo r = new Rettangolo(10, 5);
            Triangolo t = new Triangolo(4, 3, 3.5, 3.5);

            lstForme.Add(c);
            lstForme.Add(t);
            lstForme.Add(r);

            foreach (var item in lstForme)
            {
                Console.WriteLine($"Il perimentro del {item.GetType().Name} vale {item.CalcolaPerimetro()}\n" +
                    $"l'area del {item.GetType().Name} vale {item.CalcolaArea()}");
                item.Disegna();
            }
        }
    }
}
