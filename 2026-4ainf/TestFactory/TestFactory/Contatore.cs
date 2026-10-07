using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory
{
    internal class Contatore
    {
        private Contatore()
        {
        }

        public Contatore(int n)
        {
            if (n > 0)
            {
                Contatore obj = new Contatore();
            }
            else
            {
                //Messaggio di errore
            }
        }

        public static Contatore CreaContatore(int n)
        {
            if(n > 0)
            {
                Contatore obj = new Contatore();
                return obj;
            }
            else
            {
                return null;
            }                
        }
    }
}
