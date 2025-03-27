using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GestioneStudenti
{
    public partial class FormMain : Form
    {
        string[] datiStudenti =
        {
            "1 Barberis Giovanni 1A",
            "2 Gotta Luigino 2B",
            "3 Mori Mario 2A",
            "4 Pio Mimmo 3A",
            "5 Liberale Patrizia 3B",
            "6 Gotta Maria 3A",
            "7 Moramarco Mario 1A",
            "8 Pio Mimma 2B",
        };

        public struct studente
        {
            public int matricola;   // chiave primaria
            public string cognome;
            public string nome;
            public string classe;
        }

        studente[] studenti;
        int nStudenti = 0;

        string[] datiValutazioni =
        {
            "Inglese 7 O 1",
            "Informatica 5 L 2",
            "Informatica 4 S 3",
            "Sistemi 9 O 4",
            "Inglese 5 S 5",
            "Sistemi 3 L 6",
            "Sistemi 8 O 7",
            "Italiano 6 S 8",
            "Sistemi 8 O 8",
        };

        public struct valutazione
        {
            public string materia;
            public int voto;
            public string tipo;
            public int matricola;
        };

        valutazione[] valutazioni;
        int nValutazioni = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1120, 600);
            settaDgv(dgvStudenti, "MATRICOLA COGNOME NOME CLASSE");
            caricaDatiStudenti();
            nStudenti = datiStudenti.Length;
            settaDgv(dgvValutazioni, "MATERIA VOTO TIPO MATRICOLA");
            caricaDatiValutazioni();
            nValutazioni = datiValutazioni.Length;
        }

        private void settaDgv(DataGridView dgv, string intestazioni)
        {
            string[] intestazioniArray = intestazioni.Split(' ');
            dgv.ColumnCount = intestazioniArray.Length;
            for (int i = 0; i < intestazioniArray.Length; i++)
                dgv.Columns[i].HeaderText = intestazioniArray[i];
            dgv.RowHeadersVisible = false;
            dgv.ClearSelection();
        }

        private void caricaDatiStudenti()
        {
            List<string> listClassi = new List<string>();
            string[] dati = new string[3];
            for (int i = 0; i < datiStudenti.Length; i++)
            {
                nStudenti++;
                Array.Resize(ref studenti, nStudenti);
                dati = datiStudenti[i].Split(' ');
                studenti[nStudenti - 1].matricola = Convert.ToInt32(dati[0]);
                cmbMatricole.Items.Add(dati[0]);
                cmbMatricole.SelectedIndex = 0;
                studenti[nStudenti - 1].cognome = dati[1];
                studenti[nStudenti - 1].nome = dati[2];
                studenti[nStudenti - 1].classe = dati[3];
                dgvStudenti.Rows.Add(dati[0], dati[1], dati[2], dati[3]);
                if (!listClassi.Contains(dati[3]))
                    listClassi.Add(dati[3]);
            }
            listClassi.Sort();
            cmbClasse.DataSource = listClassi;
        }

        private void caricaDatiValutazioni()
        {
            string[] dati = new string[3];
            for (int i = 0; i < datiValutazioni.Length; i++)
            {
                nValutazioni++;
                Array.Resize(ref valutazioni, nValutazioni);
                dati = datiValutazioni[i].Split(' ');
                valutazioni[nValutazioni - 1].materia = dati[0];
                valutazioni[nValutazioni - 1].voto = Convert.ToInt32(dati[1]);
                valutazioni[nValutazioni - 1].tipo = dati[2];
                valutazioni[nValutazioni - 1].matricola = Convert.ToInt32(dati[3]);
                dgvValutazioni.Rows.Add(dati[0], dati[1], dati[2], dati[3]);
                //Popolo anche cmbMaterie
                if (!cmbMaterie.Items.Contains(dati[0]))
                    cmbMaterie.Items.Add(dati[0]);
            }

        }

        private void btnInserisciStudente_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text!="" && txtNome.Text!="" && cmbClasse.Text!="")
            {
                nStudenti++;
                Array.Resize(ref studenti, nStudenti);
                studenti[nStudenti - 1].matricola = nStudenti;
                studenti[nStudenti - 1].cognome = txtCognome.Text;
                studenti[nStudenti - 1].nome = txtNome.Text;
                studenti[nStudenti - 1].classe = cmbClasse.Text;
                dgvStudenti.Rows.Add(nStudenti, txtCognome.Text, txtNome.Text, cmbClasse.Text);
                txtCognome.Text = txtNome.Text = cmbClasse.Text = "";
            }
            else
            {
                MessageBox.Show("Inserisci tutti i dati!", "ATTENZIONE", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRicStudMat_Click(object sender, EventArgs e)
        {
            int matricola = 0;
            bool trovato = false;

            if (int.TryParse(Interaction.InputBox("Inserisci la matricola:"), out matricola) || matricola != 0)
            {
                for (int i = 0; i < nStudenti; i++)
                {
                    if (studenti[i].matricola == matricola)
                    {
                        trovato = true;
                        MessageBox.Show(studenti[i].cognome + " " + studenti[i].nome);
                    }
                }
                if (!trovato)
                    MessageBox.Show("Matricola non trovata!");
            }
            else
            {
                MessageBox.Show("Inserisci una matricola valida!", "ATTENZIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRicStudCogN_Click(object sender, EventArgs e)
        {
            string cognome = Interaction.InputBox("Inserisci il cognome:");
            string nome = Interaction.InputBox("Inserisci il nome:");

            bool trovato = false;
            for (int i = 0; i < nStudenti; i++)
            {
                if (studenti[i].cognome == cognome && studenti[i].nome == nome)
                {
                    trovato = true;
                    MessageBox.Show("Trovato con matricola: "+studenti[i].matricola.ToString());
                    // Posso eventualmente inserire un break per fermare il ciclo
                }
            }
            if (!trovato)
                MessageBox.Show("Studente non trovato!");
        }

        private void btnOrdinaStudNominativo_Click(object sender, EventArgs e)
        {
            studente temp;
            int posMin = 0;
            string nominativo1, nominativo2;

            for (int i = 0; i < nStudenti - 1; i++)
            {
                posMin = i;
                for (int j = i + 1; j < nStudenti; j++)
                {
                    nominativo2 = studenti[j].cognome + " " + studenti[j].nome;
                    nominativo1 = studenti[posMin].cognome + " " + studenti[posMin].nome;
                    if (nominativo2.CompareTo(nominativo1) < 0)
                        posMin = j;
                }
                if (posMin != i)
                {
                    temp = studenti[i];
                    studenti[i] = studenti[posMin];
                    studenti[posMin] = temp;
                }
            }
            dgvStudenti.Rows.Clear();
            for (int i = 0; i < nStudenti; i++)
            {
                dgvStudenti.Rows.Add(studenti[i].matricola, studenti[i].cognome, studenti[i].nome, studenti[i].classe);
            }
        }
    }
}
