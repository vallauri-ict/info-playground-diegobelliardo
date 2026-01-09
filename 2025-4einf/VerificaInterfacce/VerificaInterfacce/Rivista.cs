using BibliotecaSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaInterfacce
{
    internal class Rivista : ContenutoMultimediale, IPrestabile
    {
        private string _editore;
        private int _numeroEdizione;
        private string _periodicità; // settimanale, mensile, ecc...
        private DateTime _dataEmissione;

        // Proprietà Interfaccia
        public bool InPrestito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UtenteInPrestito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DataPrestito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int DurataPrestito { get { return 14; } } // 14 giorni

        public string Editore { get => _editore; set => _editore = value; }
        public int NumeroEdizione { get => _numeroEdizione; set => _numeroEdizione = value; }
        public string Periodicità { get => _periodicità; set => _periodicità = value; }
        public DateTime DataEmissione { get => _dataEmissione; set => _dataEmissione = value; }

        public Rivista(string titolo, int annoPubblicazione, string categoria, decimal valoreCommerciale, 
            string editore, int numeroEdizione, string periodicità, DateTime dataEmissione):
            base (titolo,annoPubblicazione, categoria,valoreCommerciale)
        {
            Editore = editore;
            NumeroEdizione = numeroEdizione;
            Periodicità = periodicità;
            DataEmissione = dataEmissione;
            InPrestito = false;
        }

        public bool IsPrestutoScaduto()
        {
            throw new NotImplementedException();
        }

        public override string OttieniTipo()
        {
            return "Rivista";
        }

        public override string OttieniDescrizione()
        {
            string prestabile = IsPrestabile() ? "" : " [NON PRESTABILE - edizione recente]";
            string stato = InPrestito ? $" [IN PRESTITO a {UtenteInPrestito}]" : " [DISPONIBILE]";
            return base.OttieniDescrizione() + $" | Editore: {Editore} | N° {NumeroEdizione} | {Periodicità}" +
                $"{prestabile}" + (IsPrestabile() ? stato : "");
        }

        public bool IsPrestabile()
        {
            // Le riviste degli ultimi 30 giorni non sono prestabili
            bool isPrestable = DateTime.Now > DataEmissione.AddDays(30) ? true : false;
            return isPrestable;
                
        }
        public void Presta(string nomeUtente, DateTime dataPrestito)
        {
            throw new NotImplementedException();
        }

        public void Restituisci()
        {
            throw new NotImplementedException();
        }

    }
}
