using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockTest
{
    public partial class FormMain : Form
    {
        DatabaseMockList dbl = new DatabaseMockList();
        //DatabaseMock dbl = new DatabaseMock();
        int idStudente, idAnno, idSezione, idClasse, idMateria, idVoto;

        public FormMain()
        {
            InitializeComponent();
        }
        // STUDENTI
        private void btnReadStudenti_Click(object sender, EventArgs e)
        {
            List<Studente> studenti = dbl.GetStudenti();

            lstStudente.Items.Clear();
            foreach (var studente in studenti)
            {
                lstStudente.Items.Add(studente);
            }

            btnAddStudente.Enabled= true;
            btnUpdateStudente.Enabled = true;
            btnGetStudentiPerClasse.Enabled= true;
        }

        private void btnAddStudente_Click(object sender, EventArgs e)
        {
            btnEseguiStudente.Text = "Aggiungi";
            txtIdStudente.Text = txtNomeStudente.Text = txtCognomeStudente.Text = txtDataNascitaStudente.Text = txtIdClasseStudente.Text = "";
            txtIdStudente.Enabled = txtNomeStudente.Enabled = txtCognomeStudente.Enabled = txtDataNascitaStudente.Enabled = txtIdClasseStudente.Enabled = true;
            grpStudente.Visible=true;
        }

        private void btnUpdateStudente_Click(object sender, EventArgs e)
        {
            if (lstStudente.SelectedIndex >= 0)
            {
                Studente studenteSelezionato = lstStudente.SelectedItem as Studente;
                txtIdStudente.Enabled = txtNomeStudente.Enabled = txtCognomeStudente.Enabled = txtDataNascitaStudente.Enabled = txtIdClasseStudente.Enabled = true;
                idStudente = studenteSelezionato.Id;
                btnEseguiStudente.Text = "Modifica";
                txtIdStudente.Text = studenteSelezionato.Id.ToString();
                txtIdStudente.Enabled = false;
                txtNomeStudente.Text = studenteSelezionato.Nome;
                txtCognomeStudente.Text = studenteSelezionato.Cognome;
                txtDataNascitaStudente.Text = studenteSelezionato.DataNascita.ToString("yyyy-MM-dd");
                txtIdClasseStudente.Text = studenteSelezionato.ClasseId.ToString();
                grpStudente.Visible = true;

            }
            else AlertWarning("Selezionare uno studente");
        }
        private void btnGetStudentiPerClasse_Click(object sender, EventArgs e)
        {
            btnEseguiStudente.Text = "Recupera";
            txtIdStudente.Enabled = txtNomeStudente.Enabled = 
                txtCognomeStudente.Enabled = txtDataNascitaStudente.Enabled = true;
            txtIdStudente.Text = txtNomeStudente.Text =
                txtCognomeStudente.Text = txtDataNascitaStudente.Text =
                txtIdClasseStudente.Text = "";
            grpStudente.Visible = true;
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            List<Studente> studenti = dbl.GetStudenti();

            if (btnEseguiStudente.Text == "Aggiungi")
            {
                Studente studente = new Studente();

                if (CheckStudentValidation())
                {
                    studente.Id = int.Parse(txtIdStudente.Text);
                    foreach (var student in studenti)
                    {
                        if (student.Id == studente.Id)
                        {
                            AlertWarning("ID già esistente");
                            return;
                        }
                    }
                    studente.Nome = txtNomeStudente.Text;
                    studente.Cognome = txtCognomeStudente.Text;
                    studente.DataNascita = DateTime.Parse(txtDataNascitaStudente.Text);
                    studente.ClasseId = int.Parse(txtIdClasseStudente.Text);

                    if (CheckClassIdExistence(studente.ClasseId))
                    {
                        dbl.AddStudente(studente);
                        AlertInformation("Studente aggiunto");
                    }
                    else
                    {
                        AlertWarning("ID Classe non esistente");
                        return;
                    }
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }
            else if (btnEseguiStudente.Text == "Modifica")
            {
                Studente studenteAggiornato = new Studente();

                if (CheckStudentValidation())
                {
                    studenteAggiornato.Id = int.Parse(txtIdStudente.Text);
                    studenteAggiornato.Nome = txtNomeStudente.Text;
                    studenteAggiornato.Cognome = txtCognomeStudente.Text;
                    studenteAggiornato.DataNascita = DateTime.Parse(txtDataNascitaStudente.Text);
                    studenteAggiornato.ClasseId = int.Parse(txtIdClasseStudente.Text);

                    if (CheckClassIdExistence(studenteAggiornato.ClasseId))
                    {
                        dbl.UpdateStudente(idStudente, studenteAggiornato);
                        AlertInformation("Studente modificato");
                    }
                    else
                    {
                        AlertWarning("ID classe non esistente");
                        return;
                    }
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }
            else
            {
                int idClasse;

                if (int.TryParse(txtIdClasseStudente.Text, out idClasse))
                {
                    if (CheckClassIdExistence(idClasse))
                    {
                        List<Studente> studentiRecuperati = dbl.GetStudentiPerClasse(idClasse);

                        lstStudente.Items.Clear();
                        foreach (var studente in studentiRecuperati)
                        {
                            lstStudente.Items.Add(studente);
                        }
                    }
                    else
                    {
                        AlertWarning("ID Classe non esistente");
                        return;
                    }
                }
                else{
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }
            txtIdStudente.Text = txtNomeStudente.Text =
                txtCognomeStudente.Text = txtDataNascitaStudente.Text =
                txtIdClasseStudente.Text = "";
            grpStudente.Visible = false;

            if (btnEseguiStudente.Text != "Recupera")
            {
                btnReadStudenti_Click(btnReadStudenti, e);
            }
        }

        private bool CheckStudentValidation()
        {
            if (txtIdStudente.Text != "" && txtNomeStudente.Text != "" &&
                txtCognomeStudente.Text != "" && txtDataNascitaStudente.Text != "" &&
                txtIdClasseStudente.Text != "")
            {
                if (int.TryParse(txtIdStudente.Text, out int tstInt1) && 
                    DateTime.TryParse(txtDataNascitaStudente.Text, out DateTime dateTest) &&
                    int.TryParse(txtIdClasseStudente.Text, out int tstInt2))
                    return true;
            }
            return false;
        }

        private bool CheckClassIdExistence(int id)
        {
            List<Classe> classi = dbl.GetClassi();

            foreach (Classe c in classi)
            {
                if (c.Id==id)
                {
                    return true;
                }
            }
            return false;
        }

        // ANNI SCOLASTICI
        private void btnReadAnno_Click(object sender, EventArgs e)
        {
            List<AnnoScolastico> anni = dbl.GetAnniScolastici();

            lstAnno.Items.Clear();
            foreach (var anno in anni)
            {
                lstAnno.Items.Add(anno);
            }
            btnAddAnno.Enabled = true;
            btnUpdateAnno.Enabled = true;
        }

        private void btnAddAnno_Click(object sender, EventArgs e)
        {
            btnEseguiAnni.Text = "Aggiungi";
            txtIdAnni.Text = txtAnnoAnni.Text = "";
            txtIdAnni.Enabled = true;
            grpAnno.Visible = true;
        }

        private void btnUpdateAnno_Click(object sender, EventArgs e)
        {
            if (lstAnno.SelectedIndex >= 0)
            {
                AnnoScolastico anno = lstAnno.SelectedItem as AnnoScolastico;

                //Modifiche
                btnEseguiAnni.Text = "Modifica";
                txtIdAnni.Text = anno.Id.ToString();
                txtIdAnni.Enabled = true;
                txtAnnoAnni.Text = anno.Anno.ToString();
                grpAnno.Visible = true;
            }
            else AlertWarning("Selezionare un anno scolastico");
        }

        private void btnEseguiAnni_Click(object sender, EventArgs e)
        {
            List<AnnoScolastico> anni = dbl.GetAnniScolastici();

            if (btnEseguiAnni.Text == "Aggiungi")
            {
                AnnoScolastico anno = new AnnoScolastico();

                if (CheckYearValidation())
                {
                    anno.Id = int.Parse(txtIdAnni.Text);
                    foreach (var year in anni)
                    {
                        if (year.Id == anno.Id)
                        {
                            AlertWarning("ID già esistente");
                            return;
                        }
                    }
                    anno.Anno = int.Parse(txtAnnoAnni.Text);

                    dbl.AddAnnoScolastico(anno);
                    AlertInformation("Anno aggiunto");
                }
                else
                {
                    AlertWarning("Controlla is campi e riprova");
                    return;
                }
            }
            else
            {
                AnnoScolastico annoAggiornato = new AnnoScolastico();

                if (CheckYearValidation())
                {
                    annoAggiornato.Id = int.Parse(txtIdAnni.Text);
                    annoAggiornato.Anno = int.Parse((string)txtAnnoAnni.Text);

                    int idAnno = (lstAnno.SelectedItem as AnnoScolastico).Id;
                    dbl.UpdateAnnoScolastico(idAnno, annoAggiornato);
                    AlertInformation("Anno modificato");
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }

            txtIdAnni.Text = txtAnnoAnni.Text = "";
            grpAnno.Visible = false;
            btnReadAnno_Click(btnReadAnno, e);
        }

        private bool CheckYearValidation()
        {
            if (txtAnnoAnni.Text != "" && txtIdAnni.Text != "") {
                if (int.TryParse(txtIdAnni.Text, out int test1) &&
                    int.TryParse(txtAnnoAnni.Text, out int test2))
                    return true;
            }
            return false;
        }

        // SEZIONI
        private void btnReadSezione_Click(object sender, EventArgs e)
        {
            List<Sezione> sezioni = dbl.GetSezioni();

            lstSezione.Items.Clear();
            foreach (var sezione in sezioni)
            {
                lstSezione.Items.Add(sezione);
            }

            btnAddSezione.Enabled = true;
            btnUpdateSezione.Enabled = true;
        }

        private void btnAddSezione_Click(object sender, EventArgs e)
        {
            btnEseguiSezione.Text = "Aggiungi";
            txtIdSezione.Text = txtNomeSezione.Text = "";
            txtIdSezione.Enabled = true;
            grpSezione.Visible = true;
        }

        private void btnUpdateSezione_Click(object sender, EventArgs e)
        {
            if (lstSezione.SelectedIndex >= 0)
            {
                Sezione sezioneSelezionata = lstSezione.SelectedItem as Sezione;

                btnEseguiSezione.Text = "Modifica";
                txtIdSezione.Text = sezioneSelezionata.Id.ToString();
                txtIdSezione.Enabled = true;
                txtNomeSezione.Text = sezioneSelezionata.NomeSezione;
                grpSezione.Visible = true;
            }
            else AlertWarning("Selezionare una sezione");
        }

        private void btnEseguiSezione_Click(object sender, EventArgs e)
        {
            List<Sezione> sezioni = dbl.GetSezioni();

            if (btnEseguiSezione.Text == "Aggiungi")
            {
                Sezione sezione = new Sezione();

                if (CheckSectionValidation())
                {
                    sezione.Id = int.Parse(txtIdSezione.Text);
                    foreach (var section in sezioni)
                    {
                        if (section.Id == sezione.Id)
                        {
                            AlertWarning("ID gia esistente");
                            return;
                        }
                    }
                    sezione.NomeSezione = txtNomeSezione.Text;

                    dbl.AddSezione(sezione);
                    AlertInformation("Sezione aggiunta");
                }
                else
                {
                    AlertWarning("Controlla is campi e riprova");
                    return;
                }
            }
            else
            {
                Sezione sezioneAggiornata = new Sezione();

                if (CheckSectionValidation())
                {
                    sezioneAggiornata.Id = int.Parse(txtIdSezione.Text);
                    sezioneAggiornata.NomeSezione = txtNomeSezione.Text;

                    Sezione sezioneSelezionata = lstSezione.SelectedItem as Sezione;
                    dbl.UpdateSezione(sezioneSelezionata.Id, sezioneAggiornata);
                    AlertInformation("Sezione aggiornata");
                }
                else
                {
                    AlertWarning("Controlla is campi e riprova");
                    return;
                }
            }

            txtIdSezione.Text = txtNomeSezione.Text = "";
            grpSezione.Visible = false;
            btnReadSezione_Click(btnReadSezione, e);
        }

        private bool CheckSectionValidation()
        {
            return false;
        }

        // CLASSI
        private void btnReadClassi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddClasse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateClasse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEseguiClasse_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckClassValidation()
        {
            return false;
        }

        private bool CheckSectionIdExistence(int id)
        {
            
            return false;
        }

        private bool CheckYearIdExistence(int id)
        {
            
            return false;
        }


        // MATERIE
        private void btnReadMaterie_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddMateria_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateMateria_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEseguiMateria_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckSubjectValidation()
        {
            
            return false;
        }

        // VOTO
        private void btnReadVoti_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAddVoto_Click(object sender, EventArgs e)
        {
           
        }
        private void btnUpdateVoto_Click(object sender, EventArgs e)
        {
            
        }
        private void btnGetVotiStudente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcolaMediaVotiClasseEMateria_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEseguiVoto_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckVoteValidation()
        {
            
            return false;
        }

        private bool CheckSubjectIdExistence(int id)
        {
            
            return false;
        }

        private bool CheckStudentIdExistence(int id)
        {
            
            return false;
        }

        private void disableClassId()
        {
            
        }

        // ALTRI METODI
        private void AlertWarning(string body)
        {
            MessageBox.Show(body, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AlertInformation(string body)
        {
            MessageBox.Show(body, "INFORMAZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
