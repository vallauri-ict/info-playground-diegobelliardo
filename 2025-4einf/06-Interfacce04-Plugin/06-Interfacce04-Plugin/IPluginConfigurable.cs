using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal interface IPluginConfigurable:IPlugin
    {
        void Configura(Dictionary<string, string> parametri);
    }
}
