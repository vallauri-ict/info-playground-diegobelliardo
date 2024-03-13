using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_SecondoEventiContatore
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);
    internal class Counter
    {
        public event OverMaxEventHandler OverMax;
        private int maxVal;
        public int count=0;

        public Counter(int maxVal)
        {
            if (maxVal>10)
            {
                throw new ArgumentException("Il valore massimo consentito è 10");
            }
            else this.maxVal = maxVal;
        }
        public void Increment()
        {
            count++;
            if (count>=maxVal)
            {
                OverMaxEventArgs e = new OverMaxEventArgs(count);
                OnOverMax(this, e);
            }
        }

        private void OnOverMax(object sender,OverMaxEventArgs e)
        {
            if (OverMax!=null)  // Se OverMax punta ad una funzione (se è stato gestito
                                // da qualcuno al di fuori della nostra classe)
            {
                OverMax(sender, e);
            }
        }
    }
}
