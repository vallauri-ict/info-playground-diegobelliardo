using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfacce03_Notifiche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("****   SISTEMA DI NOTIFICHE   ****");
            Console.WriteLine("**********************************\n");

            INotifica email = new NotificaEmail();
            INotifica sms = new NotificaSMS();
            INotifica push = new NotificaPush();

            GestoreNotifiche gestore = new GestoreNotifiche();
            gestore.AggiungiCanale(email);
            gestore.AggiungiCanale(sms);
            gestore.AggiungiCanale(push);

            Console.WriteLine("****  Caso 1: Invio singolo\n");
            gestore.InviaNotifica(email, "Benvenuto", "utente@gmail.com");

            Console.WriteLine("****  Caso 2: Invio a tutti i canali\n");
            gestore.InviaNotificaATutti("Manutenzione programmata per domani", "tutti.utenti@gmail.com");

            Console.WriteLine("****  Caso 3: Invio al primo disponibile\n");
            gestore.InviaPrimoDisponibile("Messaggio urgente", "destinatario@gmail.com");


            Console.ReadKey();

        }
    }
}
