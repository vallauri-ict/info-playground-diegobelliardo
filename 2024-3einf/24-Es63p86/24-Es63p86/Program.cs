using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Es63p86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Ciao", s2 = "Cane", s3 = "Carta";

            // S1 la più piccola
            if (s1.CompareTo(s2)<=0 && s1.CompareTo(s3)<=0)
            {
                if (s2.CompareTo(s3) <= 0)
                {
                    // S1 la più piccola e s2<s3
                    Console.WriteLine($"1° {s1}\n2° {s2}\n3° {s3}");
                }
                else
                {
                    // S1 la più piccola e s3<s2
                    Console.WriteLine($"1° {s1}\n2° {s3}\n3° {s2}");
                }
            }
            //s2 la più piccola
            if (s2.CompareTo(s3) <= 0 && s2.CompareTo(s1) <= 0)
            {
                if(s3.CompareTo(s1) <= 0)
                Console.WriteLine($"1° {s2}\n2° {s3}\n3° {s1}");
            }
            else
            { 
                Console.WriteLine($"1° {s2}\n2° {s1}\n3° {s3}");
            }
            //s3 la più piccola
            if (s3.CompareTo(s1)<=0 && s3.CompareTo(s2)<=0)
            {
                if (s1.CompareTo(s2) <= 0)
                {
                    Console.WriteLine($"1° {s3}\n2° {s1}\n3° {s2}");
                }
                else
                {
                    Console.WriteLine($"1° {s3}\n2° {s2}\n3° {s1}");
                }
            }
            Console.ReadKey();
        }
    }
}
