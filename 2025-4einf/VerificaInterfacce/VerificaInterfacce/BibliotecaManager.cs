using BibliotecaSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaInterfacce
{
    /// <summary>
    /// Gestisce l'intero catalogo della biblioteca e le operazioni sui prestiti
    /// </summary>
    internal class BibliotecaManager
    {
        private List<ContenutoMultimediale> _catalogo;
        //per ricerca veloce per codice
        private Dictionary<string, ContenutoMultimediale> _catalogoDictionary;

        public BibliotecaManager()
        {
            _catalogo = new List<ContenutoMultimediale>();
            _catalogoDictionary = new Dictionary<string, ContenutoMultimediale>();
        }

        public void AggiungiContenuto(ContenutoMultimediale contenuto)
        {
            _catalogo.Add(contenuto);
            _catalogoDictionary.Add(contenuto.CodiceIdentificativo, contenuto);
        }

        public List<ContenutoMultimediale> OttieniCatalogo()
        {
            return _catalogo;
            //OPPURE - return new List<ContenutoMultimediale>(_catalogo);
        }

        public List<ContenutoMultimediale> CercaPerTipo(string tipo)
        {
            return _catalogo.Where(c => c.OttieniTipo().
                Equals(tipo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<ContenutoMultimediale> CercaPerCategoria(string categoria)
        {
            return _catalogo.
                Where(c => c.Categoria.Contains(categoria)).ToList();
        }
        public List<ContenutoMultimediale> CercaPerTitolo(string titolo)
        {
            return _catalogo.
                Where(c => c.Titolo.Contains(titolo)).ToList();
        }

        /// <summary>
        /// Contenuti non in prestito
        /// </summary>
        /// <returns></returns>
        public List<ContenutoMultimediale> OttieniContenutiDisponibili()
        {
            List<ContenutoMultimediale> disponibili = new List<ContenutoMultimediale>();

            foreach (var contenuto in _catalogo)
            {
                if (contenuto is IPrestabile prestabile)
                {
                    if (!prestabile.InPrestito)
                    {
                        if (contenuto is Rivista rivista)
                        {
                            if(rivista.IsPrestabile())
                                disponibili.Add(contenuto);
                        }
                        else
                        {
                            disponibili.Add(contenuto);
                        }
                    }
                }
            }
            return disponibili;
        }

        /// <summary>
        /// Presta contenuto ad un utente
        /// </summary>
        /// <param name="codiceContenuto"></param>
        /// <param name="nomeUtente"></param>
        /// <returns></returns>
        public bool PrestaContenuto(string codiceContenuto, string nomeUtente)
        {
            if (_catalogoDictionary.ContainsKey(codiceContenuto))
            {
                var contenuto = _catalogoDictionary[codiceContenuto];

                if (contenuto is IPrestabile prestabile)
                {
                    // Verifica se non è già in prestito
                    if (!prestabile.InPrestito)
                    {
                        //Controllo per le riviste
                        if (contenuto is Rivista rivista && !rivista.IsPrestabile())
                        {
                            return false; //troppo recente
                        }
                        prestabile.Presta(nomeUtente,DateTime.Now);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool RestituisciContenuto(string codiceContenuto)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Dictionary<string, int> OttieniStatisticheTipo()
        {
            // TODO
            throw new NotImplementedException();
        }

        public decimal OttieniValoreTotale()
        {
            // TODO
            throw new NotImplementedException();
        }
        public int OttieniNumeroContenuti()
        {
            return _catalogo.Count;
        }

        public List<ContenutoMultimediale> OttieniPrestitiScaduti()
        {
            // TODO
            throw new NotImplementedException();
        }

        public ContenutoMultimediale CercaContenutoPerCodice()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
