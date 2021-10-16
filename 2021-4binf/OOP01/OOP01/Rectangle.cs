using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    class Rectangle
    {
        public int side1;
        public int side2;

        public Rectangle() : this(1)
        {
        }

        public Rectangle(int lato): this(lato,lato)
        {
        }
        private Rectangle(int lato1, int lato2)
        {
            side1 = lato1;
            side2 = lato2;
        }
    }
}
