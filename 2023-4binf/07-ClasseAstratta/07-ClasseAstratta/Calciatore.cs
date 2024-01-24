using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClasseAstratta
{
    internal class Calciatore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Ruolo { get; set; }

        public Calciatore(string nome, string cognome, string ruolo)
        {
            Nome = nome;
            Cognome = cognome;
            Ruolo = ruolo;
        }

        public override string ToString()
        {
            return Nome + " " + Cognome + " gioca come " + Ruolo;
        }
    }
}
