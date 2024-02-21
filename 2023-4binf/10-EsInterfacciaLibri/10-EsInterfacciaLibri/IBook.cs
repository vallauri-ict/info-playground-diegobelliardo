using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EsInterfacciaLibri
{
    internal interface IBook
    {
        string Titolo { get; }
        string Autore { get; }
        double Prezzo { get; }
    }
}
