using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interface_Notifiche
{
    internal interface INotifica
    {
        void InviaNotifica(string messaggio, string destinatario);
        bool VerificaDisponibilita();
    }
}
