using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.CompilerServices;

namespace MockTest
{
    public class DatabaseMock : IDatabaseMock
    {
        // Studente
        public void AddStudente(Studente studente)
        {
            
        }
        public List<Studente> GetStudenti()
        {
            
            return studenti;
        }
        public void UpdateStudente(int id, Studente studenteAggiornato)
        {
            
        }

        private void SaveStudentFile(List<Studente> studenti)
        {
            
        }

        // AnniScolastici
        public void AddAnnoScolastico(AnnoScolastico anno)
        {
            
        }
        public List<AnnoScolastico> GetAnniScolastici()
        {
            
        }
        public void UpdateAnnoScolastico(int id, AnnoScolastico annoAggiornato)
        {
            
        }

        private void SaveYearFile(List<AnnoScolastico> anni)
        {
            
        }

        // Sezioni
        public void AddSezione(Sezione sezione)
        {
            
        }
        public List<Sezione> GetSezioni()
        {
            
        }
        public void UpdateSezione(int id, Sezione sezioneAggiornata)
        {
            
        }

        private void SaveSectionFile(List<Sezione> sezioni)
        {
            
        }

        // Classi
        public void AddClasse(Classe classe)
        {
            
        }
        public List<Classe> GetClassi()
        {
            
        }
        public void UpdateClasse(int id, Classe classeAggiornata)
        {
            
        }

        private void SaveClassFile(List<Classe> classi)
        {
            
        }

        // Materie
        public void AddMateria(Materia materia)
        {
            
        }
        public List<Materia> GetMaterie()
        {
            
        }
        public void UpdateMateria(int id, Materia materiaAggiornata)
        {
            
        }

        private void SaveSubjectFile(List<Materia> materie)
        {
            
        }

        // Voti
        public void AddVoto(Voto voto)
        {
            
        }
        public List<Voto> GetVoti()
        {
            
        }

        public void UpdateVoto(int id, Voto votoAggiornato)
        {
            
        }

        private void SaveVoteFile(List<Voto> voti)
        {
            
        }

        // Operazioni specifiche
        public List<Studente> GetStudentiPerClasse(int classeId)
        {
            
        }

        public List<Voto> GetVotiPerStudente(int studenteId)
        {
            
        }

        public double CalcolaMediaVotiPerClasseEMateria(int classeId, int materiaId)
        {
            
        }
    }
}
