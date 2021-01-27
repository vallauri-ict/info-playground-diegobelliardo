using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EsStagisti
{
    class clsAlunno : clsPersona
    {
        #region attributi

        protected static int progressivo = 0;
        private readonly string matricola;
        private char classe;
        private char sezione;
        private string specializzazione;
        
        #endregion

        public char Classe
        {
            get => classe;
            set => classe = Convert.ToChar(value);
        }

        public string Matricola => matricola;

        public char Sezione
        {
            get => sezione;
            set => sezione = Convert.ToChar(value);
        }

        public string Specializzazione
        {
            get => specializzazione;
            set => specializzazione = value;
        }

        public clsAlunno(string nome, string cognome, string città) : base(nome, cognome, città)
        {
        }

        public override string visualizza()
        {
            throw new NotImplementedException();
        }
    }
}
