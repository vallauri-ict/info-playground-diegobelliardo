using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es01ClasseAstratta
{
    class ElencoStudenti:Report
    {
        private List<Studente> lstStudenti = new List<Studente>();
        public string stampa="";
        
        protected override void printHeader()
        {
            stampa += "INTESTAZIONE STAMPA STUDENTI\n";
        }

        protected override void printBody()
        {
            foreach (var studente in lstStudenti)
            {
                stampa += studente.nomeCompleto() + "\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "FOOTER STAMPA STUDENTI\n";
        }

        public ElencoStudenti()
        {
            lstStudenti.Add(new Studente("Andrea", "Giccardi"));
            lstStudenti.Add(new Studente("Sergio","Grosso"));
        }
        
    }
}
