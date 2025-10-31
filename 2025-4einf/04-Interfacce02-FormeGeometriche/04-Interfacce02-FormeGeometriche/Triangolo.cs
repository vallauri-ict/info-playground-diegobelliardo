using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Interfacce02_FormeGeometriche
{
    internal class Triangolo: IFormaGeometrica
    {
        private double lBase, lAltezza, lato1, lato2;

        public Triangolo(double lBase, double lAltezza, double lato1, double lato2)
        {
            LBase = lBase;
            LAltezza = lAltezza;
            Lato2 = lato2;
            Lato1 = lato1;
        }

        public double LBase
        {
            get => lBase;
            set
            {
                if (value < 0)
                    lBase = 0;
                else lBase = value;
            }
        }
        public double LAltezza
        {
            get => lAltezza;
            set
            {
                if (value < 0)
                    lAltezza = 0;
                else lAltezza = value;
            }
        }

        public double Lato1 { get => lato1; set => lato1 = value; }
        public double Lato2 { get => lato2; set => lato2 = value; }

        public double CalcolaArea()
        {
            return LBase * LAltezza / 2;
        }

        public double CalcolaPerimetro()
        {
            return LBase + Lato1 + Lato2;
        }
    }
}
