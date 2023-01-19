using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interfaccia
{
    internal class Persona
    {
        int eta;

        public string Nome { get; set; }
        public int Eta { get => eta; set => eta = value; }


    }
}
