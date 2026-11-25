using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface_FormeGeometriche
{
    internal class Cerchio : IFormaGeometrica
    {
        private double raggio;

        public double Raggio
        {
            get => raggio;
            set {
                if (value < 0)
                {
                    raggio = 0;
                }
                else raggio = value;
            }
        }

        public Cerchio(double raggio)
        {
            Raggio = raggio;
        }

        public double CalcolaArea()
        {
            return (Raggio * Raggio) * Math.PI;
        }

        public double CalcolaPerimetro()
        {
            return Raggio * Math.PI * 2;
        }

        public void Disegna()
        {
            Console.WriteLine("Ho disegnato un cerchio di raggio: " + Raggio);
        }
    }
}
