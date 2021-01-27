using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es01ClasseAstratta
{
    class Studente
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        private DateTime dataNascita;

        public string Prova { }
        
        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        
        public string nomeCompleto()
        {
            return Nome + " " + Cognome;
        }

    }
}
