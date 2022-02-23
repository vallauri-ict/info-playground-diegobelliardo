using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maturita2011.Models
{
    public class Parchi
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }

        public Parchi(string nome, string indirizzo) : this(nome)
        {
            Indirizzo = indirizzo;
        }

        public Parchi(string nome)
        {
            Nome = nome;
        }
    }
}