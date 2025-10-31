using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfacce03_Notifiche
{
    internal interface INotifica
    {
        void InviaNotifica(string messaggio, string destinatario);
        bool VerificaDisponibilita();
    }
}
