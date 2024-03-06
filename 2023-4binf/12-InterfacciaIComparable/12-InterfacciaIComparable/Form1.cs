using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_InterfacciaIComparable
{
    public partial class Form1 : Form
    {
        List<Persona> personaList = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Cognome=txtCognome.Text;
            persona.Nome=txtNome.Text;
            persona.Eta= Convert.ToInt32(txtEta.Text);
            personaList.Add(persona);
        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            personaList.Sort();
            string s = "";

            foreach (var item in personaList)
            {
                s+= "Cognome: "+item.Cognome+" - Nome: "+
                    item.Nome+" - Età: "+item.Eta+"\n";
            }

            MessageBox.Show(s);
        }
    }
}
