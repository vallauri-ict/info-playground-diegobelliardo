using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract01
{
    abstract class Figura
    {
        protected int altezza;
        abstract protected double Area();
        public double Volume()
        {
            return Area() * altezza;
        }
        public string StampaArea()
        {
            return "Area: " + Area();
        }

        public string StampaVolume()
        {
            return "Volume: " + Volume();
        }
    }
}
