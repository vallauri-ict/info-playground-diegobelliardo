using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_M1E1
{
    internal class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public string Nome { 
            get => nome; 
            set => nome = value; 
        }
        public string Cognome { 
            get => cognome; 
            set => cognome = value; 
        }
        public int Eta { 
            //get => eta; 
            get {  
                return eta; 
            }
            
            set {
                if (value > 0)
                {
                    eta = value;
                }
            }
        }

        public Persona(string nome, string cognome, int eta)
        {
            // Uso le property - OK !!!
            Nome = nome;
            Cognome = cognome;
            Eta = eta;

            // Uso gli attributi - NON OK
            /*
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            */
        }
    }
}
