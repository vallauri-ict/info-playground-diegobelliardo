using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestCollectionsAndLists
{
    internal class AnnoScolastico
    {
        public int Id { get; set; }
        public int Anno { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Anno}";
        }
    }
}
