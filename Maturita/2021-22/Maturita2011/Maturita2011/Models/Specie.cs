using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maturita2011.Models
{
    public class Specie
    {

        public int Codice { get; set; }
        public string Nome { get; set; }
        public string RischioEstinzione { get; set; }

        public Specie(int codice, string nome, string rischioEstinzione)
        {
            Codice = codice;
            Nome = nome;
            RischioEstinzione = rischioEstinzione;
        }
    }
}