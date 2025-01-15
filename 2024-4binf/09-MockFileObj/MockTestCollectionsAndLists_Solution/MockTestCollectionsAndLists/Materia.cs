using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestCollectionsAndLists
{
    internal class Materia
    {
        public int Id {  get; set; }
        public string NomeMateria { get; set; }

        public override string ToString()
        {
            return $"{Id} - {NomeMateria}";
        }
    }
}
