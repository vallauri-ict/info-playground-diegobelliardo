using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interface_Notifiche
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
            throw new NotImplementedException();
        }

        public bool VerificaDisponibilita()
        {
            throw new NotImplementedException();
        }
    }
}
