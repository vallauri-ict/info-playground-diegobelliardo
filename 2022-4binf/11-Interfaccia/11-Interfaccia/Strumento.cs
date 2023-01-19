using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interfaccia
{
    internal class Strumento : ISuonatore
    {
        //Soluzione 1 - Classe NON Astratta
        public virtual void Suona()
        {
            System.Windows.Forms.MessageBox.Show("Sono uno strumento che suona");
        }

        //Soluzione 2 - Classe ASTRATTA
        //public abstract void Suona();

    }
}
