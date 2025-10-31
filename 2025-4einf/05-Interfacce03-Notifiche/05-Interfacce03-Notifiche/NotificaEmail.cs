using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfacce03_Notifiche
{
    internal class NotificaEmail : INotifica
    {
        private string serverSMTP;
        private int porta;

        public NotificaEmail(string serverSMTP="smtp.example.com", int porta=587)
        {
            this.serverSMTP = serverSMTP;
            this.porta = porta;
        }

        public void InviaNotifica(string messaggio, string destinatario)
        {
            Console.WriteLine("****** INVIO EMAIL ******");
            Console.WriteLine($"Server SMTP: {serverSMTP}:{porta}");
            Console.WriteLine($"A: {destinatario}");
            Console.WriteLine($"Messaggio: {messaggio}");
            Console.WriteLine("Email inviata con successo");
        }

        public bool VerificaDisponibilita()
        {
            // Simulare la connessione al server
            Console.WriteLine($"Verifica connessione a {serverSMTP}...\nOK");
            return true;
        }
    }
}
