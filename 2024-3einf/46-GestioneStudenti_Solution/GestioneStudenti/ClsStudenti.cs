using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestioneStudenti.ClsStudenti;

namespace GestioneStudenti
{
    public class ClsStudenti
    {
        static string[] _datiStudenti =
{
            "1 Barberis Giovanni 1A",
            "2 Gotta Luigino 2B",
            "3 Mori Mario 2A",
            "4 Pio Mimmo 3A",
            "5 Liberale Patrizia 3B",
            "6 Gotta Maria 3A",
            "7 Moramarco Mario 1A",
            "8 Pio Mimma 2B",
        };

        public struct Studente
        {
            public int matricola;   // chiave primaria
            public string cognome;
            public string nome;
            public string classe;
        }

        public static Studente[] Studenti;
        static int _nStudenti = 0;

        public static List<string> CaricaDatiStudenti()
        {
            List<string> listClassi = new List<string>();
            string[] dati = new string[3];
            for (int i = 0; i < _datiStudenti.Length; i++)
            {
                _nStudenti++;
                Array.Resize(ref Studenti, _nStudenti);
                dati = _datiStudenti[i].Split(' ');
                Studenti[_nStudenti - 1].matricola = Convert.ToInt32(dati[0]);
                Studenti[_nStudenti - 1].cognome = dati[1];
                Studenti[_nStudenti - 1].nome = dati[2];
                Studenti[_nStudenti - 1].classe = dati[3];
                if (!listClassi.Contains(dati[3]))
                    listClassi.Add(dati[3]);
            }
            listClassi.Sort();
            return listClassi;
        }

        public static Studente InserisciStudente(string cogn, string nome, string classe)
        {
            _nStudenti++;
            Array.Resize(ref Studenti, _nStudenti);
            Studente stud = new Studente
            {
                matricola = _nStudenti,
                cognome = cogn,
                nome = nome,
                classe = classe
            };
            Studenti[_nStudenti - 1] = stud;
            return stud;
        }

        public static int RicercaStudentePerMatricola(int matricola)
        {
            for (int i = 0; i < Studenti.Length; i++)
            {
                if (Studenti[i].matricola == matricola)
                    return i;
            }
            return -1;
        }

        public static int RicercaStudentePerCognomeNome(string cognome, string nome)
        {
            for (int i = 0; i < Studenti.Length; i++)
            {
                if (Studenti[i].cognome == cognome && Studenti[i].nome == nome)
                    return i;
            }
            return -1;
        }

        public static void OrdinaPerNominativo()
        {
            Studente temp;
            int posMin = 0;
            string nominativo1, nominativo2;

            for (int i = 0; i < _nStudenti - 1; i++)
            {
                posMin = i;
                for (int j = i + 1; j < _nStudenti; j++)
                {
                    nominativo2 = Studenti[j].cognome + " " + Studenti[j].nome;
                    nominativo1 = Studenti[posMin].cognome + " " + Studenti[posMin].nome;
                    if (nominativo2.CompareTo(nominativo1) < 0)
                        posMin = j;
                }
                if (posMin != i)
                {
                    temp = Studenti[i];
                    Studenti[i] = Studenti[posMin];
                    Studenti[posMin] = temp;
                }
            }
        }

        public static int CercaMatricola(string cognome, string nome)
        {
            for (int i = 0; i < _nStudenti; i++)
            {
                if (Studenti[i].cognome == cognome && 
                    Studenti[i].nome == nome)
                    return Studenti[i].matricola;
            }
            return -1;
        }
    }
}
