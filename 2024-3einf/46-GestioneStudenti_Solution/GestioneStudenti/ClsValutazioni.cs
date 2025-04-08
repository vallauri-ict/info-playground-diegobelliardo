using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestioneStudenti.ClsValutazioni;

namespace GestioneStudenti
{
    public class ClsValutazioni
    {
        static string[] _datiValutazioni =
        {
            "Inglese 7 O 1",
            "Informatica 8 L 2",
            "Informatica 4 S 3",
            "Sistemi 3 O 4",
            "Inglese 5 S 5",
            "Sistemi 3 L 6",
            "Sistemi 7 O 7",
            "Italiano 9 S 8",
            "Sistemi 10 O 8",
            "Italiano 8 S 1",
            "Sistemi 8 S 2",
            "Inglese 9 O 2"
        };

        public struct Valutazione
        {
            public string materia;
            public int voto;
            public string tipo;
            public int matricola;
        };

        public static Valutazione[] Valutazioni;
        static int _nValutazioni = 0;

        public static List<string> CaricaDatiValutazioni()
        {
            List<string> listMaterie = new List<string>();
            string[] dati = new string[3];
            for (int i = 0; i < _datiValutazioni.Length; i++)
            {
                _nValutazioni++;
                Array.Resize(ref Valutazioni, _nValutazioni);
                dati = _datiValutazioni[i].Split(' ');
                Valutazioni[_nValutazioni - 1].materia = dati[0];
                Valutazioni[_nValutazioni - 1].voto = Convert.ToInt32(dati[1]);
                Valutazioni[_nValutazioni - 1].tipo = dati[2];
                Valutazioni[_nValutazioni - 1].matricola = Convert.ToInt32(dati[3]);
                // Popolo anche listMaterie
                if (!listMaterie.Contains(dati[0]))
                    listMaterie.Add(dati[0]);
            }
            return listMaterie;
        }

        public static Valutazione InserisciValutazione
                        (string materia, string tipo, int voto, int matricola)
        {
            _nValutazioni++;
            Array.Resize(ref Valutazioni, _nValutazioni);
            Valutazione val = new Valutazione
            {
                materia = materia,
                tipo = tipo,
                voto = voto,
                matricola = matricola
            };
            Valutazioni[_nValutazioni - 1] = val;
            return val;
        }

        public static double MediaPerMateria(string materia)
        {
            int somma = 0;
            int contatore = 0;
            for (int i = 0; i < _nValutazioni; i++)
            {
                if (Valutazioni[i].materia == materia)
                {
                    somma += Valutazioni[i].voto;
                    contatore++;
                }
            }
            if (contatore > 0)
                return (double)somma / contatore;
            else
                return -1;
        }

        public static int ContaVotiPerTipoPerStudente(int matricola, string tipo)
        {
            int contatore = 0;
            for (int i = 0; i < _nValutazioni; i++)
            {
                if (Valutazioni[i].matricola == matricola &&
                    Valutazioni[i].tipo == tipo)
                    contatore++;
            }
            return contatore;
        }

        public static void OrdinaPerMatricola()
        {
            int posMin;
            Valutazione aus;

            for (int i = 0; i < _nValutazioni; i++)
            {
                posMin = i;
                for (int j = i+1; j < _nValutazioni; j++)
                {
                    if (Valutazioni[posMin].matricola > Valutazioni[j].matricola)
                    {
                        posMin = j;
                    }
                }
                if (posMin != i)
                {
                    aus = Valutazioni[posMin];
                    Valutazioni[posMin] = Valutazioni[i];
                    Valutazioni[i] = aus;
                }
            }
        }

        public static string RotturaMatricolaValutazioni()
        {
            string retVal = "";
            int cont = 1;
            for (int i = 0; i < _nValutazioni - 1; i++)
            {
                if (Valutazioni[i].matricola == Valutazioni[i+1].matricola)
                    cont++;
                else
                {
                    retVal += ConcatenaDatiStudente(Valutazioni[i].matricola, cont) + "\n";
                    cont = 1;
                }
            }
            retVal += ConcatenaDatiStudente(Valutazioni[Valutazioni.Length - 1].matricola, cont);
            return retVal;
        }
        private static string ConcatenaDatiStudente(int matricola, int nValutazioni)
        {
            int posStudente = ClsStudenti.RicercaStudentePerMatricola(matricola);
            ClsStudenti.Studente stud = ClsStudenti.Studenti[posStudente];
            string nominativo = $"{stud.cognome} {stud.nome}";
            return $"{nominativo}: {nValutazioni}";
        }


        public static string CercaStudMediaMaggiore()
        {
            int cont = 1, sommaVotiStudente = Valutazioni[0].voto;
            double mediaAlta = double.MinValue;
            int matricolaStudenteMediaAlta = Valutazioni[0].matricola;
            for (int i = 0; i < _nValutazioni - 1; i++)
            {
                if (Valutazioni[i].matricola == Valutazioni[i + 1].matricola)
                {
                    cont++;
                    sommaVotiStudente += Valutazioni[i + 1].voto;
                }
                else
                {
                    double mediaStudente = (double)sommaVotiStudente / cont;
                    if (mediaStudente > mediaAlta)
                    {
                        matricolaStudenteMediaAlta = Valutazioni[i].matricola;
                        mediaAlta = mediaStudente;
                    }
                    cont = 1;
                    sommaVotiStudente = Valutazioni[i + 1].voto;
                }
            }
            double mediaUltimoStudente = (double)sommaVotiStudente / cont;
            if (mediaUltimoStudente > mediaAlta)
            {
                matricolaStudenteMediaAlta = Valutazioni[Valutazioni.Length - 1].matricola;
                mediaAlta = mediaUltimoStudente;
            }

            int posStudente = ClsStudenti.RicercaStudentePerMatricola(matricolaStudenteMediaAlta);
            ClsStudenti.Studente stud = ClsStudenti.Studenti[posStudente];
            string nominativo = $"{stud.cognome} {stud.nome}";
            
            return $"{nominativo}: {mediaAlta.ToString("0.00")}";
        }

    }
}
