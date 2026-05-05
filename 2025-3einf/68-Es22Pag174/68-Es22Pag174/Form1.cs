using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _68_Es22Pag174
{
    struct Giocatore
    {
        public string CodiceGiocatore { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Squadra { get; set; }
        public string Ruolo { get; set; }
        public string NGoal { get; set; }
    }
    public partial class Form1 : Form
    {
        Giocatore[] giocatori = new Giocatore[100];
        public Form1()
        {
            InitializeComponent();
            LeggiFile("Calciatori.dat");
            dgvElencoGiocatori.DataSource = giocatori;
        }

        private void LeggiFile(string nomeFile)
        {
            int i = 0;
            using (StreamReader sr = new StreamReader(nomeFile))
            {
                string riga;
                while ((riga = sr.ReadLine()) != null)
                {
                    string[] dati = new string[6];
                    dati = riga.Split('|');
                    if (dati[5] is null)
                    {
                        MessageBox.Show("Errore nella struttura del file","ERRORE: file corrotto",
                                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    giocatori[i].CodiceGiocatore = dati[0];
                    giocatori[i].Cognome = dati[1];
                    giocatori[i].Nome = dati[2];
                    giocatori[i].Squadra = dati[3];
                    giocatori[i].Ruolo = dati[4];
                    giocatori[i].NGoal = dati[5];
                    i++;
                }
                Array.Resize(ref giocatori, i);
            }
        }

        private void btnContaGiocatori_Click(object sender, EventArgs e)
        {
            string numeroGoal=txtNumeroGoal.Text;
            int count = 0;
            for (int i = 0; i < giocatori.Length; i++)
            {
                if (Convert.ToInt32(giocatori[i].NGoal) > Convert.ToInt32(numeroGoal))
                {
                    count++;
                }
            }
            MessageBox.Show($"Il numero dei giocatori che hanno fatto più di {numeroGoal} goal sono: {count}");
        }
    }
}
