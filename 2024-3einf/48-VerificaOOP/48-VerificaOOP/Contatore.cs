using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_VerificaOOP
{
    internal class Contatore
    {
        private int valore = 0;
        private Contatore() { }

        public int Valore { get => valore; set => valore = value; }

        public static Contatore CreaContatore()
        {
            return new Contatore();
        }

        public void Incrementa()
        {
            Valore++;
        }

    }
}
