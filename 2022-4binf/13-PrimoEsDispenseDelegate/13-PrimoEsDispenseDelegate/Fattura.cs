using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_PrimoEsDispenseDelegate
{
    // Dichiarazione del delegato
    public delegate void salvataggioEseguitoEventHandler(int id);
    
    class Fattura
    {
        Random rnd = new Random();
        //Dichiarazione dell'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile()
        {
            int id = rnd.Next();
            MessageBox.Show("Sto effettuando il salvataggio");
            // istruzioni di salvataggio del file
            
            //Scateno l'evento
            salvataggioEseguito(id);
        }
    }
}
