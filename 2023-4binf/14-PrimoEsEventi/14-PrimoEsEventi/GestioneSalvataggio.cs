using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_PrimoEsEventi
{
    // DICHIARO il mio delegate
    public delegate void salvataggioEseguitoEventHandler(int id);
    internal class GestioneSalvataggio
    {
        // DICHIARO l'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile(int id)
        {
            MessageBox.Show("Sto eseguendo il salvataggio");

            // Al completamento scateno l'evento
            salvataggioEseguito(id);
        }

    }
}
