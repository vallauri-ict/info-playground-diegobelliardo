using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface_FormeGeometriche
{
    internal class Rettangolo : IFormaGeometrica
    {
        private double lBase, lAltezza;

        public double LBase { 
            get => lBase;
            set {
                if (value < 0)
                {
                    lBase = 0;
                }
                else lBase = value;
            } 
        }
        public double LAltezza { 
            get => lAltezza; 
            set
            {
                if (value < 0)
                {
                    lAltezza = 0;
                }
                else lAltezza = value;
            }
        }

        public Rettangolo(double lBase, double lAltezza)
        {
            LBase = lBase;
            LAltezza = lAltezza;
        }

        public double CalcolaArea()
        {
            return LBase * LAltezza;
        }

        public double CalcolaPerimetro()
        {
            return (LBase + LAltezza) * 2;
        }

        public void Disegna()
        {
            Console.WriteLine($"Ho disegnato un rettungolo con base {LBase} e altezza {LAltezza}");
        }
    }
}
