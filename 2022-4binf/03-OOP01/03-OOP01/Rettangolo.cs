using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP01
{
    class Rettangolo
    {
        private int lato1;
        private int lato2;

        public int Lato1 
        {   get => lato1; 
            //set => lato1 = value;   // Se la set non c'è non posso 
                                      // modificare la variabile dall'esterno
            set
            {
                if (value > 0) lato1 = value;
                else lato1 = 1;
            }
        }

        public int Lato2 { get => lato2; }

        public Rettangolo():this(1)
        {
        }

        public Rettangolo(int lato1):this(lato1,lato1)
        {
        }

        public Rettangolo(int lato1, int lato2)
        {
            this.Lato1 = lato1;
            this.lato2 = lato2;
        }

        public int Area()
        {
            return Lato1 * Lato2;
        }
    }
}
