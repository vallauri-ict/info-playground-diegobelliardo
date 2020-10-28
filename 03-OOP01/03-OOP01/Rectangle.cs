using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP01
{
    class Rectangle
    {   //lati del rettangolo 
        private int side1, side2;
        private string descrizione;
        public Color colore;

        public Rectangle(): this(1)
        {
            descrizione = "Sono un rettangolo";
        }

        public Rectangle(int l):this(l,l)
        {

        }

        public Rectangle(int baseRettangolo, int altezzaRettangolo) 
        { 
            side1 = baseRettangolo; 
            side2 = altezzaRettangolo; 
        }

        public string getSide()
        {
            return "Base: "+side1.ToString() + " Altezza: " + side2.ToString();
        }
    }
}
