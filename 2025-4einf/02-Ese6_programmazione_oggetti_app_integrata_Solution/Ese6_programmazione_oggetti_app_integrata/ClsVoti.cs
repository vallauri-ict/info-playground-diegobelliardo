using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese6_programmazione_oggetti_app_integrata
{
    /*UML ClsVoti:

      ```
      +-----------------------------------------------------------------------+
      |                                     ClsVoti                           |
      +-----------------------------------------------------------------------+
      | - voti: Dictionary<int, double> {static}                              |
      +-----------------------------------------------------------------------+
      | + AggiungiOrAggiornaVotoAStudId(id: int, voto: double): void {static} |
      | + CalcolaMediaVotiTot(): void {static}                                |
      | + TrovaStudMediaMax(): void {static}                                  |
      +-----------------------------------------------------------------------+
      ```
     */
    internal class ClsVoti
    {
        /// <summary>
        /// Dictionary della classe ClsVoti
        /// </summary>
        private static Dictionary<int, double> voti = new Dictionary<int, double>();

        /// <summary>
        /// Aggiunge o aggiorna un voto associato ad uno studente tramite id 
        /// nella dictionary dei voti
        /// </summary>
        /// <param name="id">L'id dello studente</param>
        /// <param name="voto">Il voto da associare allo studente</param>
        public static void AggiungiOrAggiornaVotoAStudId(int id, double voto)
        {
            if (id < ClsRubrica.RitornaRubricaStud().Count)
            {
                bool trovato = false;
                int i = 0;
                while (i < voti.Count && !trovato)
                {
                    if (voti.Keys.ElementAt(i) == id)
                    {
                        trovato = true;
                    }
                    i++;
                }
                if (trovato)
                {
                    Console.WriteLine($"\n\nVoto '{voti[i]}' aggiornato in '{voto}' con successo allo studente con id '{id}'");
                    voti[i - 1] = voto;
                }
                else
                {
                    voti.Add(id, voto);
                    Console.WriteLine($"\n\nVoto '{voto}' aggiunto con successo allo studente con id '{id}'");
                }
            }
            else
            {
                Console.WriteLine($"\n\nImpossibile aggiungere una valutazione allo studente con id '{id}' perchè non esiste");
            }
        }

        /// <summary>
        /// Calcola la media di tutti i voti presenti nella dictionary dei voti
        /// </summary>
        public static void CalcolaMediaVotiTot()
        {
            if (voti.Count > 0)
            {
                double somma = 0;
                for (int i = 0; i < voti.Count; i++)
                {
                    somma += voti[i];
                }
                double media = somma / voti.Count;

                Console.WriteLine($"\n\nLa media totale di tutti i voti è {media.ToString("N02")}");
            }
            else
            {
                Console.WriteLine($"\n\nImpossibile calcolare la media perchè la dictionary è vuota");
            }
        }

        /// <summary>
        /// Trova lo/gli studente/i con il voto più alto presenti nella dictionary dei voti
        /// </summary>
        public static void TrovaStudMediaMax()
        {
            if (voti.Count > 0)
            {
                double votoMax = int.MinValue;
                List<int> id = new List<int>();
                for (int i = 0; i < voti.Count; i++)
                {
                    if (voti[i] >= votoMax)
                    {
                        if (voti[i] > votoMax)
                        {
                            id = new List<int>();
                        }
                        id.Add(voti.Keys.ElementAt(i));
                        votoMax = voti[i];
                    }
                }

                Dictionary<int, ClsStudenti> rubrica = ClsRubrica.RitornaRubricaStud();
                if (id.Count > 1)
                {
                    for (int i = 0; i < id.Count; i++)
                    {
                        for (int j = 0; j < rubrica.Count; j++)
                        {
                            if (id[i] == rubrica.Keys.ElementAt(j))
                            {
                                Console.WriteLine($"Lo studente con il voto più alto, cioè {votoMax}, è stato trovato con id '{id[i]}' e con i seguenti dati:\nNome: {rubrica[j].Nome}, Cognome: {rubrica[j].Cognome}, Eta: {rubrica[j].Eta}\n");
                            }
                        }
                    }
                }
                else
                {
                    bool trovato = false;
                    int i = 0;
                    while (i < rubrica.Count && !trovato)
                    {
                        if (id[0] == rubrica.Keys.ElementAt(i))
                        {
                            trovato = true;
                            Console.WriteLine($"Lo studente con il voto più alto, cioè {votoMax}, è stato trovato con id '{id[0]}' e con i seguenti dati:\nNome: {rubrica[i].Nome}, Cognome: {rubrica[i].Cognome}, Eta: {rubrica[i].Eta}");
                        }
                        i++;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Impossibile trovare lo studente con il voto più alto perchè la dictionary è vuota");
            }
        }
    }
}
