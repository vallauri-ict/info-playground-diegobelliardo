using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ereditarieta01
{
    class Mannaro : Mostro
    {
        internal double punti;

        public Mannaro(double punti) : base(2)
        {
            this.punti = punti;
        }

        public double Valore_Proprio()
        {
            return punti;
        }

        public double Valore_Padre()
        {
            return base.punti;
        }

        public double ValoreTotale()
        {
            return punti+base.punti;
        }
    }
}
