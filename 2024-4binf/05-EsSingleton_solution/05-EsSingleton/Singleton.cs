using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EsSingleton
{
    internal class Singleton
    {
        private static Singleton singletonObj=null;

        private Singleton()
        {
        }
        public static Singleton GetInstance()
        {
            if (singletonObj == null)
            {
                singletonObj = new Singleton();
            }

            return singletonObj;
        }
    }
}
