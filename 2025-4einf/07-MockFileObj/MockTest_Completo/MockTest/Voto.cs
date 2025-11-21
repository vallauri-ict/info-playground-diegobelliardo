using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{
    public class Voto
    {
        public int Id { get; set; }
        public int StudenteId { get; set; }
        public int MateriaId { get; set; }
        public int Valore { get; set; }
        public DateTime DataVoto { get; set; }

        public override string ToString()
        {
            return $"{Id} - {StudenteId} - {MateriaId} - {Valore} - {DataVoto.ToString("yyyy-MM-dd")}";
        }
    }
}
