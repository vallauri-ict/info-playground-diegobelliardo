using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50_Uguaglianza
{
    public partial class Form1 : Form
    {
        private List<Persona> elenco = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(txtNome.Text,txtCognome.Text);
            elenco.Add(p);
            txtVisualizza.AppendText(txtNome.Text+" "+txtCognome.Text+"\r\n");
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(txtNomeCerca.Text, txtCognomeCerca.Text);
            int i = 0;
            foreach (var p1 in elenco)
            {
                i++;
                if (p1.Equals(p))
                {
                    MessageBox.Show($"Elemento {i} Uguale\nHashCode: {p.GetHashCode()} - {p1.GetHashCode()}");
                }
                else
                    MessageBox.Show($"Diversi! Hashscode: {p.GetHashCode()} - {p1.GetHashCode()}");
                if (p1==p)
                {
                    MessageBox.Show($"Elemento {i} ==");
                }
            }
        }
    }
}
