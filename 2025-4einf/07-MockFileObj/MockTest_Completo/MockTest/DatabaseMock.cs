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
            List<Studente> studenti = GetStudenti();

            studenti.Add(studente);
            SaveStudentFile(studenti);
        }
        public List<Studente> GetStudenti()
        {
            List<Studente> studenti = new List<Studente>();

            try
            {
                using (StreamReader sr = new StreamReader("studenti.txt"))
                {
                    string[] s;

                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            Studente studente = new Studente();

                            s= sr.ReadLine().Split(';');
                            if (s.Length != 5)
                                continue; // Salto le righe mal formate

                            studente.Id= int.Parse(s[0]);
                            studente.Nome = s[1];
                            studente.Cognome = s[2];
                            studente.DataNascita = DateTime.Parse(s[3]);
                            studente.ClasseId = int.Parse(s[4]);

                            studenti.Add(studente);
                        }
                        catch (FormatException)
                        {
                            //Salto righe con formato errato
                            continue;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // File non esiste ritorno la lista vuota
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Errore durante la lettura degli studenti: {ex.Message}", ex);
            }

            return studenti;
        }
        public void UpdateStudente(int id, Studente studenteAggiornato)
        {
            List<Studente> studenti = GetStudenti();
            int index=studenti.FindIndex(st => st.Id == id);

            studenti[index] = studenteAggiornato;
            SaveStudentFile(studenti);
        }

        private void SaveStudentFile(List<Studente> studenti)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("studenti.txt"))
                {
                    foreach (Studente studente in studenti)
                    {
                        string s = $"{studente.Id};{studente.Nome};{studente.Cognome};{studente.DataNascita};{studente.ClasseId}";
                        sw.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Errore durante il salvataggio degli studenti: {ex.Message}", ex);
            }
        }

        // AnniScolastici
        public void AddAnnoScolastico(AnnoScolastico anno)
        {
            List<AnnoScolastico> anni = GetAnniScolastici();

            anni.Add(anno);
            SaveYearFile(anni);
        }
        public List<AnnoScolastico> GetAnniScolastici()
        {
            List<AnnoScolastico> anni = new List<AnnoScolastico>();
            try
            {
                using (StreamReader sr = new StreamReader("anni_scolastici.txt"))
                {
                    string[] s;

                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            AnnoScolastico anno = new AnnoScolastico();

                            s= sr.ReadLine().Split(';');
                            if (s.Length != 2)
                                continue;

                            anno.Id=int.Parse(s[0]);
                            anno.Anno=int.Parse(s[1]);
                            anni.Add(anno);
                        }
                        catch (FormatException)
                        {
                            continue;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                //File non trovato
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Errore durante la lettura degli anni scolastici: {ex.Message}", ex);
            }

            return anni;
        }
        public void UpdateAnnoScolastico(int id, AnnoScolastico annoAggiornato)
        {
            List<AnnoScolastico> anni = GetAnniScolastici();
            int index = anni.FindIndex(anno => anno.Id == id);

            anni[index]=annoAggiornato;
            SaveYearFile(anni);

        }

        private void SaveYearFile(List<AnnoScolastico> anni)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("anni_scolastici.txt"))
                {
                    foreach (AnnoScolastico anno in anni)
                    {
                        string s = $"{anno.Id};{anno.Anno}";
                        sw.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Errore durante il salvataggio degli anni scolastici: {ex.Message}",ex);
            }   
        }

        // Sezioni
        public void AddSezione(Sezione sezione)
        {
            
        }
        public List<Sezione> GetSezioni()
        {
            return null;
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
            return null;
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
            return null;
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
            return null;
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
            return null;
        }

        public List<Voto> GetVotiPerStudente(int studenteId)
        {
            return null;
        }

        public double CalcolaMediaVotiPerClasseEMateria(int classeId, int materiaId)
        {
            return 0;
        }
    }
}
