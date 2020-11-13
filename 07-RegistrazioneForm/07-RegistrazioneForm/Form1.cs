using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_RegistrazioneForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;

            // COGNOME
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtCognome.Text=="")
            {
                MessageBox.Show("Cognome non inserito!");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else if (!regCognome.IsMatch(txtCognome.Text))
            {
                MessageBox.Show("Cognome inserito non valido!");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else
            {
                // inserire nella classe Utente
            }

            // tutti i vari campi

            /* mail
             * inizia con: dei caratteri, '.', '_', '-'
             * poi '@'
             * poi alcuni caratteri poi '.' poi da 2 a 4 caratteri
             */







        }
    }
}
