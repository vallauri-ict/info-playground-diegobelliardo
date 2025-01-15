using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestCollectionsAndLists
{
    internal class Classe
    {
        public int Id { get; set; }
        public int AnnoId { get; set; }
        public int SezioneId { get; set; }

        public override string ToString()
        {
            return $"{Id} - {AnnoId} - {SezioneId}";
        }
    }
}
