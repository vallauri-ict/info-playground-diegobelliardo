using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_OOP_PersoneStudenti
{
    public partial class Form1 : Form
    {
        private List<Studente> lstStudenti = new List<Studente>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudente_Click(object sender, EventArgs e)
        {
            Studente studente = new Studente();
            
            studente.SetAttributs(txtNome.Text,txtCognome.Text,txtSesso.Text,Convert.ToInt32(txtEta.Text));
            lstStudenti.Add(studente);
            listStudenti.Items.Add(studente.GetCognome());

        }

        private void btnInserisciVoto_Click(object sender, EventArgs e)
        {
            string cognome=listStudenti.SelectedItems[0].Text;
            foreach (Studente item in lstStudenti)
            {
                if (item.GetCognome() == cognome)
                {
                    item.lstVoti.Add(Convert.ToInt32(txtVoto.Text));
                }
            }
            
        }

        private void btnVoti_Click(object sender, EventArgs e)
        {
            string cognome = listStudenti.SelectedItems[0].Text;

            Studente s = lstStudenti.Find(st => st.GetCognome() == cognome);

            MessageBox.Show("Media voti: " + s.Media());
        }
    }
}
