using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_OOP04
{
    internal class Mostro
    {
        protected double punti;
        protected string verso;

        public Mostro()
        {
            this.punti = 25;
            this.verso = "grugnito";
        }
        public double Valore()
        {
            return punti;
        }
        public string Verso()
        {
            return verso;
        }
    }
}
