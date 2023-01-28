using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_SecondoEsDelegateDispense
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);
    class Counter
    {
        public event OverMaxEventHandler OverMax;
        private int maxValue;
        public int count = 0;

        public Counter(int maxValue)
        {
            if (maxValue > 10)
            {
                throw new ArgumentException("Il valore massimo ammesso è 10");
            }
            else
            {
                this.maxValue = maxValue;
            }
        }

        public void Increment()
        {
            count++;
            if (count >= maxValue)
            {
                OverMaxEventArgs e = new OverMaxEventArgs(maxValue);

                //Soluzione 1 se ho solo quasta classe
                //OverMax(this, e);

                //Soluzione 2 se ho delle classi figlie che essendo più specializzate
                //hanno la necessità di fare qualcos'altro prima di lanciare l'evento
                OnOverMax(this, e);
            }
        }

        protected virtual void OnOverMax(object sender, OverMaxEventArgs e)
        {
            if (OverMax != null)
            {
                OverMax(sender, e);
            }
        }
    }
}
