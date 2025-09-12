using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese6_programmazione_oggetti_app_integrata
{
    /*UML ClsStudenti:

      ```
      +--------------------------------------------------------------+
      |                         ClsStudenti                          |
      +--------------------------------------------------------------+
      | - studenti: List<Studente> {static}                          |
      | - nome: string                                               |
      | - cognome: string                                            |
      | - eta: int                                                   |
      +--------------------------------------------------------------+
      | + ClsStudneti(nome: string, cognome: string, eta: int): void |
      | + VisualizzaStud(): void                                      |
      | + AggiungiStudente(stud: ClsStudenti): void                   |
      | + RimuoviStudente(stud: ClsStudenti): void                    |
      | + CercaStudente(nome: string): void                           |
      | + OrdinaListaStudPerCognome(): void                           |
      | + FiltraListaPerEtaSup(eta: int): void                        |
      +--------------------------------------------------------------+
      ```
     */
    internal class ClsStudenti
    {
        /// <summary>
        /// Lista della classe ClsStudenti
        /// </summary>
        private static List<ClsStudenti> studenti = new List<ClsStudenti>();

        /// <summary>
        /// Attributi degli object della classe ClsStudenti
        /// </summary>
        private string nome = "";
        private string cognome = "";
        private int eta;


        // Costruttore
        public ClsStudenti(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }

        /// <summary>
        /// Attributo Nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (Convert.ToInt32(value[i]) < 97 || Convert.ToInt32(value[i]) > 122)
                    {
                        throw new InvalidStringException("Il nome può cotenere solo lettere!");
                    }
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new EmptyStringException("Il nome non può essere vuoto o nullo!");
                }
                try
                {
                    nome = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Errore: un eccezzione di tipo generico è stata lanciata!");
                }
            }
        }

        private class EmptyStringException : Exception
        {
            public EmptyStringException(string message) : base(message) { }
        }

        private class InvalidStringException : Exception
        {
            public InvalidStringException(string message) : base(message) { }
        }


        /// <summary>
        /// Attributo Cognome
        /// </summary>
        public string Cognome
        {
            get { return cognome; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (Convert.ToInt32(value[i]) < 97 || Convert.ToInt32(value[i]) > 122)
                    {
                        throw new InvalidStringException("Il cognome può cotenere solo lettere!");
                    }
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new EmptyStringException("Il cognome non può essere vuoto o nullo!");
                }
                try
                {
                    cognome = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Errore: un eccezzione di tipo generico è stata lanciata!");
                }
            }
        }

        /// <summary>
        /// Attributo Eta
        /// </summary>
        public int Eta
        {
            get { return eta; }
            set
            {
                if (eta < 0)
                {
                    throw new NumBelowZeroException("Errore: l'età deve essere maggiore o uguale a 0!");
                }
                try
                {
                    eta = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Errore: un eccezzione di tipo generico è stata lanciata!");
                }
            }
        }

        private class NumBelowZeroException : Exception
        {
            public NumBelowZeroException(string message) : base(message) { }
        }

        /// <summary>
        /// Visualizza la lista degli studenti
        /// </summary>
        public void VisualizzaStud()
        {
            if (studenti.Count > 0)
            {
                for (int i = 0; i < studenti.Count; i++)
                {
                    Console.WriteLine($"Nome: {studenti[i].Nome}, Cognome: {studenti[i].Cognome}, Età: {studenti[i].Eta}");
                }
            }
            else
            {
                Console.WriteLine("La lista è vuota");
            }
        }

        /// <summary>
        /// Aggiunge uno studente alla lista degli studenti
        /// </summary>
        /// <param name="stud">Lo studente (nome, cognome, età) da aggiungere</param>
        public void AggiungiStudente(ClsStudenti stud)
        {
            studenti.Add(stud);
            ClsRubrica.AggiungiStudente(stud);
            Console.WriteLine($"\n\nLo studente è stato aggiunto con i seguenti dato:\nNome: {stud.Nome}, Cognome: {stud.Cognome}, Eta: {stud.Eta}");
        }

        /// <summary>
        /// Rimuove uno studente alla lista degli studenti
        /// </summary>
        /// <param name="stud">Lo studente (nome, cognome, età) da rimuovere</param>
        public void RimuoviStudente(ClsStudenti stud)
        {
            if (studenti.Count > 0)
            {
                int pos = -1;
                for (int i = 0; i < studenti.Count; i++)
                {
                    if (stud.Nome == studenti[i].Nome && stud.Cognome == studenti[i].Cognome)
                    {
                        pos = i;
                    }
                }

                if (pos > -1)
                {
                    studenti.RemoveAt(pos);
                    ClsRubrica.RimuoviStudente(pos);
                    Console.WriteLine($"\n\nLo studente che aveva i seguenti dati è stato rimosso:\nNome: {stud.Nome}, Cognome: {stud.Cognome}, Eta: {stud.Eta}");
                }
                else
                {
                    Console.WriteLine("\n\nLo studente non è stato rimosso dalla list perchè non è stato trovato");
                }
            }
            else
            {
                Console.WriteLine("\n\nImpossibile cercare lo studente perchè la lista è vuota");
            }
        }

        public void ModificaStud(ClsStudenti studModificato)
        {
            Nome = studModificato.Nome;
            Cognome = studModificato.Cognome;
            Eta = studModificato.Eta;
        }


        /// <summary>
        /// Cerca uno studente nella lista degli studenti
        /// </summary>
        /// <param name="nome">Il nome dello studente da cercare</param>
        public void CercaStudente(string nome)
        {
            if (studenti.Count > 0)
            {
                ClsStudenti studTrovato = studenti.Find(stud => stud.Nome == nome);
                if (studTrovato == null)
                {
                    Console.WriteLine($"\n\nLo studente con nome '{nome}' non è stato trovato nella lista");
                }
                else
                {
                    Console.WriteLine($"\n\nLo studente con nome '{nome}' è stato trovato con i seguente dati:\nNome: {studTrovato.Nome}, Cognome: {studTrovato.Cognome}, Eta: {studTrovato.Eta}");
                }
            }
            else
            {
                Console.WriteLine($"\n\nImpossibile cercare lo studente con nome '{nome}' perchè la lista è vuota");
            }
        }


        /// <summary>
        /// Ordina la lista degli studenti per cognome
        /// </summary>
        public void OrdinaListaStudPerCognome()
        {
            if (studenti.Count > 0)
            {
                studenti.Sort((stud1, stud2) =>
                {
                    int confronto = stud1.Cognome.CompareTo(stud2.Cognome);
                    return confronto;
                });
                Console.WriteLine("L'ordinamento della lista per cognome è avvenuto con successo\n\nEcco una preview della lista:");
                VisualizzaStud();
            }
            else
            {
                Console.WriteLine("Impossibile ordinare la lista per cognome perchè la lista è vuota");
            }
        }


        /// <summary>
        /// Filtro la lista degli studenti a partire da un età che sceglie l'utente
        /// </summary>
        /// <param name="eta"></param>
        public void FiltraListaPerEtaSup(int eta)
        {
            if (studenti.Count > 0)
            {
                List<ClsStudenti> studEtaSup = studenti.FindAll(stud => stud.eta > eta);
                if (studEtaSup.Count > 0)
                {
                    Console.WriteLine($"\n\nEcco la lista degli studenti che hanno un età superiore a {eta}:\n");
                    for (int i = 0; i < studEtaSup.Count; i++)
                    {

                        Console.WriteLine($"Nome: {studEtaSup[i].Nome}, Cognome: {studEtaSup[i].Cognome}, Eta: {studEtaSup[i].Eta}");
                    }
                }
                else
                {
                    Console.WriteLine($"\n\nImpossibile filtrare la lista per età maggiore di {eta} perchè la lista non contiene studenti che hanno età maggiore di {eta}");
                }
            }
            else
            {
                Console.WriteLine($"\n\nImpossibile filtrare la lista per età perchè la lista è vuota");
            }
        }

        /// <summary>
        /// Indica il puntatore alla list studenti degli studenti
        /// </summary>
        /// <returns>la lista degli studenti</returns>
        public static List<ClsStudenti> RitornaListaStud()
        {
            return studenti;
        }
    }
}
