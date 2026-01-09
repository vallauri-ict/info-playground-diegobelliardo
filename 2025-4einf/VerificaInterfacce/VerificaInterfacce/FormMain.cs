using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaSolution
{
    public partial class FormMain : Form
    {
        private BibliotecaManager _biblioteca;

        public FormMain()
        {
            InitializeComponent();
            _biblioteca = new BibliotecaManager();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Inizializza i ComboBox per i tipi di contenuto
            
            // Inserisci alcuni dati di esempio
            InserisciDatiEsempio();
            
            // Aggiorna le visualizzazioni
            AggiornaCatalogo();
            AggiornaListaPrestiti();
        }

        private void InserisciDatiEsempio()
        {
            // Inserisci alcuni contenuti di esempio
            _biblioteca.AggiungiContenuto(new Libro(
                "Il nome della rosa", 1980, "Narrativa", 18.50m,
                "Umberto Eco", 503, "Bompiani"
            ));

            _biblioteca.AggiungiContenuto(new Libro(
                "1984", 1949, "Narrativa", 15.00m,
                "George Orwell", 328, "Mondadori"
            ));

            _biblioteca.AggiungiContenuto(new DVD(
                "Inception", 2010, "Film", 12.99m,
                "Christopher Nolan", 148, "Fantascienza"
            ));

            _biblioteca.AggiungiContenuto(new DVD(
                "Il Padrino", 1972, "Film", 14.99m,
                "Francis Ford Coppola", 175, "Drammatico"
            ));

            _biblioteca.AggiungiContenuto(new Rivista(
                "Focus", 2024, "Divulgazione scientifica", 4.50m,
                "Mondadori", 12, "Mensile"
            ));

            _biblioteca.AggiungiContenuto(new Rivista(
                "National Geographic", 2020, "Divulgazione scientifica", 5.00m,
                "National Geographic Society", 8, "Mensile"
            ));

            _biblioteca.AggiungiContenuto(new Audiolibro(
                "Sapiens: Da animali a dèi", 2014, "Saggistica", 19.90m,
                "Luigi Marangoni", 960, "Yuval Noah Harari"
            ));

            _biblioteca.AggiungiContenuto(new CDMusicale(
                "The Dark Side of the Moon", 1973, "Musica", 16.99m,
                "Pink Floyd", 10, "Rock progressivo"
            ));

            _biblioteca.AggiungiContenuto(new CDMusicale(
                "Abbey Road", 1969, "Musica", 15.99m,
                "The Beatles", 17, "Rock"
            ));
        }

        private void cmbTipoContenuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aggiorna le etichette dei campi specifici in base al tipo selezionato
            
            }
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                // Validazione dati comuni
                if (string.IsNullOrWhiteSpace(txtTitolo.Text))
                {
                    MessageBox.Show("Inserire il titolo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAnno.Text, out int anno) || anno < 1000 || anno > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Anno non valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtValore.Text, out decimal valore) || valore < 0)
                {
                    MessageBox.Show("Valore commerciale non valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tipo = cmbTipoContenuto.SelectedItem.ToString();
                ContenutoMultimediale nuovoContenuto = null;

                switch (tipo)
                {
                    case "Libro":
                        
                        break;

                    case "DVD":
                        
                        break;

                    case "Rivista":
                        
                        break;

                    case "Audiolibro":
                        
                        break;

                    case "CD Musicale":
                        
                        break;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'inserimento: {ex.Message}", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PulisciCampiInserimento()
        {
            txtTitolo.Clear();
            txtAnno.Clear();
            txtCategoria.Clear();
            txtValore.Clear();
            txtSpec1.Clear();
            txtSpec2.Clear();
            txtSpec3.Clear();
        }

        private void AggiornaCatalogo()
        {
            
        }

        private void btnMostraTutto_Click(object sender, EventArgs e)
        {
            AggiornaCatalogo();
        }

        private void btnFiltraTipo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFiltraCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void AggiornaListaPrestiti()
        {
            // Aggiorna lista contenuti disponibili
            

            // Aggiorna lista contenuti in prestito
            
        }

        private void btnPresta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRestituisci_Click(object sender, EventArgs e)
        {
            
        }

        private void lstContenutiDisponibili_DoubleClick(object sender, EventArgs e)
        {
            // Doppio click su un contenuto disponibile per copiarne il codice
            
        }

        private void lstContenutiInPrestito_DoubleClick(object sender, EventArgs e)
        {
            // Doppio click su un contenuto in prestito per copiarne il codice
            
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            // Genera e mostra le statistiche
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.AppendLine("╔═══════════════════════════════════════════════════════════════╗");
            sb.AppendLine("║         STATISTICHE BIBLIOTECA COMUNALE                       ║");
            sb.AppendLine("╚═══════════════════════════════════════════════════════════════╝");
            sb.AppendLine();
            
            // Statistiche generali
            sb.AppendLine("STATISTICHE GENERALI");
            sb.AppendLine("────────────────────────────────────────────────────────────────");
           
            
            // Statistiche per tipo
            sb.AppendLine("DISTRIBUZIONE PER TIPO");
            sb.AppendLine("────────────────────────────────────────────────────────────────");
            
            
            // Statistiche prestiti
            sb.AppendLine("STATO PRESTITI");
            sb.AppendLine("────────────────────────────────────────────────────────────────");
            
            
            // Lista prestiti scaduti
            
            txtStatistiche.Text = sb.ToString();
        }
    }
}
