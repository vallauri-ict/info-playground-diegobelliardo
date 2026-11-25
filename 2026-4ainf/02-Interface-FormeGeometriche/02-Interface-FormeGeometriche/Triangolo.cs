using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface_FormeGeometriche
{
    internal class Triangolo : IFormaGeometrica
    {
        private double lBase, lAltezza, lato2, lato3;

        public double LBase
        {
            get => lBase;
            set
            {
                if (value < 0)
                {
                    lBase = 0;
                }
                else lBase = value;
            }
        }
        public double LAltezza
        {
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

        public double Lato2 { 
            get => lato2; 
            set {
                if (value < 0)
                {
                    lato2 = 0;
                }
                else lato2 = value;
            }
        }
        public double Lato3 { 
            get => lato3;
            set {
                if (value < 0)
                {
                    lato3 = 0;
                }
                else lato3 = value;
            }
        }

        public Triangolo(double lBase, double lAltezza, double lato2, double lato3)
        {
            LBase = lBase;
            LAltezza = lAltezza;
            Lato2 = lato2;
            Lato3 = lato3;
        }

        public double CalcolaArea()
        {
            return lBase * LAltezza / 2;
        }

        public double CalcolaPerimetro()
        {
            return LBase + Lato2 + Lato3;
        }

        public void Disegna()
        {
            Console.WriteLine($"Ho disegnato un triangolo con lati: {LBase} - {Lato2} - {Lato3}");
        }
    }
}
