using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_VerificaOOP
{
    internal class Persona
    {
        private string _nome;
        private string _cognome;
        private int _eta;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public int Eta
        {
            get => _eta;
            set
            {
                if (value > 0)
                {
                    _eta = value;
                }
                else
                {
                    throw new ArgumentException("ATTENZIONE: L'età deve essere maggiore di 0");
                }
            }
        }

        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public void Visualizza()
        {
            Console.WriteLine($"Nome: {Nome}\nCognome: {Cognome}\nEtà: {Eta}\n");
        }
    }
}
