using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_PersoneStudenti
{
    class Studente : Persona
    {
        internal List<int> lstVoti = new List<int>();

        public double Media()
        {
            int sommaVoti = 0;
            foreach (var item in lstVoti)
            {
                sommaVoti += item;
            }

            return (double)sommaVoti / lstVoti.Count;
        }
    }
}
