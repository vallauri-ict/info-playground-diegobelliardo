using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _18_SecondoEsDispenseMana_Delegate_
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);
    class Counter
    {
        public event OverMaxEventHandler OverMax;
        private int maxVal;
        public int cont = 0;
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

        public void Increment()
        {
            cont++;
            if (cont>=maxVal)
            {
                OverMaxEventArgs e = new OverMaxEventArgs(cont);
                OnOverMax(this, e);
            }
        }

        private void OnOverMax(object sender, OverMaxEventArgs e)
        {
            if (OverMax != null)  // Se OverMax punta ad una funzione (se è stato gestito   
                                  // da qualcuno al di fuori della nostra classe
            {
                OverMax(sender, e);
            }
        }
    }
}
