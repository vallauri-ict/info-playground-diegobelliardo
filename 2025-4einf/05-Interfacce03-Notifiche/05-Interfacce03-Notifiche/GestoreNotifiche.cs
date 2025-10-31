using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfacce03_Notifiche
{
    // Utilizza l'interfaccia per essere flessibile
    // Esempio di DEPENDENCY INJECTION
    internal class GestoreNotifiche
    {
        private List<INotifica> canaliNotifica;

        public GestoreNotifiche()
        {
            canaliNotifica = new List<INotifica>();
        }

        //Aggiungo un canale di notifica
        public void AggiungiCanale(INotifica canale)
        {
            canaliNotifica.Add(canale);
            Console.WriteLine($"Canale di notifica aggiunto: {canale.GetType().Name}"); 
        }

        /// <summary>
        /// Invia una notifica usando un canale specifico
        /// </summary>
        /// <param name="canale"></param>
        /// <param name="messaggio"></param>
        /// <param name="destinatario"></param>
        public void InviaNotifica(INotifica canale, string messaggio, string destinatario)
        {
            if (canale.VerificaDisponibilita())
            {
                canale.InviaNotifica(messaggio, destinatario);
            }
            else
            {
                Console.WriteLine("Il canale di notifica non è disponibile!");
            }
        }
        
        /// <summary>
        /// Invia la notifica a tutti i canali disponibili
        /// </summary>
        /// <param name="messaggio"></param>
        /// <param name="destinatario"></param>
        public void InviaNotificaATutti(string messaggio, string destinatario)
        {
            Console.WriteLine(">>> Invio notifica a tutti i canali disponibili <<<\n");

            foreach (var item in canaliNotifica)
            {
                if (item.VerificaDisponibilita())
                {
                    item.InviaNotifica(messaggio, destinatario);
                }
            }
            Console.WriteLine("****** Invio terminato ******");
        }
        /// <summary>
        /// Invia il messaggio al primo canale disponibile
        /// </summary>
        /// <param name="messaggio"></param>
        /// <param name="destinatario"></param>
        public void InviaPrimoDisponibile(string messaggio, string destinatario)
        {
            Console.WriteLine(">>> Invio notifica al primo canale disponibile <<<\n");

            foreach (var item in canaliNotifica)
            {
                if (item.VerificaDisponibilita())
                {
                    item.InviaNotifica(messaggio,destinatario);
                    return;
                }
            }

            Console.WriteLine("ERRORE: Nessun canale di notifica disponibile");
        }
    }
}
