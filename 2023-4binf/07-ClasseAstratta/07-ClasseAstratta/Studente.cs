using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClasseAstratta
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public override string ToString()
        {
            return Nome + " " + Cognome;
        }
    }
}
