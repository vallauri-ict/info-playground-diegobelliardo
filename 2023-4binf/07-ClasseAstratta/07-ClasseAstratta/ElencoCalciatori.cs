using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClasseAstratta
{
    internal class ElencoCalciatori : Report
    {
        private List<Calciatore> lstCalciatore = new List<Calciatore>();
        private string stampa="";
        protected override void printBody()
        {
            foreach (var calciatore in lstCalciatore)
            {
                stampa += calciatore.ToString() + "\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "\nFINE ELENCO CALCIATORI";
        }

        protected override void printHeader()
        {
            stampa = "";
            stampa += "ELENCO DEI CALCIATORI\n\n";
        }

        public ElencoCalciatori()
        {
            lstCalciatore.Add(new Calciatore("Paolo", "Maldini", "Difensore"));
            lstCalciatore.Add(new Calciatore("Paolo", "Rossi", "Attaccante"));
            lstCalciatore.Add(new Calciatore("Beppe", "Baresi", "Difensore"));
            lstCalciatore.Add(new Calciatore("Dino", "Zoff", "Portiere"));
        }

        public string ritornoStampa() { return stampa; }
    }
}
