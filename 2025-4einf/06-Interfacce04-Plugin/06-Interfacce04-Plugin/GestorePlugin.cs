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

        public void CaricaPlugin(IPlugin plugin)
        {
            string chiave = plugin.Nome.ToLower();

            if (!pluginCaricati.ContainsKey(chiave))
            {
                pluginCaricati[chiave] = plugin;
                Console.WriteLine($"***  Plugin caricato: {plugin.Nome} v{plugin.Versione}  ***");
            }
            else{ 
                Console.WriteLine($"Plugin già caricato: {plugin.Nome}");
            }
        }

        public void EseguiPlugin(string nome)
        {
            string chiave = nome.ToLower();
            if (pluginCaricati.ContainsKey(chiave))
            {
                IPlugin plugin = pluginCaricati[chiave];

                try
                {
                    plugin.Esegui();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nERRORE durante l'esecuzione del plugin: {ex.Message}");
                }
            }
            else Console.WriteLine($"Plugin non trovato: {nome}");
        }

        internal void ElencoPlugin()
        {
            Console.WriteLine("\n***   PLUGIN CARICATI   ***");
            if (pluginCaricati.Count==0)
            {
                Console.WriteLine("Nessun plugin caricato");
                return;
            }

            int i = 1;
            foreach (var plugin in pluginCaricati.Values)
            {
                Console.WriteLine($"\n{i}. {plugin.Nome} (v{plugin.Versione})");
                Console.WriteLine($"\t{plugin.Descrizione}");
                i++;
            }
            Console.WriteLine();
        }

        internal void RimuoviPlugin(string daRimuovere)
        {
            string chiave = daRimuovere.ToLower();
            if (pluginCaricati.Remove(chiave))
            {
                Console.WriteLine($"Plugin rimosso: {daRimuovere} ");
            }
            else Console.WriteLine($"Plugin non trovato: {daRimuovere}");
        }
    }
}
