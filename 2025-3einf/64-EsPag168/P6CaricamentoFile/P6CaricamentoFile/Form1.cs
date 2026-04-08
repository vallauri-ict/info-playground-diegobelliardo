using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace P6CaricamentoFile
{
    struct Libri
    {
        public string codLibro;
        public string titolo;
        public string autore;
        public string casaEditrice;
        public string genere;
        public string costo;

        public override string ToString()
        {
            return $"{codLibro};{titolo};{autore};{casaEditrice};{genere};{costo}";
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScrivi_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Libri.dat"))
            {
                Libri libro = new Libri();
                string risp = "";
                do
                {

                    libro.codLibro = Interaction.InputBox("Inserisci Il Codice:");
                    libro.titolo = Interaction.InputBox("Inserisci Il Titolo:");
                    libro.autore = Interaction.InputBox("Inserisci l'autore:");
                    libro.casaEditrice = Interaction.InputBox("Inserisci la casa editrice:");
                    libro.genere = Interaction.InputBox("Inserisci Il Genere:");
                    libro.costo = Interaction.InputBox("Inserisci Il Costo:");

                    sw.WriteLine(libro.ToString());

                    risp = Interaction.InputBox("Vuoi continuare?(S/N)");

                } while (risp.ToUpper() == "S");
            }
        }

        private void btnLeggi_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("Libri.dat"))
            {
                string riga = "";

                while ((riga = sr.ReadLine()) != null)
                {
                    string[] libro = new string[6];
                    libro = riga.Split(';');
                    string msg = "Dati del libro:\n";
                    foreach (string s in libro)
                    {
                        msg += s + "\n";
                    }
                    MessageBox.Show(msg);
                }
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string codice = txtCodice.Text;
            bool trovato = false;
            string[] libro = new string[6];

            using (StreamReader sr = new StreamReader("Libri.dat"))
            {
                string riga = "";

                while ((riga = sr.ReadLine()) != null && !trovato)
                {
                    libro = riga.Split(';');
                    if (libro[0] == codice)
                    {
                        trovato = true;
                    }
                }
            }

            if (trovato)
            {
                string msg = "Trovato il libro:\n";
                foreach (string s in libro)
                {
                    msg += s + "\n";
                }
                MessageBox.Show(msg);
            }
            else MessageBox.Show("Libro non trovato");

        }
    }
}
