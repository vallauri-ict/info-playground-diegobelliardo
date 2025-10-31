using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Interfacce02_FormeGeometriche
{
    internal class Rettangolo : IFormaGeometrica
    {
        private double lBase, lAltezza;

        public Rettangolo(double lBase, double lAltezza)
        {
            LBase = lBase;
            LAltezza = lAltezza;
        }

        public double LBase { 
            get => lBase; 
            set {
                if (value < 0)
                    lBase = 0;
                else lBase = value;
            }
        }
        public double LAltezza { 
            get => lAltezza;
            set {
                if (value < 0)
                    lAltezza = 0;
                else lAltezza = value;
            }
        }

        public double CalcolaArea()
        {
            return LBase * LAltezza;
        }

        public double CalcolaPerimetro()
        {
            return (LBase+lAltezza)*2;
        }
    }
}
