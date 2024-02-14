using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interface_base
{
    public interface ICalcoliPoligoni
    {
        int Perimetro();
        float Area(int lato, int altezza);
    }
}
