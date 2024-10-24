using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Biblioteca
{
    internal class DVD: ElementoBiblioteca
    {
        private string regista;
        public string Regista { get => regista; set => regista = value; }

        public new int CalcolaPrestito()
        {
            return 7;
        }
    }
}
