using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaStrumenti
{
    class Strumento : ISuonatore
    {

        public virtual void Suona()
        {
            System.Windows.Forms.MessageBox.Show("Sono uno strumento che suona");
        }
    }
}
