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

        DatabaseMock db = new DatabaseMock();
        int idStudente, idAnno, idSezione, idClasse, idMateria, idVoto;

        public FormMain()
        {
            InitializeComponent();
        }
        // STUDENTI
        private void btnReadStudenti_Click(object sender, EventArgs e)
        {
            List<Studente> studenti = db.GetStudenti();

            lstStudente.Items.Clear();
            foreach (Studente studente in studenti)
                lstStudente.Items.Add(studente);

            btnAddStudente.Enabled = true;
            btnUpdateStudente.Enabled = true;
            btnGetStudentiPerClasse.Enabled = true;
        }

        private void btnAddStudente_Click(object sender, EventArgs e)
        {
            btnEseguiStudente.Text = "Aggiungi";
            txtIdStudente.Text = txtNomeStudente.Text = txtCognomeStudente.Text = txtDataNascitaStudente.Text = txtIdClasseStudente.Text = "";
            txtIdStudente.Enabled = txtNomeStudente.Enabled = txtCognomeStudente.Enabled = txtDataNascitaStudente.Enabled = txtIdClasseStudente.Enabled = true;
            txtIdStudente.Enabled = true;
            grpStudente.Visible = true;
        }

        private void btnUpdateStudente_Click(object sender, EventArgs e)
        {
            if (lstStudente.SelectedIndex >= 0)
            {
                Studente studenteSelezionato = lstStudente.SelectedItem as Studente;

                txtNomeStudente.Enabled = txtCognomeStudente.Enabled = txtDataNascitaStudente.Enabled = txtIdClasseStudente.Enabled = true;
                idStudente = lstStudente.SelectedIndex + 1;
                btnEseguiStudente.Text = "Modifica";
                txtIdStudente.Text = idStudente.ToString();
                txtIdStudente.Enabled = false;
                txtNomeStudente.Text = studenteSelezionato.Nome;
                txtCognomeStudente.Text = studenteSelezionato.Cognome;
                txtDataNascitaStudente.Text = studenteSelezionato.DataNascita.ToString("yyyy-MM-dd");
                txtIdClasseStudente.Text = studenteSelezionato.ClasseId.ToString();
                grpStudente.Visible = true;
            }
            else
                AlertWarning("Selezionare uno studente");
        }
        private void btnGetStudentiPerClasse_Click(object sender, EventArgs e)
        {
            btnEseguiStudente.Text = "Recupera";
            txtIdStudente.Enabled = txtNomeStudente.Enabled = txtCognomeStudente.Enabled =
                txtDataNascitaStudente.Enabled = false;
            txtIdStudente.Text = txtNomeStudente.Text = txtCognomeStudente.Text =
                txtDataNascitaStudente.Text = txtIdClasseStudente.Text = "";
            grpStudente.Visible = true;
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            List<Studente> studenti = db.GetStudenti();

            if (btnEseguiStudente.Text == "Aggiungi")
            {
                Studente studente = new Studente();

                if (CheckStudentValidation())
                {
                    studente.Id = int.Parse(txtIdStudente.Text);
                    foreach (Studente student in studenti)
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
                        db.AddStudente(studente);
                        AlertInformation("Studente aggiunto");
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
                        db.UpdateStudente(idStudente, studenteAggiornato);
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
                        List<Studente> studentiRecuperati = db.GetStudentiPerClasse(idClasse);

                        lstStudente.Items.Clear();
                        foreach (Studente studente in studentiRecuperati)
                            lstStudente.Items.Add(studente);
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

            txtIdStudente.Text = txtNomeStudente.Text = txtCognomeStudente.Text = txtDataNascitaStudente.Text = "";
            grpStudente.Visible = false;

            if (btnEseguiStudente.Text != "Recupera")
                btnReadStudenti_Click(btnReadStudenti, e);
        }

        private bool CheckStudentValidation()
        {
            if (txtIdStudente.Text != "" && txtNomeStudente.Text != "" && txtCognomeStudente.Text != "" && txtDataNascitaStudente.Text != "" &&
                txtIdClasseStudente.Text != "")
            {
                if (int.TryParse(txtIdStudente.Text, out int testInt1) && DateTime.TryParse(txtDataNascitaStudente.Text, out DateTime dateTest) &&
                    int.TryParse(txtIdClasseStudente.Text, out int testInt2))
                    return true;
            }
            return false;
        }

        private bool CheckClassIdExistence(int id)
        {
            List<Classe> classi = db.GetClassi();

            foreach (Classe classe in classi)
            {
                if (classe.Id == id)
                    return true;
            }
            return false;
        }

        // ANNI
        private void btnReadAnno_Click(object sender, EventArgs e)
        {
            List<AnnoScolastico> anni = db.GetAnniScolastici();

            lstAnno.Items.Clear();
            foreach (AnnoScolastico anno in anni)
                lstAnno.Items.Add(anno);

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

                idAnno = lstAnno.SelectedIndex + 1;
                btnEseguiAnni.Text = "Modifica";
                txtIdAnni.Text = idAnno.ToString();
                txtIdAnni.Enabled = false;
                txtAnnoAnni.Text = anno.Anno.ToString();
                grpAnno.Visible = true;
            }
            else
                AlertWarning("Selezionare un anno scolastico");
        }

        private void btnEseguiAnni_Click(object sender, EventArgs e)
        {
            List<AnnoScolastico> anni = db.GetAnniScolastici();

            if (btnEseguiAnni.Text == "Aggiungi")
            {
                AnnoScolastico anno = new AnnoScolastico();

                if (CheckYearValidation())
                {
                    anno.Id = int.Parse(txtIdAnni.Text);
                    foreach (AnnoScolastico year in anni)
                    {
                        if (year.Id == anno.Id)
                        {
                            AlertWarning("ID già esistente");
                            return;
                        }
                    }
                    anno.Anno = int.Parse(txtAnnoAnni.Text);

                    db.AddAnnoScolastico(anno);
                    AlertInformation("Anno aggiunto");
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }
            else
            {
                AnnoScolastico annoAggiornato = new AnnoScolastico();

                if (CheckYearValidation())
                {
                    annoAggiornato.Id = int.Parse(txtIdAnni.Text);
                    annoAggiornato.Anno = int.Parse(txtAnnoAnni.Text);

                    db.UpdateAnnoScolastico(idAnno, annoAggiornato);
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
            if (txtIdAnni.Text != "" && txtAnnoAnni.Text != "")
            {
                if (int.TryParse(txtIdAnni.Text, out int test1) && int.TryParse(txtAnnoAnni.Text, out int test2))
                    return true;
            }
            return false;
        }

        // SEZIONI
        private void btnReadSezione_Click(object sender, EventArgs e)
        {
            List<Sezione> sezioni = db.GetSezioni();

            lstSezione.Items.Clear();
            foreach (Sezione sezione in sezioni)
                lstSezione.Items.Add(sezione);

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

                idSezione = lstSezione.SelectedIndex + 1;
                btnEseguiSezione.Text = "Modifica";
                txtIdSezione.Text = idSezione.ToString();
                txtIdSezione.Enabled = false;
                txtNomeSezione.Text = sezioneSelezionata.NomeSezione;
                grpSezione.Visible = true;
            }
            else
                AlertWarning("Selezionare una sezione");
        }

        private void btnEseguiSezione_Click(object sender, EventArgs e)
        {
            List<Sezione> sezioni = db.GetSezioni();

            if (btnEseguiSezione.Text == "Aggiungi")
            {
                Sezione sezione = new Sezione();

                if (CheckSectionValidation())
                {
                    sezione.Id = int.Parse(txtIdSezione.Text);
                    foreach (Sezione section in sezioni)
                    {
                        if (section.Id == sezione.Id)
                        {
                            AlertWarning("ID già esistente");
                            return;
                        }
                    }
                    sezione.NomeSezione = txtNomeSezione.Text;

                    db.AddSezione(sezione);
                    AlertInformation("Sezione aggiunta");
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
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

                    db.UpdateSezione(idSezione, sezioneAggiornata);
                    AlertInformation("Sezione aggiornata");
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }

            txtIdSezione.Text = txtNomeSezione.Text = "";
            grpSezione.Visible = false;
            btnReadSezione_Click(btnReadSezione, e);
        }

        private bool CheckSectionValidation()
        {
            if (txtIdSezione.Text != "" && txtNomeSezione.Text != "")
            {
                if (int.TryParse(txtIdSezione.Text, out int test))
                    return true;
            }
            return false;
        }

        // CLASSI
        private void btnReadClassi_Click(object sender, EventArgs e)
        {
            List<Classe> classi = db.GetClassi();

            lstClasse.Items.Clear();
            foreach (Classe classe in classi)
                lstClasse.Items.Add(classe);

            btnAddClasse.Enabled = true;
            btnUpdateClasse.Enabled = true;
        }

        private void btnAddClasse_Click(object sender, EventArgs e)
        {
            btnEseguiClasse.Text = "Aggiungi";
            txtIdClasse.Text = txtAnnoIdClasse.Text = txtSezioneIdClasse.Text = "";
            txtIdClasse.Enabled = true;
            grpClasse.Visible = true;
        }

        private void btnUpdateClasse_Click(object sender, EventArgs e)
        {
            if (lstClasse.SelectedIndex >= 0)
            {
                Classe classeSelezionata = lstClasse.SelectedItem as Classe;

                idClasse = lstClasse.SelectedIndex + 1;
                btnEseguiClasse.Text = "Modifica";
                txtIdClasse.Text = idClasse.ToString();
                txtIdClasse.Enabled = false;
                txtAnnoIdClasse.Text = classeSelezionata.AnnoId.ToString();
                txtSezioneIdClasse.Text = classeSelezionata.SezioneId.ToString();
                grpClasse.Visible = true;
            }
            else
                AlertWarning("Selezionare una classe");
        }

        private void btnEseguiClasse_Click(object sender, EventArgs e)
        {
            List<Classe> classi = db.GetClassi();

            if (btnEseguiClasse.Text == "Aggiungi")
            {
                Classe classe = new Classe();

                if (CheckClassValidation())
                {
                    classe.Id = int.Parse(txtIdClasse.Text);
                    foreach (Classe iClass in classi)
                    {
                        if (iClass.Id == classe.Id)
                        {
                            AlertWarning("ID già esistente");
                            return;
                        }
                    }
                    classe.AnnoId = int.Parse(txtAnnoIdClasse.Text);
                    classe.SezioneId = int.Parse(txtSezioneIdClasse.Text);

                    if (CheckYearIdExistence(classe.AnnoId))
                    {
                        if (CheckSectionIdExistence(classe.SezioneId))
                        {
                            db.AddClasse(classe);
                            AlertInformation("Classe aggiunta");
                        }
                        else
                        {
                            AlertWarning("ID sezione non esistente");
                            return;
                        }
                    }
                    else
                    {
                        AlertWarning("ID anno non esistente");
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
                Classe classeAggiornata = new Classe();

                if (CheckClassValidation())
                {
                    classeAggiornata.Id = int.Parse(txtIdClasse.Text);
                    classeAggiornata.AnnoId = int.Parse(txtAnnoIdClasse.Text);
                    classeAggiornata.SezioneId = int.Parse(txtSezioneIdClasse.Text);

                    if (CheckYearIdExistence(classeAggiornata.AnnoId))
                    {
                        if (CheckSectionIdExistence(classeAggiornata.SezioneId))
                        {
                            db.UpdateClasse(idClasse, classeAggiornata);
                            AlertInformation("Classe modificata");
                        }
                        else
                        {
                            AlertWarning("ID sezione non esistente");
                            return;
                        }
                    }
                    else
                    {
                        AlertWarning("ID anno non esistente");
                        return;
                    }
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }

            txtIdClasse.Text = txtAnnoIdClasse.Text = txtSezioneIdClasse.Text = "";
            grpClasse.Visible = false;
            btnReadClassi_Click(btnReadClassi, e);
        }

        private bool CheckClassValidation()
        {
            if (txtIdClasse.Text != "" && txtAnnoIdClasse.Text != "" && txtSezioneIdClasse.Text != "")
            {
                if (int.TryParse(txtIdClasse.Text, out int test1) && int.TryParse(txtAnnoIdClasse.Text, out int test2) && int.TryParse(txtSezioneIdClasse.Text, out int test3))
                    return true;
            }
            return false;
        }

        private bool CheckSectionIdExistence(int id)
        {
            List<Sezione> sezioni = db.GetSezioni();

            foreach (Sezione sezione in sezioni)
            {
                if (sezione.Id == id)
                    return true;
            }
            return false;
        }

        private bool CheckYearIdExistence(int id)
        {
            List<AnnoScolastico> anni = db.GetAnniScolastici();

            foreach (AnnoScolastico anno in anni)
            {
                if (anno.Id == id)
                    return true;
            }
            return false;
        }


        // MATERIE
        private void btnReadMaterie_Click(object sender, EventArgs e)
        {
            List<Materia> materie = db.GetMaterie();

            lstMateria.Items.Clear();
            foreach (Materia materia in materie)
                lstMateria.Items.Add(materia);

            btnAddMateria.Enabled = true;
            btnUpdateMateria.Enabled = true;
        }

        private void btnAddMateria_Click(object sender, EventArgs e)
        {
            btnEseguiMateria.Text = "Aggiungi";
            txtIdMateria.Text = txtNomeMateria.Text = "";
            txtIdMateria.Enabled = true;
            grpMateria.Visible = true;
        }

        private void btnUpdateMateria_Click(object sender, EventArgs e)
        {
            if (lstMateria.SelectedIndex >= 0)
            {
                Materia materiaSelezionata = lstMateria.SelectedItem as Materia;

                idMateria = lstMateria.SelectedIndex + 1;
                btnEseguiMateria.Text = "Modifica";
                txtIdMateria.Text = idMateria.ToString();
                txtIdMateria.Enabled = false;
                txtNomeMateria.Text = materiaSelezionata.NomeMateria;
                grpMateria.Visible = true;
            }
            else
                AlertWarning("Selezionare una materia");
        }

        private void btnEseguiMateria_Click(object sender, EventArgs e)
        {
            List<Materia> materie = db.GetMaterie();

            if (btnEseguiMateria.Text == "Aggiungi")
            {
                Materia materia = new Materia();

                if (CheckSubjectValidation())
                {
                    materia.Id = int.Parse(txtIdMateria.Text);
                    foreach (Materia subject in materie)
                    {
                        if (subject.Id == materia.Id)
                        {
                            AlertWarning("ID già esistente");
                            return;
                        }
                    }
                    materia.NomeMateria = txtNomeMateria.Text;

                    db.AddMateria(materia);
                    AlertInformation("Studente aggiunto");
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }
            else
            {
                Materia materiaAggiornata = new Materia();

                if (CheckSubjectValidation())
                {
                    materiaAggiornata.Id = int.Parse(txtIdMateria.Text);
                    materiaAggiornata.NomeMateria = txtNomeMateria.Text;

                    db.UpdateMateria(idMateria, materiaAggiornata);
                    AlertInformation("Materia modificata");
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }

            txtIdMateria.Text = txtNomeMateria.Text = "";
            grpMateria.Visible = false;
            btnReadMaterie_Click(btnReadMaterie, e);
        }

        private bool CheckSubjectValidation()
        {
            if (txtIdMateria.Text != "" && txtNomeMateria.Text != "")
            {
                if (int.TryParse(txtIdMateria.Text, out int test))
                    return true;
            }
            return false;
        }

        // VOTO
        private void btnReadVoti_Click(object sender, EventArgs e)
        {
            List<Voto> voti = db.GetVoti();

            lstVoto.Items.Clear();
            foreach (Voto voto in voti)
                lstVoto.Items.Add(voto);

            btnAddVoto.Enabled = true;
            btnUpdateVoto.Enabled = true;
            btnGetVotiStudente.Enabled = true;
            btnCalcolaMediaVotiClasseEMateria.Enabled = true;
        }
        private void btnAddVoto_Click(object sender, EventArgs e)
        {
            btnEseguiVoto.Text = "Aggiungi";
            txtIdVoto.Text = txtIdStudenteVoto.Text = txtIdMateriaVoto.Text = txtVoto.Text = txtDataVoto.Text = "";
            txtIdVoto.Enabled = txtIdStudenteVoto.Enabled = txtIdMateriaVoto.Enabled = txtVoto.Enabled = txtDataVoto.Enabled = true;
            disableClassId();
            txtIdVoto.Enabled = true;
            grpVoto.Visible = true;
        }
        private void btnUpdateVoto_Click(object sender, EventArgs e)
        {
            if (lstVoto.SelectedIndex >= 0)
            {
                Voto votoSelezionato = lstVoto.SelectedItem as Voto;

                txtIdStudenteVoto.Enabled = txtIdMateriaVoto.Enabled = txtVoto.Enabled = txtDataVoto.Enabled = true;
                idVoto = lstVoto.SelectedIndex + 1;
                btnEseguiVoto.Text = "Modifica";
                txtIdVoto.Text = idVoto.ToString();
                txtIdVoto.Enabled = false;
                txtIdStudenteVoto.Text = votoSelezionato.StudenteId.ToString();
                txtIdMateriaVoto.Text = votoSelezionato.MateriaId.ToString();
                txtVoto.Text = votoSelezionato.Valore.ToString();
                txtDataVoto.Text = votoSelezionato.DataVoto.ToString("yyyy-MM-dd");
                disableClassId();
                grpVoto.Visible = true;
            }
            else
                AlertWarning("Selezionare un voto");
        }
        private void btnGetVotiStudente_Click(object sender, EventArgs e)
        {
            btnEseguiVoto.Text = "Recupera";
            txtIdVoto.Enabled = txtIdMateriaVoto.Enabled = txtVoto.Enabled = txtDataVoto.Enabled = false;
            txtIdVoto.Text = txtIdStudenteVoto.Text = txtIdMateriaVoto.Text = txtVoto.Text = txtDataVoto.Text = "";
            txtIdStudenteVoto.Enabled = true;
            disableClassId();
            grpVoto.Visible = true;
        }

        private void btnCalcolaMediaVotiClasseEMateria_Click(object sender, EventArgs e)
        {
            btnEseguiVoto.Text = "Calcola";
            txtIdVoto.Enabled = txtIdStudenteVoto.Enabled = txtVoto.Enabled = txtDataVoto.Enabled = false;
            txtIdVoto.Text = txtIdStudenteVoto.Text = txtIdMateriaVoto.Text = txtVoto.Text = txtDataVoto.Text = txtIdClasseVoto.Text = "";
            lblClasseId.Visible = txtIdClasseVoto.Visible = txtIdMateriaVoto.Enabled = true;
            grpVoto.Visible = true;
        }

        private void btnEseguiVoto_Click(object sender, EventArgs e)
        {
            List<Voto> voti = db.GetVoti();

            if (btnEseguiVoto.Text == "Aggiungi")
            {
                Voto voto = new Voto();

                if (CheckVoteValidation())
                {
                    voto.Id = int.Parse(txtIdVoto.Text);
                    foreach (Voto vote in voti)
                    {
                        if (vote.Id == voto.Id)
                        {
                            AlertWarning("ID già esistente");
                            return;
                        }
                    }
                    voto.StudenteId = int.Parse(txtIdStudenteVoto.Text);
                    voto.MateriaId = int.Parse(txtIdMateriaVoto.Text);
                    voto.Valore = int.Parse(txtVoto.Text);
                    voto.DataVoto = DateTime.Parse(txtDataVoto.Text);

                    if (CheckStudentIdExistence(voto.StudenteId))
                    {
                        if (CheckSubjectIdExistence(voto.MateriaId))
                        {
                            db.AddVoto(voto);
                            AlertInformation("Voto aggiunto");
                        }
                        else
                        {
                            AlertWarning("ID materia non esistente");
                            return;
                        }
                    }
                    else
                    {
                        AlertWarning("ID studente non esistente");
                        return;
                    }
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }
            else if (btnEseguiVoto.Text == "Modifica")
            {
                Voto votoAggiornato = new Voto();

                if (CheckVoteValidation())
                {
                    votoAggiornato.Id = int.Parse(txtIdVoto.Text);
                    votoAggiornato.StudenteId = int.Parse(txtIdStudenteVoto.Text);
                    votoAggiornato.MateriaId = int.Parse(txtIdMateriaVoto.Text);
                    votoAggiornato.Valore = int.Parse(txtVoto.Text);
                    votoAggiornato.DataVoto = DateTime.Parse(txtDataVoto.Text);

                    if (CheckStudentIdExistence(votoAggiornato.StudenteId))
                    {
                        if (CheckSubjectIdExistence(votoAggiornato.MateriaId))
                        {
                            db.UpdateVoto(idVoto, votoAggiornato);
                            AlertInformation("Voto modificato");
                        }
                        else
                        {
                            AlertWarning("ID materia non esistente");
                            return;
                        }
                    }
                    else
                    {
                        AlertWarning("ID studente non esistente");
                        return;
                    }
                }
            }
            else if (btnEseguiVoto.Text == "Recupera")
            {
                int idStudente;

                if (int.TryParse(txtIdStudenteVoto.Text, out idStudente))
                {
                    if (CheckStudentIdExistence(idStudente))
                    {
                        List<Voto> votiRecuperati = db.GetVotiPerStudente(idStudente);

                        lstVoto.Items.Clear();
                        foreach (Voto voto in votiRecuperati)
                            lstVoto.Items.Add(voto);
                    }
                    else
                    {
                        AlertWarning("ID studente non esistente");
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
                int idClasse, idMateria;

                if (int.TryParse(txtIdClasseVoto.Text, out idClasse) && int.TryParse(txtIdMateriaVoto.Text, out idMateria))
                {
                    if (CheckSubjectIdExistence(idMateria))
                    {
                        if (CheckClassIdExistence(idClasse))
                        {
                            double media = db.CalcolaMediaVotiPerClasseEMateria(idClasse, idMateria);

                            AlertInformation("Media voti: " + media.ToString("F2"));
                        }
                        else
                        {
                            AlertWarning("ID classe non esistente");
                            return;
                        }
                    }
                    else
                    {
                        AlertWarning("ID materia non esistente");
                        return;
                    }
                }
                else
                {
                    AlertWarning("Controlla i campi e riprova");
                    return;
                }
            }

            txtIdVoto.Text = txtIdStudenteVoto.Text = txtIdMateriaVoto.Text = txtVoto.Text = txtDataVoto.Text = "";
            grpVoto.Visible = false;
            if (btnEseguiVoto.Text != "Recupera" && btnEseguiVoto.Text != "Calcola")
                btnReadVoti_Click(btnReadVoti, e);
        }

        private bool CheckVoteValidation()
        {
            if (txtIdVoto.Text != "" && txtIdStudenteVoto.Text != "" && txtIdMateriaVoto.Text != "" && txtVoto.Text != "" && txtDataVoto.Text != "")
            {
                if (int.TryParse(txtIdVoto.Text, out int test1) && int.TryParse(txtIdStudenteVoto.Text, out int test2) &&
                    int.TryParse(txtIdMateriaVoto.Text, out int test3) && int.TryParse(txtVoto.Text, out int test4) &&
                    DateTime.TryParse(txtDataVoto.Text, out DateTime test5))
                    return true;
            }
            return false;
        }

        private bool CheckSubjectIdExistence(int id)
        {
            List<Materia> materie = db.GetMaterie();

            foreach (Materia materia in materie)
            {
                if (materia.Id == id)
                    return true;
            }
            return false;
        }

        private bool CheckStudentIdExistence(int id)
        {
            List<Studente> studenti = db.GetStudenti();

            foreach (Studente studente in studenti)
            {
                if (studente.Id == id)
                    return true;
            }
            return false;
        }

        private void disableClassId()
        {
            txtIdClasseVoto.Text = "";
            lblClasseId.Visible = txtIdClasseVoto.Visible = false;
        }

        // ALTRI METODI
        private void AlertWarning(string body)
        {
            MessageBox.Show(body, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AlertInformation(string body)
        {
            MessageBox.Show(body, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
