using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_Regex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] partNumbers = { "1298-673-4192", "A08Z-931-468A",
                    "_A90-123-129X", "12345-KKA-1230",
                    "0919-2893-1256" };
            Regex rgx = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");
            foreach (string partNumber in partNumbers)
                Console.WriteLine("{0} {1} a valid part number.",
                partNumber,

                rgx.IsMatch(partNumber) ? "is" : "is not");

            Console.ReadKey();
        }
    }
}
