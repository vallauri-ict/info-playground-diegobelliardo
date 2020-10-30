using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_ClesseSingleton
{
    class EsSingleton
    {
        public int val = 0;
        private static EsSingleton instance = null;

        private EsSingleton()
        {

        }

        private EsSingleton(int val)
        {
            this.val = val;
        }

        public static EsSingleton GetEsSingleton(int valore)
        {
            if (instance==null)
            {
                instance = new EsSingleton(valore);
            }
            else
            {
                instance.val = valore;
            }
            
            return instance;
        }
    }
}
