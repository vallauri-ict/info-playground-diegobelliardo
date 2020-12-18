using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_PersoneStudenti
{
    class Persona
    {
        private string nome,cognome,sesso;
        private int eta;

        public void SetAttributs(string nome,string cognome,string sesso, int eta)
        {
            if (true)  // qua potete fare eventuali controlli sui parametri
            {
                this.nome = nome;
                this.cognome = cognome;
                this.sesso = sesso;
                this.eta = eta;
            }
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCognome()
        {
            return this.cognome;
        }

        public string GetSesso()
        {
            return this.sesso;
        }

        public int GetEta()
        {
            return this.eta;
        }
    }
}
