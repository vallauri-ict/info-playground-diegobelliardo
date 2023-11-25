using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsOOP01
{
    internal class Mannaro:Mostro
    {
        public new string nome;
        public new double punti;
        public new string Nome()
        {
            return nome; //nome del Mannaro
        }

        public double Valore_Proprio()
        { // punti Mannaro
            return punti;
        }
        public double Valore_Padre()
        { // punti Mostro
            return base.punti;
        }
        public new double Valore()
        { // somma punti
            return punti + base.Valore();
        }

    }
}
