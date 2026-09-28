using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_M2E1
{
    internal class Calcolatore
    {

        public int Somma(int a,  int b)
        {
            return a + b;
        }

        /*  !!! NON SI PUO' FARE !!!
        public double Somma(int a, int b)
        {
            return (double)a + (double)b;
        }  */

        public double Somma(double a, double b)
        {
            return a + b;
        }

        public int Somma(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
