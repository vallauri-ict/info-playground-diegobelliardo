using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestCollectionsAndLists
{
    internal class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public int ClasseId { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome} - {Cognome} - {DataNascita.ToString("yyyy-MM-dd")} - {ClasseId}";
        }
    }
}
