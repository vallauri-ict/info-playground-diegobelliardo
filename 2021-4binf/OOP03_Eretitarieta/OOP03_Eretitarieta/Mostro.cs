using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Eretitarieta
{
    class Mostro
    {
        public double punti;
        public string nome;

        public Mostro()
        {
            nome = "Senza Nome";
            punti = 100;
        }

        public Mostro(string n)
        {
            nome = n;
            punti = 100;
        }

        public double Valore()
        { // punti del Mostro
            return punti;
        }
    }
}
