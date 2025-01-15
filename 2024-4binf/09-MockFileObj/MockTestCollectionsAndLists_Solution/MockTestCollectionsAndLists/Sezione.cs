using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestCollectionsAndLists
{
    internal class Sezione
    {
        public int Id { get; set; }
        public string NomeSezione { get; set; }

        public override string ToString()
        {
            return $"{Id} - {NomeSezione}";
        }
    }
}
