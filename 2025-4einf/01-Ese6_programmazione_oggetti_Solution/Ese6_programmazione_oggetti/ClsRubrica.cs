using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese6_programmazione_oggetti
{
    /*UML ClsRubrica:

      ```
      +--------------------------------------------------------------+
      |                         ClsRubrica                           |
      +--------------------------------------------------------------+
      | - rubrica: Dictionary<int, ClsStudenti> {static}             |
      +--------------------------------------------------------------+
      | + VisualizzaStud(): void {static}                            |
      | + AggiungiStudente(stud: ClsStudenti): void {static}         |
      | + RimuoviStudente(id: int): void {static}                    |
      | + CercaStudente(id: int): void {static}                      |
      +--------------------------------------------------------------+
      ```
     */
    internal class ClsRubrica
    {
        /// <summary>
        /// Dictionary della classe ClsRubrica
        /// </summary>
        private static Dictionary<int, ClsStudenti> rubrica = new Dictionary<int, ClsStudenti>();

        /// <summary>
        /// Visualizza tutti gli studenti persenti nella dictionary della rubrica
        /// </summary>
        public static void VisualizzaStud()
        {
            if (rubrica.Count > 0)
            {
                for (int i = 0; i < rubrica.Count; i++)
                {
                    Console.WriteLine($"Id: {rubrica.Keys.ElementAt(i)}, Nome: {rubrica[i].Nome}, Cognome: {rubrica[i].Cognome}, Età: {rubrica[i].Eta}");
                }
            }
            else
            {
                Console.WriteLine("La lista è vuota");
            }
        }

        /// <summary>
        /// Aggiunge un studente alla dictionary della rubrica
        /// </summary>
        /// <param name="stud">Lo studente (nome, cognome, età) da aggiungere</param>
        public static void AggiungiStudente(ClsStudenti stud)
        {
            rubrica.Add(rubrica.Count, stud);
        }

        /// <summary>
        /// Rimuove un studente alla dictionary della rubrica
        /// </summary>
        /// <param name="id">Lo studente (nome, cognome, età) da rimuovere</param>
        public static void RimuoviStudente(int id)
        {
            if (rubrica.Count > 0)
            {
                Console.WriteLine($"\n\nLo studente con id '{id}' è stato rimosso correttamente\n");
                rubrica.Remove(id);
            }
            else
            {
                Console.WriteLine($"\n\nImpossibile rimuovere lo studente con id {id} perchè la rubrica è vuota");
            }
        }

        /// <summary>
        /// Cerca lo studente tramite l'id
        /// </summary>
        /// <param name="id">L'id da cercare</param>
        public static void CercaStudente(int id)
        {
            if (rubrica.Count > 0)
            {
                rubrica.TryGetValue(id, out ClsStudenti studTrovato);
                if (studTrovato == null)
                {
                    Console.WriteLine($"\n\nLo studente con id '{id}' non è stato trovato nella rubrica");
                }
                else
                {
                    Console.WriteLine($"\n\nLo studente con id '{id}' è stato trovato con i seguenti dati:\nNome: {studTrovato.Nome}, Cognome: {studTrovato.Cognome}, Eta: {studTrovato.Eta}");
                }
            }
            else
            {
                Console.WriteLine($"\n\nImpossibile cercare lo studente con id '{id}' perchè la rubrica è vuota");
            }
        }
    }
}
