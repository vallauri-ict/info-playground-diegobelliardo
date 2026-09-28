using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_M2E3b
{
    internal class Prodotto
    {
        private string nome;
        private double prezzo;

        public string Nome { get => nome; set => nome = value; }
        public double Prezzo
        {
            get => prezzo;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Il valore non può essere negativo", nameof(prezzo));
                }
                prezzo = value;
            }
        }

        public Prodotto(string nome, double prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }
        public void AggiornaPrezzo(double prezzo)
        {
            Prezzo = prezzo;
        }
        public void AggiornaPrezzo(double prezzo, double sconto)
        {
            Prezzo = Prezzo - prezzo * sconto;
        }
    }
}
