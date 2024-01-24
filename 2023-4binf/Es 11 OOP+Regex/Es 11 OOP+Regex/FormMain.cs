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

namespace Es_11_OOP_Regex {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        Dictionary<string, string> soci = new Dictionary<string, string>();

        private void btnAdd_Click(object sender, EventArgs e) {
            Regex regex1 = new Regex(@"(?=^[a-zA-Z]{4,})(?=.*\d.*\d.*\d)(?=.*[#\$&])^[#\$&0-9a-zA-Z]{10,}$");
//            Regex regex2 = new Regex(@"^.{10,}$");
            if (!regex1.IsMatch(txtMatricola.Text)) {
                MessageBox.Show("Errore nella compilazione del campo matricola", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            regex1 = new Regex(@"^.{3,}$");
            if (!regex1.IsMatch(txtCognome.Text)) {
                MessageBox.Show("Errore nella compilazione del campo cognome", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!regex1.IsMatch(txtNome.Text)) {
                MessageBox.Show("Errore nella compilazione del campo nome", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            regex1 = new Regex(@"[\w\.*]{3,}@\w{3,}\.\w{2,}");
            if (!regex1.IsMatch(txtEmail.Text)) {
                MessageBox.Show("Errore nella compilazione del campo E-mail", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (soci.TryGetValue(txtMatricola.Text, out string nome)) {
                if (nome == txtCognome.Text + " " + txtNome.Text) {
                    MessageBox.Show("Socio già registrato");
                }
                else {
                    MessageBox.Show("Matricola già registrata per il socio: " + nome);
                }
            }
            else {
                soci.Add(txtMatricola.Text, txtCognome.Text + " " + txtNome.Text);
                MessageBox.Show("Socio aggiunto con successo");
            }
        }
    }
}
