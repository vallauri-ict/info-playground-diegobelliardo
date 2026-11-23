using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface_FormeGeometriche
{
    internal interface IFormaGeometrica
    {
        double CalcolaArea();
        double CalcolaPerimetro();
        void Disegna();
    }
}
