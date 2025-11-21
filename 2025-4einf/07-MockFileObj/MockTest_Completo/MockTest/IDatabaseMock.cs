using System.Collections.Generic;

namespace MockTest
{
    public interface IDatabaseMock
    {
        // CRUD per Studenti
        void AddStudente(Studente studente);
        List<Studente> GetStudenti();
        void UpdateStudente(int id, Studente studenteAggiornato);

        // CRUD per AnniScolastici
        void AddAnnoScolastico(AnnoScolastico anno);
        List<AnnoScolastico> GetAnniScolastici();
        void UpdateAnnoScolastico(int id, AnnoScolastico annoAggiornato);

        // CRUD per Sezioni
        void AddSezione(Sezione sezione);
        List<Sezione> GetSezioni();
        void UpdateSezione(int id, Sezione sezioneAggiornata);

        // CRUD per Classi
        void AddClasse(Classe classe);
        List<Classe> GetClassi();
        void UpdateClasse(int id, Classe classeAggiornata);

        // CRUD per Materie
        void AddMateria(Materia materia);
        List<Materia> GetMaterie();
        void UpdateMateria(int id, Materia materiaAggiornata);

        // CRUD per Voti
        void AddVoto(Voto voto);
        List<Voto> GetVoti();
        void UpdateVoto(int id, Voto votoAggiornato);

        // Operazioni specifiche
        List<Studente> GetStudentiPerClasse(int classeId);
        List<Voto> GetVotiPerStudente(int studenteId);
        double CalcolaMediaVotiPerClasseEMateria(int classeId, int materiaId);
    }
}
