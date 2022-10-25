using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_QuadratoFactoryEcc
{
    class IndexedClass
    {
        private string[] myData;

        public IndexedClass(int size)
        {
            myData = new string[size];
            for (int i = 0; i < size; i++)
            {
                myData[i] = "empty";
            }
        }

        public string this[int pos]         //Iteratore
        {
            get { return myData[pos]; }
            set { myData[pos] = value; }
        }

    }
}
