using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ObjectTest
{
    internal class Padre
    {
        
        public Padre() : this("pippo")
        {
        }
        public Padre(string name): this(3)
        {
            nome = name;
        }
        public Padre(int eta)
        {
            this.eta = eta;
        }

        public Padre(double eta)
        {

        }

        public void compila(string nome)
        {
            this.nome = nome;
        }

        public void compila(string nome, double eta)
        {

        }

        public void compila(double eta, string nome)
        {
            Nome=nome;
            Console.WriteLine(Nome);
        }
        private int eta;
        private string coloreCapelli;
        private int numeroScarpe;

        public int Eta {  
            get { return eta; } 
            set {
                if (value >= 0)
                {
                    eta = value;
                }
                else eta=0;
            }
        }


        private string nome = string.Empty;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (isValid(value))
                    nome = value;
                else
                    throw new Exception("Nome NOK");
            }
        }

        public string ColoreCapelli {
            get { return coloreCapelli; } 
            set => coloreCapelli = value; 
        }
        public int NumeroScarpe { 
            get => numeroScarpe; 
            set => numeroScarpe = value; 
        }

        private bool isValid(string value)
        {
            throw new NotImplementedException();
        }
    }
}
