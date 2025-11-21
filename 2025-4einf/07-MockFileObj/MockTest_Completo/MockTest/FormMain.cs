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
            
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckStudentValidation()
        {
            
        }

        private bool CheckClassIdExistence(int id)
        {
            
        }

        // ANNI
        private void btnReadAnno_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddAnno_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateAnno_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEseguiAnni_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckYearValidation()
        {
            
        }

        // SEZIONI
        private void btnReadSezione_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddSezione_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateSezione_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEseguiSezione_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckSectionValidation()
        {
            
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
            
        }

        private void AlertInformation(string body)
        {
            
        }
    }
}
