using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaIComparable
{
    class Persona:IComparable<Persona>
    {
        private string nome;
        private string cognome;
        private int eta;

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public int Eta { get => eta; 
            set {
                eta = (value >= 0) ? value : 0;
            } 
        }

        public int CompareTo(Persona other)
        {
            return this.eta - other.eta;
        }
    }
}
