using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaInterfacce
{
    /// <summary>
    /// Classe base astratta per contenuto generico
    /// </summary>
    internal abstract class ContenutoMultimediale
    {
        private string _titolo;
        private int _annoPubblicazione;
        private string _categoria;
        private decimal _valoreCommerciale;
        private string _codiceIdentificativo;

        public string Titolo { get => _titolo; set => _titolo = value; }
        public int AnnoPubblicazione { get => _annoPubblicazione; set => _annoPubblicazione = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public decimal ValoreCommerciale { get => _valoreCommerciale; set => _valoreCommerciale = value; }
        public string CodiceIdentificativo { get => _codiceIdentificativo; set => _codiceIdentificativo = value; }

        protected ContenutoMultimediale(string titolo, int annoPubblicazione, string categoria, decimal valoreCommerciale)
        {
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Categoria = categoria;
            ValoreCommerciale = valoreCommerciale;
            CodiceIdentificativo = Guid.NewGuid().ToString().Substring(0,8);
        }

        public virtual string OttieniDescrizione()
        {
            return $"[{CodiceIdentificativo}] {Titolo} ({AnnoPubblicazione}) " +
                $"- {Categoria} - €{ValoreCommerciale:F2}";
        }
        public abstract string OttieniTipo();
    }
}
