using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfacce03_Notifiche
{
    internal class NotificaPush : INotifica
    {
        private string piattaforma;
        private bool serverAttivo;

        public NotificaPush(string piattaforma="Firebase", bool serverAttivo=true)
        {
            this.piattaforma = piattaforma;
            this.serverAttivo = serverAttivo;
        }

        public void InviaNotifica(string messaggio, string destinatario)
        {
            if(serverAttivo)
            {
                Console.WriteLine("******  INVIO NOTIFICA PUSH  ******");
                Console.WriteLine($"Piattaforma: {piattaforma}");
                Console.WriteLine($"Destinatario: {destinatario}");
                Console.WriteLine($"Notifica: {messaggio}");
                Console.WriteLine("Notifica push inviata con successo");
            }
            else
            {
                Console.WriteLine("ERRORE: Server notifiche push non disponibile");
            }
        }

        public bool VerificaDisponibilita()
        {
            Console.WriteLine($"Server {piattaforma}: " + (serverAttivo ? "Online" : "Offline"));
            return serverAttivo;
        }
    }
}
