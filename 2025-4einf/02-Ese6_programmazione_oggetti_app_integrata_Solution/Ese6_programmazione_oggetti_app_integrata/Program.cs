using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese6_programmazione_oggetti_app_integrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta = 0;
            do
            {
                scelta = Menu();
                Console.Clear();
                switch (scelta)
                {
                    case 0:
                        return;
                    case 1:
                        VisualizzaStud();
                        break;
                    case 2:
                        AggiungiStud();
                        break;
                    case 3:
                        RimuoviStud();
                        break;
                    case 4:
                        ModificaStud();
                        break;
                    case 5:
                        CercaStudPerNome();
                        break;
                    case 6:
                        CercaStudPerId();
                        break;
                    case 7:
                        OrdinaListaStudPerCognome();
                        break;
                    case 8:
                        FiltraListaPerEtaSup();
                        break;
                    case 9:
                        AggiungiOrAggiornaVotoAStudId();
                        break;
                    case 10:
                        CalcolaMediaVotiTot();
                        break;
                    case 11:
                        TrovaStudMediaMax();
                        break;
                }
                if (scelta != 0)
                {
                    Console.WriteLine("\n\nPremi un qualsiasi tasto per tornare al menù...");
                    Console.ReadKey();
                }
            } while (scelta > 0);

        }

        /// <summary>
        /// Trova lo studente con la media più alta
        /// </summary>
        private static void TrovaStudMediaMax()
        {
            Console.WriteLine("** Trova lo/gli studente/i con voto più alto **\n\n");

            ClsVoti.TrovaStudMediaMax();
        }

        /// <summary>
        /// Calcola la media totale di tutti i voti
        /// </summary>
        private static void CalcolaMediaVotiTot()
        {
            Console.WriteLine("** Calcola la media totale di tutti i voti **\n\n");

            ClsVoti.CalcolaMediaVotiTot();
        }

        /// <summary>
        /// Aggiunge o aggiorna il voto di uno studente tramite id
        /// </summary>
        private static void AggiungiOrAggiornaVotoAStudId()
        {
            Console.WriteLine("** Aggiungi valutazione ad un studente per id **\n\n");

            int id = IntIdOrEtaValido("Inserisci l'id dello studente:");
            double voto = 0;
            do
            {
                Console.WriteLine("Inserisci il voto dello studente:");
                voto = Convert.ToInt32(Console.ReadLine());
            } while (voto < 0 || voto > 10);

            ClsVoti.AggiungiOrAggiornaVotoAStudId(id, voto);
        }

        /// <summary>
        /// Filtra la lista degli studenti maggiori dell'età scelta dall'utente
        /// </summary>
        private static void FiltraListaPerEtaSup()
        {
            Console.WriteLine("** Filtra la lista per studenti con età superiore a un certo valore **\n\n");

            int eta = IntIdOrEtaValido("Inserisci l'età su cui filtrare:");

            ClsStudenti.FiltraListaPerEtaSup(eta);
        }

        /// <summary>
        /// Ordina la lista degli stduenti per cognome
        /// </summary>
        private static void OrdinaListaStudPerCognome()
        {
            Console.WriteLine("** Ordina la lista degli studenti per cognome **\n\n");

            ClsStudenti.OrdinaListaStudPerCognome();
        }

        /// <summary>
        /// Cerca uno studente per id dalla rubrica degli studenti
        /// </summary>
        private static void CercaStudPerId()
        {
            Console.WriteLine("** Cerca studente per id **\n\n");

            int id = IntIdOrEtaValido("Inserisci l'id dello studente:");

            ClsRubrica.CercaStudente(id);
        }

        /// <summary>
        /// Cerca un studente per nome dalla lista degli studenti
        /// </summary>
        private static void CercaStudPerNome()
        {
            Console.WriteLine("** Cerca studente per nome **\n\n");

            string nome = StringaNomeOrCognomeValida("Inserisci il nome dello studente:");

            ClsStudenti.CercaStudente(nome);
        }

        /// <summary>
        /// Modifica i dati di uno studente
        /// </summary>
        private static void ModificaStud()
        {
            Console.WriteLine("** Modifica studente **\n\n");

            int id = IntIdOrEtaValido("Inserisci l'id dello studente da modificare:");

            ClsStudenti stud = RiempiObjectStud();

            ClsRubrica.ModificaStud(id, stud);
        }

        /// <summary>
        /// Rimuove lo studente dalla lista degli studenti
        /// </summary>
        private static void RimuoviStud()
        {
            Console.WriteLine("** Rimuovi studente **\n\n");

            ClsStudenti stud = RiempiObjectStud();

            ClsStudenti.RimuoviStudente(stud);
        }

        /// <summary>
        /// Aggiunge uno studente alla lista degli studenti
        /// </summary>
        private static void AggiungiStud()
        {
            Console.WriteLine("** Aggiungi studente **\n\n");

            ClsStudenti stud = RiempiObjectStud();

            ClsStudenti.AggiungiStudente(stud);
        }

        /// <summary>
        /// Riempie l'object ClsStudenti
        /// </summary>
        /// <returns>L'object ClsStudenti riempito</returns>
        private static ClsStudenti RiempiObjectStud()
        {
            string nome = StringaNomeOrCognomeValida("Inserisci il nome dello studente:");
            string cognome = StringaNomeOrCognomeValida("Inserisci il cognome dello studente:");
            int eta = IntIdOrEtaValido("Inserisci l'età dello studente:");

            ClsStudenti stud = new ClsStudenti(nome, cognome, eta);
            return stud;
        }

        /// <summary>
        /// Controlla se un'età o un id è valido o meno (int, > 0)
        /// </summary>
        /// <param name="message">Il messaggio da visualizzare</param>
        /// <returns>L'intero con un valore</returns>
        private static int IntIdOrEtaValido(string message)
        {
            Console.WriteLine(message);
            int val = int.Parse(Console.ReadLine());
            return val;
        }

        /// <summary>
        /// Controlla se una nome o un cognome sono validi o meno (non null, non stringhe vuote, 
        /// solo caratteri)
        /// </summary>
        /// <param name="message">Il messaggio da visualizzare</param>
        /// <returns>La stringa con un valore</returns>
        private static string StringaNomeOrCognomeValida(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine().ToLower();
            return value;
        }

        /// <summary>
        /// Visualizza la rubrica degli studenti
        /// </summary>
        private static void VisualizzaStud()
        {
            Console.WriteLine("** Visualizza la rubrica degli studenti **\n\n");

            ClsRubrica.VisualizzaStud();
        }

        /// <summary>
        /// Il menù che interfaccia l'utente con il codice delle funzione, delle classi e dei metodi
        /// </summary>
        /// <returns>La scelta fatta dall'utente</returns>
        private static int Menu()
        {
            Console.Clear();
            int scelta;
            do
            {
                Console.WriteLine("0) Esci");
                Console.WriteLine("1) Visualizza la rubrica degli studenti ");
                Console.WriteLine("2) Aggiungi studente (ClsStudenti --> List) (ClsRubrica --> Dictionary)");
                Console.WriteLine("3) Rimuovi studente (ClsStudenti --> List) (ClsRubrica --> Dictionary)");
                Console.WriteLine("4) Modifica studente (ClsStudenti --> List) (ClsRubrica --> Dictionary)");
                Console.WriteLine("5) Cerca studente per nome (ClsStudenti --> List)");
                Console.WriteLine("6) Cerca studente per id (ClsRubrica --> Dictionary)");
                Console.WriteLine("7) Ordina la lista degli studenti per cognome (ClsListaStudenti --> List)");
                Console.WriteLine("8) Filtra la lista per studenti con età superiore a un certo valore (ClsListaStudenti --> List)");
                Console.WriteLine("9) Aggiungi/Aggiorna valutazione ad un studente per id (ClsVoti --> Dictionary)");
                Console.WriteLine("10) Calcola la media totale di tutti i voti (ClsVoti --> Dictionary)");
                Console.WriteLine("11) Trova lo/gli studente/i con voto più alto (ClsVoti --> Dictionary)");
            } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 11);

            return scelta;
        }
    }
}
