using System;

namespace BibliotecaSolution
{
    /// <summary>
    /// Interfaccia per i contenuti che possono essere prestati
    /// </summary>
    public interface IPrestabile
    {
        bool InPrestito { get; set; }
        string UtenteInPrestito { get; set; }
        DateTime? DataPrestito { get; set; }
        
        // Ottiene la durata massima del prestito in giorni
        int DurataPrestito { get; }
        
        // Presta il contenuto a un utente
        void Presta(string nomeUtente, DateTime dataPrestito);
        
        // Restituisce il contenuto
        void Restituisci();
        
        // Verifica se il prestito è scaduto
        bool IsPrestutoScaduto();
    }
}
