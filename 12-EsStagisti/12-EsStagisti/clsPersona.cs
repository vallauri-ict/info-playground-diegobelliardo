using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EsStagisti
{
    abstract class clsPersona
    {
        #region attributi
        private string nome;
        private string cognome;
        private string città;
        #endregion

        public string Città
        {
            get => città;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    città = value;
                }
                else
                {
                    throw new Exception("Città non valida");
                }
            }
        }

        public string Cognome
        {
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("Cognome non valido");
                }
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Nome non valido");
                }
            }
        }

        protected clsPersona(string nome, string cognome, string città)
        {
            Nome = nome;
            Cognome = cognome;
            Città = città;
        }

        public abstract string visualizza();

    }
}
