using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfacciaIComparable
{
    internal class Persona : IComparable<Persona>
    {
        private int eta;
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { 
            get
            {
                return eta;
            }
            set { 
                eta = (value >= 0) ? value : 0;
            } 
        }

        public int CompareTo(Persona other)
        {
            return this.Eta - other.Eta;
        }
    }
}
