using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SecondoEsDispenseMana_Delegate_
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);
    class Counter
    {
        private int maxVal;
        public Counter(int n)
        {
            if (n>10)
            {
                throw new ArgumentException("Il valore massimo è 10");
            }
            else
            {
                maxVal = n;
            }

        }
    }
}
