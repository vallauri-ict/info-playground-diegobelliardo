using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockTest
{
    internal class DatabaseMockList : IDatabaseMock
    {
        // Studente
        List<Studente> studenti = new List<Studente>();
        public void AddStudente(Studente studente)
        {
            studenti.Add(studente);
        }
        public List<Studente> GetStudenti()
        {
            return studenti;
        }
        public void UpdateStudente(int id, Studente studenteAggiornato)
        {
            int index = studenti.FindIndex(st => st.Id == id);

            studenti[index] = studenteAggiornato;
        }

        // AnniScolastici
        List<AnnoScolastico> anni = new List<AnnoScolastico>();
        public void AddAnnoScolastico(AnnoScolastico anno)
        {
            anni.Add(anno);
        }
        public List<AnnoScolastico> GetAnniScolastici()
        {
            return anni;
        }
        public void UpdateAnnoScolastico(int id, AnnoScolastico annoAggiornato)
        {
            int index = anni.FindIndex(anno => anno.Id == id);

            anni[index] = annoAggiornato;
        }

        // Sezioni
        List<Sezione> sezioni = new List<Sezione>();
        public void AddSezione(Sezione sezione)
        {
            sezioni.Add(sezione);
        }
        public List<Sezione> GetSezioni()
        {
            return sezioni;
        }
        public void UpdateSezione(int id, Sezione sezioneAggiornata)
        {
            int index = sezioni.FindIndex(sezione => sezione.Id == id);

            sezioni[index] = sezioneAggiornata;
        }

        // Classi
        List<Classe> classi = new List<Classe>();
        public void AddClasse(Classe classe)
        {
            classi.Add(classe);
        }
        public List<Classe> GetClassi()
        {
            return classi;
        }
        public void UpdateClasse(int id, Classe classeAggiornata)
        {
            int index = classi.FindIndex(classe => classe.Id == id);

            classi[index] = classeAggiornata;
        }

        // Materie
        List<Materia> materie = new List<Materia>();
        public void AddMateria(Materia materia)
        {
            materie.Add(materia);
        }
        public List<Materia> GetMaterie()
        {
            return materie;
        }
        public void UpdateMateria(int id, Materia materiaAggiornata)
        {
            int index = materie.FindIndex(materia => materia.Id == id);

            materie[index] = materiaAggiornata;
        }

        // Voti
        List<Voto> voti = new List<Voto>();
        public void AddVoto(Voto voto)
        {
            voti.Add(voto);
        }
        public List<Voto> GetVoti()
        {
            return voti;
        }

        public void UpdateVoto(int id, Voto votoAggiornato)
        {
            int index = voti.FindIndex(voto => voto.Id == id);

            voti[index] = votoAggiornato;
        }

        // Operazioni specifiche
        public List<Studente> GetStudentiPerClasse(int classeId)
        {
            List<Studente> studentiClasse = new List<Studente>();

            foreach (Studente studente in studenti)
            {
                if (studente.ClasseId == classeId)
                    studentiClasse.Add(studente);
            }

            return studentiClasse;
        }

        public List<Voto> GetVotiPerStudente(int studenteId)
        {
            List<Voto> votiStudente = new List<Voto>();

            foreach (Voto voto in voti)
            {
                if (voto.StudenteId == studenteId)
                    votiStudente.Add(voto);
            }

            return votiStudente;
        }

        public double CalcolaMediaVotiPerClasseEMateria(int classeId, int materiaId)
        {
            List<Studente> studentiSelezionati = new List<Studente>();

            List<int> ids = new List<int>();

            List<Voto> votiSelezionati = new List<Voto>();

            double somma = 0;
            int cont = 0;

            foreach (Studente studente in studenti)
            {
                if (studente.ClasseId == classeId)
                    ids.Add(studente.Id);
            }

            foreach (Voto voto in voti)
            {
                if (voto.MateriaId == materiaId)
                {
                    if (ids.Contains(voto.StudenteId))
                    {
                        somma += voto.Valore;
                        cont++;
                    }
                }
            }

            return (double)somma / cont;
        }
    }
}
