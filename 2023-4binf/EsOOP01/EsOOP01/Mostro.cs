using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsOOP01
{
    internal class Mostro
    {
        public string nome;
        protected double punti=5;
        protected string colore;
        public string Nome()
        {
            return nome; //nome del Mostro
        }
        private double Valore()
        { // punti del Mostro
            return punti;
        }


    }
}
