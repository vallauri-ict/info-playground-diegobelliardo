using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal interface IPlugin
    {
        string Nome { get; }
        string Versione { get; }
        string Descrizione { get; }
        void Esegui();
    }
}
