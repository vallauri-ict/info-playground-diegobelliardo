using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfacce03_Notifiche
{
    internal class NotificaSMS : INotifica
    {
        private string providerAPI;
        private int creditiDisponibili;

        public NotificaSMS(string providerAPI="SMSGateway", int creditiDisponibili=100)
        {
            this.providerAPI = providerAPI;
            this.creditiDisponibili = creditiDisponibili;
        }

        public void InviaNotifica(string messaggio, string destinatario)
        {
            if (creditiDisponibili > 0)
            {
                Console.WriteLine("******  INVIO SMS  ******");
                Console.WriteLine($"Provider: {providerAPI}");
                Console.WriteLine($"Destinatario: {destinatario}");
                Console.WriteLine($"Messaggio: {messaggio}");
                Console.WriteLine("SMS Inviato correttamente");
                creditiDisponibili--;
            }
            else{
                Console.WriteLine("ERRORE: Credito insufficiente");
            }
        }

        public bool VerificaDisponibilita()
        {
            if( creditiDisponibili > 0)
            {
                Console.WriteLine($"Crediti disponibili: {creditiDisponibili}");
                return true;
            }
            else return false;
        }
    }
}
