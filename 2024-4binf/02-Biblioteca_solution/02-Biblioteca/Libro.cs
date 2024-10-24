using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Biblioteca
{
    internal class Libro : ElementoBiblioteca
    {
        private string genere;
        public string Genere { get => genere; set => genere = value; }

        public new int CalcolaPrestito() // Nasconde il CalcolaPrestito del padre
        {
            return 30;
        }
    }
}
