using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test della classe Singleton Logger...");
            Logger logObj = Logger.Istanza;

            logObj.Log($"{logObj.GetHashCode()}: Il mio primo log");
            

            Logger logObj2 = Logger.Istanza;
            logObj2.Log($"{logObj2.GetHashCode()}: Il mio secondo log");
        }
    }
}
