using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ObjectTest
{
    internal class Indexed
    {
        string[] v;

        public Indexed(int elem)
        {
            v = new string[elem];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = (9-i).ToString();
            }
        }

        public string this[int index]
        {
            get { return v[index]; }
            set { v[index] = value; }
        }

        public void ordinaElementi()
        {
            Array.Sort(v);
        }
    }
}
