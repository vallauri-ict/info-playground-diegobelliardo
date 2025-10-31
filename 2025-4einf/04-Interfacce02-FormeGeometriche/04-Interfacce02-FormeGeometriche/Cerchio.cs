using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Interfacce02_FormeGeometriche
{
    internal class Cerchio : IFormaGeometrica
    {
        private double raggio;
        public double Raggio
        {
            get => raggio;
            set
            {
                if (value < 0)
                    raggio = 0;
                else raggio = value;
            }
        }

        public Cerchio(double raggio)
        {
            this.Raggio = raggio;
        }


        public double CalcolaArea()
        {
            return (raggio * raggio) * Math.PI;
        }

        public double CalcolaPerimetro()
        {
            return raggio * 2 * Math.PI;
        }
    }
}
