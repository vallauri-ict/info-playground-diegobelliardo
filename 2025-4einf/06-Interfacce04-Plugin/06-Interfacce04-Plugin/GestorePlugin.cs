using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interfacce04_Plugin
{
    internal class GestorePlugin
    {
        private Dictionary<string, IPlugin> pluginCaricati;

        public GestorePlugin()
        {
            pluginCaricati = new Dictionary<string, IPlugin>();
        }

    }
}
