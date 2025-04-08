using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GestioneStudenti
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1120, 640);
            settaDgv(dgvStudenti, "MATRICOLA COGNOME NOME CLASSE");
            visualizzaDatiStudentiClassiMatricole();
            settaDgv(dgvValutazioni, "MATERIA VOTO TIPO MATRICOLA");

            ClsValutazioni.CaricaDatiValutazioni();
            visualizzaDatiValutazioni();

            rdbScritto.Checked = true;
            cmbMaterie.SelectedIndex = 0;
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

        private void visualizzaDatiStudentiClassiMatricole()
        {
            // carico combo classi
            List<string> listClassi = ClsStudenti.CaricaDatiStudenti();
            cmbClasse.DataSource = listClassi;

            // carico dati dgv e combo matricole
            for (int i = 0; i < ClsStudenti.Studenti.Length; i++)
            {
                ClsStudenti.Studente s = ClsStudenti.Studenti[i];
                cmbMatricole.Items.Add(s.matricola);
                dgvStudenti.Rows.Add(s.matricola, s.cognome, s.nome, s.classe);
            }
            cmbMatricole.SelectedIndex = 0;
        }

        private void visualizzaDatiValutazioni()
        {
            dgvValutazioni.Rows.Clear();
            for (int i = 0; i < ClsValutazioni.Valutazioni.Length; i++)
            {
                ClsValutazioni.Valutazione v = ClsValutazioni.Valutazioni[i];
                dgvValutazioni.Rows.Add(v.materia, v.voto,v.tipo, v.matricola);
            }
        }

        private void btnInserisciStudente_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text!="" && txtNome.Text!="" && cmbClasse.Text!="")
            {
                ClsStudenti.Studente stud = ClsStudenti.InserisciStudente(txtCognome.Text, txtNome.Text, cmbClasse.Text);
                dgvStudenti.Rows.Add(stud.matricola, stud.cognome, stud.nome, stud.classe);
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

            if (int.TryParse(Interaction.InputBox("Inserisci la matricola:"), out matricola) || matricola != 0)
            {
                int pos = ClsStudenti.RicercaStudentePerMatricola(matricola);
                if (pos != -1)
                {
                    ClsStudenti.Studente stud = ClsStudenti.Studenti[pos];
                    MessageBox.Show(stud.cognome + " " + stud.nome);
                }
                else
                    MessageBox.Show("Matricola non trovata!");
            }
            else
                MessageBox.Show("Inserisci una matricola valida!", "ATTENZIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRicStudCogN_Click(object sender, EventArgs e)
        {
            string cognome = Interaction.InputBox("Inserisci il cognome:");
            string nome = Interaction.InputBox("Inserisci il nome:");
            int pos = ClsStudenti.RicercaStudentePerCognomeNome(cognome, nome);
            if (pos != -1)
            {
                MessageBox.Show("Trovato con matricola: " + ClsStudenti.Studenti[pos].matricola);
            }
            else
                MessageBox.Show("Studente non trovato!");
        }

        private void btnOrdinaStudNominativo_Click(object sender, EventArgs e)
        {
            ClsStudenti.OrdinaPerNominativo();
            dgvStudenti.Rows.Clear();
            for (int i = 0; i < ClsStudenti.Studenti.Length; i++)
            {
                ClsStudenti.Studente stud = ClsStudenti.Studenti[i];
                dgvStudenti.Rows.Add(stud.matricola, stud.cognome, stud.nome, stud.classe);
            }
        }

        private void btnContaStudClasse_Click(object sender, EventArgs e)
        {
            //Svolto a casa
        }
        private void btnContaVotiStudClasse_Click(object sender, EventArgs e)
        {
            //Svolto a casa
        }

        private void btnInserisciVoto_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if (cmbMatricole.Text != "" && cmbMaterie.Text != "" )
            {
                // Possiamo farlo così o con else if, non cambia nulla
                if (rdbOrale.Checked) tipo = "O";
                if (rdbScritto.Checked) tipo = "S";
                if (rdbLaboratorio.Checked) tipo = "L";
                ClsValutazioni.Valutazione v = ClsValutazioni.InserisciValutazione(
                                                    cmbMaterie.Text, 
                                                    tipo, 
                                                    Convert.ToInt32(nudVoto.Value), 
                                                    Convert.ToInt32(cmbMatricole.Text));
                
                VisualizzaVoti(dgvValutazioni, v);
            }
            else
            {
                MessageBox.Show("Inserisci tutti i dati!", "ATTENZIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VisualizzaVoti(DataGridView dgvValutazioni, ClsValutazioni.Valutazione v)
        {
            dgvValutazioni.Rows.Add(v.materia, v.voto, 
                                    v.tipo, v.matricola);

        }

        private void btnMediaPerMateria_Click(object sender, EventArgs e)
        {
            double media = ClsValutazioni.MediaPerMateria(cmbMaterie.Text);
            if (media != -1)
                MessageBox.Show("La media di " + cmbMaterie.Text + " è " + media);
            else
                MessageBox.Show("Nessun voto per la materia selezionata!");
        }

        private void btnContaVotiPerTipoPerStudente_Click(object sender, EventArgs e)
        {
            string cognome, nome;
            while ((cognome = Interaction.InputBox("Inserisci il cognome:")) == "") ;
            while ((nome = Interaction.InputBox("Inserisci il nome:")) == "") ;
            string tipo = "";
            if (rdbOrale.Checked) tipo = "O";
            if (rdbScritto.Checked) tipo = "S";
            if (rdbLaboratorio.Checked) tipo = "L";

            int matricola = ClsStudenti.CercaMatricola(cognome, nome);
            if (matricola != -1)
            {
                int nVoti = ClsValutazioni.ContaVotiPerTipoPerStudente(matricola, tipo);
                MessageBox.Show($"Lo studente {cognome} {nome} ha {nVoti} voti di tipo {tipo}");
            }
            else
            {
                MessageBox.Show("Studente non trovato!", "ATTENZIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnNumVotiPerStudente_Click(object sender, EventArgs e)
        {
            ClsValutazioni.OrdinaPerMatricola();
            visualizzaDatiValutazioni();
            string msg = ClsValutazioni.RotturaMatricolaValutazioni();
            MessageBox.Show(msg);
        }

        private void btnCercaStudenteMediaMaggiore_Click(object sender, EventArgs e)
        {
            ClsValutazioni.OrdinaPerMatricola();
            visualizzaDatiValutazioni();
            string msg = ClsValutazioni.CercaStudMediaMaggiore();
            MessageBox.Show(msg);
        }
    }
}
