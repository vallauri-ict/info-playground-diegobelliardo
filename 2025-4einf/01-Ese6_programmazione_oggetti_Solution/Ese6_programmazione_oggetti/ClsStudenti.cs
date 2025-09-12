using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ese6_programmazione_oggetti
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
      | + VisualizzaStud(): void {static}                            |
      | + AggiungiStudente(stud: ClsStudenti): void {static}         |
      | + RimuoviStudente(stud: ClsStudenti): void {static}          |
      | + CercaStudenteNome(nome: string): void {static}             |
      | + CercaStudentePos(int: pos): void {static}                  |
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
                    if (Convert.ToInt32(value[i]) < 48 || Convert.ToInt32(value[i]) < 97 || Convert.ToInt32(value[i]) < 122)
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
                    cognome = value;
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
                    if (Convert.ToInt32(value[i]) < 48 || Convert.ToInt32(value[i]) < 97 || Convert.ToInt32(value[i]) < 122)
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
                    throw new NumBelowZeroException("Errore: il prezzo deve essere maggiore o uguale a 0!");
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
        public static void VisualizzaStud()
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
        /// Aggiunge lo studente alla lista degli studenti
        /// </summary>
        /// <param name="stud">Lo studente da aggiungere (nome, cognome, età)</param>
        public static void AggiungiStudente(ClsStudenti stud)
        {
            studenti.Add(stud);
        }

        /// <summary>
        /// Rimuove uno studente alla lista degli studenti
        /// </summary>
        /// <param name="stud">Lo studente (nome, cognome, età) da rimuovere</param>
        public static void RimuoviStudente(ClsStudenti stud)
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


        /// <summary>
        /// Cerca uno studente nella lista degli studenti in base al nome
        /// </summary>
        /// <param name="nome">Il nome dello studente da cercare</param>
        public static void CercaStudenteNome(string nome)
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
        /// Cerca uno studente nella lista degli studenti in base alla posizione
        /// </summary>
        /// <param name="pos">La posizione nella lista dello studente da cercare</param>
        public static void CercaStudentePos(int pos)
        {
            if (studenti.Count > 0)
            {
                int i = 0;
                bool trovato = false;
                while ( i < studenti.Count && !trovato)
                {
                    if (i == pos)
                    {
                        trovato = true;
                    }
                    i++;
                }
                if (trovato)
                {
                    Console.WriteLine($"\n\nLo studente in posizione '{pos}' è stato trovato con i seguente dati:\nNome: {studenti[i - 1].Nome}, Cognome: {studenti[i - 1].Cognome}, Eta: {studenti[i - 1].Eta}");
                }
                else
                {
                    Console.WriteLine($"\n\nLo studente in posizione '{pos}' non esiste");
                }
            }
            else
            {
                Console.WriteLine($"\n\nImpossibile cercare lo studente in posizione '{pos}' perchè la lista è vuota");
            }
        }
    }
}
