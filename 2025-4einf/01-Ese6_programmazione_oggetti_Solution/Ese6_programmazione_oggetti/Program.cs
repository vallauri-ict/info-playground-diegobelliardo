using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese6_programmazione_oggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esercizio 6.1
            Console.WriteLine("** Esercizio 6.1 **\n\n");
            Console.WriteLine("Creo e aggiungo alla lista lo studList 1: (Nome: Gabriele, Cognome: Peano, Età: 19)");
            ClsStudenti studList1 = new ClsStudenti("Gabriele", "Peano", 19);
            ClsStudenti.AggiungiStudente(studList1);
            Console.WriteLine("Creo e aggiungo alla lista lo studList 2: (Nome: Matteo, Cognome: Marino, Età: 23)");
            ClsStudenti studList2 = new ClsStudenti("Matteo", "Marino", 23);
            ClsStudenti.AggiungiStudente(studList2);
            Console.WriteLine("Creo e aggiungo alla lista lo studList 3: (Nome: Lorenzo, Cognome: Mossello, Età: 54)");
            ClsStudenti studList3 = new ClsStudenti("Lorenzo", "Mossello", 54);
            ClsStudenti.AggiungiStudente(studList3);
            Console.WriteLine("Creo e aggiungo alla lista lo studList 4: (Nome: Simone, Cognome: Ferrero, Età: 87)");
            ClsStudenti studList4 = new ClsStudenti("Simone", "Ferrero", 87);
            ClsStudenti.AggiungiStudente(studList4);
            Console.WriteLine("Creo e aggiungo alla lista lo studList 5: (Nome: Elia, Cognome: Ambrogio, Età: 26)");
            ClsStudenti studList5 = new ClsStudenti("Elia", "Ambrogio", 26);
            ClsStudenti.AggiungiStudente(studList5);

            Console.WriteLine("\nInserisci il nome dello studente che vuoi rimuovere:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome dello studente che vuoi rimuovere:");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci l'età dello studente che vuoi rimuovere:");
            int eta = int.Parse(Console.ReadLine());
            ClsStudenti studDaRimuovere = new ClsStudenti(nome, cognome, eta);
            ClsStudenti.RimuoviStudente(studDaRimuovere);

            Console.WriteLine("\nEcco la lista degli studenti aggiornata:");
            ClsStudenti.VisualizzaStud();

            Console.WriteLine("\nInserisci il nome dello studente che vuoi cercare:");
            ClsStudenti.CercaStudenteNome(Console.ReadLine());

            Console.WriteLine("\nInserisci la posizione dello studente che vuoi rimuovere:");
            ClsStudenti.CercaStudentePos(int.Parse(Console.ReadLine()));

            // Esercizio 6.2
            Console.WriteLine("\n\n** Esercizio 6.2 **\n\n");
            Console.WriteLine("Creo e aggiungo alla dictionary lo studDictionary 1: (Nome: Mario, Cognome: Rossi, Età: 45)");
            ClsStudenti studDictionary1 = new ClsStudenti("Mario", "Rossi", 45);
            ClsRubrica.AggiungiStudente(studDictionary1);
            Console.WriteLine("Creo e aggiungo alla dictionary lo studDictionary 2: (Nome: Francesco, Cognome: Bianchi, Età: 35)");
            ClsStudenti studDictionary2 = new ClsStudenti("Francesco", "Bianchi", 35);
            ClsRubrica.AggiungiStudente(studDictionary2);
            Console.WriteLine("Creo e aggiungo alla dictionary lo studDictionary 3: (Nome: Gianfranco, Cognome: Verdi, Età: 78)");
            ClsStudenti studDictionary3 = new ClsStudenti("Gianfranco", "Verdi", 78);
            ClsRubrica.AggiungiStudente(studDictionary3);
            Console.WriteLine("Creo e aggiungo alla dictionary lo studDictionary 4: (Nome: Simone, Cognome: Barbero, Età: 24)");
            ClsStudenti studDictionary4 = new ClsStudenti("Simone", "Barbero", 56);
            ClsRubrica.AggiungiStudente(studDictionary4);
            Console.WriteLine("Creo e aggiungo alla dictionary lo studDictionary 5: (Nome: Giovanni, Cognome: Barberis, Età: 69)");
            ClsStudenti studDictionary5 = new ClsStudenti("Giovanni", "Barberis", 69);
            ClsRubrica.AggiungiStudente(studDictionary5);

            Console.WriteLine("\nEcco la dictionary degli studenti:");
            ClsRubrica.VisualizzaStud();

            Console.WriteLine("\nInserisci l'id dello studente che vuoi rimuovere:");
            ClsRubrica.RimuoviStudente(int.Parse(Console.ReadLine()));

            Console.WriteLine("\nEcco la dictionary degli studenti aggiornata:");
            ClsRubrica.VisualizzaStud();

            Console.WriteLine("\nInserisci l'id dello studente che vuoi cercare:");
            ClsRubrica.CercaStudente(int.Parse(Console.ReadLine()));

            Console.ReadKey();
        }
    }
}
