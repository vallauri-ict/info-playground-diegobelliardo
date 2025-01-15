using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interf_Ordinamento
{
    internal class Persona:IComparable
    {
        public string nome;
        public string citta;

        public Persona(string nome, string citta)
        {
            this.nome = nome;
            this.citta = citta;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            return String.Compare(this.nome, ((Persona)obj).nome);
        }
    }
}
