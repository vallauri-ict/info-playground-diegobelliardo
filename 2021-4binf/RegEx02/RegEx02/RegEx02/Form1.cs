using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegEx02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (verifyNameRegex())
                MessageBox.Show("Nome Corretto");
            else
                MessageBox.Show("Nome Errato");

            if (verifySurnameRegex())
                MessageBox.Show("Cognome Corretto");
            else
                MessageBox.Show("Cognome Errato");

            if (verifyEtaRegex())
                MessageBox.Show("Età Corretta");
            else
                MessageBox.Show("Età Errato");

            if (verifyCapRegex())
                MessageBox.Show("CAP Corretto");
            else
                MessageBox.Show("CAP Errato");

            if (verifyCittaRegex())
                MessageBox.Show("Città Corretta");
            else
                MessageBox.Show("Città Errata");

            if (verifyMailRegex())
                MessageBox.Show("Mail Corretta");
            else
                MessageBox.Show("Mail Errata");

            if (verifyCFRegex())
                MessageBox.Show("CF Corretta");
            else
                MessageBox.Show("CF Errata");

            if (verifyUsernameRegex())
                MessageBox.Show("Username Corretto");
            else
                MessageBox.Show("Username Errato");

            if (verifyPasswordRegex())
                MessageBox.Show("Password Corretta");
            else
                MessageBox.Show("Password Errata");
        }

        private bool verifyCFRegex()
        {
            string cF = "^[a-zA-Z]{6}[0-9]{2}[abcdehlmprstABCDEHLMPRST]{1}[0-9]{2}([a-zA-Z]{1}[0-9]{3})[a-zA-Z]{1}$";
            Regex reg = new Regex(cF);
            return reg.IsMatch(txtCF.Text);
        }

        private bool verifyCapRegex()
        {
            string cap = "^[0-9]{5}$";
            Regex reg = new Regex(cap);
            return reg.IsMatch(txtCap.Text);
        }

        private bool verifyEtaRegex()
        {
            string number = "^[0-9]+$"; // ^([1-9]{0,1}[0-9]|^1[0-1][0-9])$
            Regex reg = new Regex(number);
            return (reg.IsMatch(txtEta.Text) && (Convert.ToInt32(txtEta.Text) >= 0 || Convert.ToInt32(txtEta.Text) <= 120));
        }

        private bool verifyNameRegex()
        {
            string name = "^[a-zA-Z]{3,}$";
            Regex reg = new Regex(name);
            return reg.IsMatch(txtNome.Text);
        }
        private bool verifySurnameRegex()
        {
            string name = "^[a-zA-Z]{3,}$";
            Regex reg = new Regex(name);
            return reg.IsMatch(txtCognome.Text);
        }
        private bool verifyCittaRegex()
        {
            string citta = @"^[a-zA-Z]{3,} \([A-Z]{2}\)$";
            Regex reg = new Regex(citta);
            return reg.IsMatch(txtCitta.Text);
        }
        private bool verifyMailRegex()
        {
            Regex reg = new Regex(@"^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)(,\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*$");
            return reg.IsMatch(txtMail.Text);
        }
        private bool verifyUsernameRegex()
        {
            Regex reg = new Regex(@"^[a-zA-Z]\w{4,}$");
            return reg.IsMatch(txtUsername.Text);
        }
        private bool verifyPasswordRegex()
        {
            Regex reg = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[-+!])[-+!A-Za-z\d]{8,15}$");
            return reg.IsMatch(txtPassword.Text);
        }
    }
}
