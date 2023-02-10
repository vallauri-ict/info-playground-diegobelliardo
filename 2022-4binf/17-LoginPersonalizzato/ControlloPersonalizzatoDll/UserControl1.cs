using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ControlloPersonalizzatoDll
{
    public delegate void MessageEventHandler(object sender, MessageEventArgs e);
    public partial class UserControl1: UserControl
    {
        public struct user
        {
            public string utente;
            public string pwd;
        }
        List<user> listaUtenti = new List<user>();
        public event MessageEventHandler MessageEvent;
        MessageEventArgs messaggio;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            user utente;
            utente.utente= utenteTxt.Text;
            utente.pwd= passwordTxt.Text;
            if(listaUtenti.Contains(utente))
            {
                messaggio = new MessageEventArgs("LogIn effettuato con successo");
                MessageEvent(this, messaggio);
            }
            else
            {
                errorProviderUtente.SetError(utenteTxt, "Utente non esistente");
            }
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            user utente;
            utente.utente = utenteTxt.Text;
            utente.pwd = passwordTxt.Text;
            if (listaUtenti.Contains(utente))
            {
                messaggio = new MessageEventArgs("L'utente è già registrato");
                MessageEvent(this, messaggio);
            }
            else
            {
                user nuovoUtente;
                Regex rgx = new Regex(@"(?=.*[<>$&!])(?=.*[0-9]).{5,}");
                if (rgx.IsMatch(passwordTxt.Text))
                {
                    nuovoUtente.utente = utenteTxt.Text;
                    nuovoUtente.pwd = passwordTxt.Text;
                    listaUtenti.Add(nuovoUtente);
                }
                else
                {
                    errorProviderUtente.SetError(passwordTxt, "La password non è valida");
                }

            }
        }
    }
}
