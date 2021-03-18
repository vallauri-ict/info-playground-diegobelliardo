using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_PrimoEsDispenseMana_Delegate_
{
    // DICHIARO il mio delegato
    public delegate void salvataggioEseguitoEventHandler(int id);

    class GestoreSalvataggio
    {
        // DICHIARO l'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile(int id)
        {
            MessageBox.Show("Sto eseguendo il salvataggio");

            salvataggioEseguito(id);
        }

    }
}
