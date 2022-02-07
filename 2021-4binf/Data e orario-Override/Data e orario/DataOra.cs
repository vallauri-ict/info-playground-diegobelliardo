using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_orario
{
    class DataOra:Data
    {
        private int ore;
        private int minuti;
        private int secondi;

        
        public DataOra(int giorno, int mese, int anno)
        {
            base.leggi(giorno, mese, anno);
            ore = 0;
            minuti = 0;
            secondi = 0;
            /*
            this.anno = anno;
            this.giorno = giorno;
            this.mese = mese;
            */
        }
        public DataOra()
        {
            base.leggi(1, 1, 1900);
            ore = 0;
            minuti = 0;
            secondi = 0;
        }
        public DataOra(int giorno, int mese, int anno,int ore, int minuti, int secondi)
        {
            base.leggi(giorno, mese, anno);
            this.ore = ore;
            this.minuti = minuti;
            this.secondi = secondi;
        }

        public override string ToString()
        {
            /*
            int g = 0, m = 0, a = 0;
            base.scrivi(ref g, ref m, ref a);
            return g + "/" + m + "/" + a+" - "+ore+":"+minuti+":"+secondi;
            */
            return base.ToString()+ " - " + ore + ":" + minuti + ":" + secondi;
        }
        public override void leggi(int ore, int minuti, int secondi)
        {
            this.ore=ore;
            this.minuti = minuti;
            this.secondi = secondi;
        }
        public override void scrivi( ref int ore, ref int minuti, ref int secondi)
        {
            this.ore = ore;
            this.minuti = minuti;
            this.secondi = secondi;
        }
    }
}
