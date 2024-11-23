using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_QueueProntoSoccorso
{
    internal class Paziente
    {
        private string nome;
        private string eta;
        private string colore;

        public string Nome { get => nome; set => nome = value; }
        public string Eta { get => eta; set => eta = value; }
        public string Colore { get => colore; set => colore = value; }

        public Paziente(string nome, string eta, string colore)
        {
            this.Nome = nome;
            this.Eta = eta;
            this.Colore = colore;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nEtà: {Eta}\nColore: {Colore}";
        }
    }
}
