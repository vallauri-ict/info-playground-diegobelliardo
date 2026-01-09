using BibliotecaSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaInterfacce
{
    internal class Libro : ContenutoMultimediale, IPrestabile
    {
        private string _autore;
        private int _numeroPagine;
        private string _casaEditrice;

        // Proprietà interfaccia
        public bool InPrestito { get; set; }
        public string UtenteInPrestito { get; set; }
        public DateTime? DataPrestito { get; set; }

        public int DurataPrestito { get { return 30; } }

        public string Autore { get => _autore; set => _autore = value; }
        public int NumeroPagine { get => _numeroPagine; set => _numeroPagine = value; }
        public string CasaEditrice { get => _casaEditrice; set => _casaEditrice = value; }

        
        public Libro(string titolo, int annoPubblicazione, string categoria, 
            decimal valoreCommerciale, string autore, int numeroPagine, string casaEditrice) 
            : base(titolo, annoPubblicazione, categoria, valoreCommerciale)
        {
            _autore = autore;
            _numeroPagine = numeroPagine;
            _casaEditrice = casaEditrice;
            InPrestito = false;
        }

        public override string OttieniTipo()
        {
            return "Libro";
        }

        public override string OttieniDescrizione()
        {
            string stato = InPrestito ? $" [IN PRESTITO a {UtenteInPrestito}]" : " [DISPONIBILE]";
            return base.OttieniDescrizione() + $" | Autore: {Autore}" +
                $" | Pagine: {NumeroPagine} | Ed: {CasaEditrice}"+stato;
        }

        // Metodi dell'Interfaccia
        public void Presta(string nomeUtente, DateTime dataPrestito)
        {
            if (!InPrestito)
            {
                InPrestito = true;
                UtenteInPrestito = nomeUtente;
                DataPrestito = dataPrestito;
            }
        }
        public void Restituisci()
        {
            InPrestito = false;
            UtenteInPrestito = null;
            DataPrestito = null;
        }
        public bool IsPrestutoScaduto()
        {
            if (!InPrestito || DataPrestito is null)
                return false;

            return (DateTime.Now - DataPrestito.Value).Days > DurataPrestito;
        }


    }
}
