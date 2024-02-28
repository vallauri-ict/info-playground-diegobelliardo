using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_EsInterfacceLibreria
{
    public partial class Form1 : Form
    {
        List<Utente> lstUtenti = new List<Utente>();
        List<ElementoLibreria> lstElementi = new List<ElementoLibreria>();  
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAggUtente_Click(object sender, EventArgs e)
        {
            lstUtenti.Add(
                new Utente(txtNome.Text, Convert.ToInt32(txtNTessera.Text)));
        }

        private void btnInserisciLibro_Click(object sender, EventArgs e)
        {
            Libro l = new Libro(txtTitoloInsLibro.Text, txtInsAutore.Text, Convert.ToInt32(txtInsPagine.Text));
            lstElementi.Add(l);
        }

        private void btnStatoPrestiti_Click(object sender, EventArgs e)
        {
            string prestiti = "";
            foreach (var item in lstElementi)
            {
                if (item.Prestito)
                {
                    prestiti += $"Elemento {item.Titolo} in prestito\n";
                }
            }
            MessageBox.Show(prestiti);
        }

        private void btnPrestito_Click(object sender, EventArgs e)
        {
            string nomeUtente=txtNome.Text;
            string titoloLibro = txtTitoloPrestito.Text;

            Utente u = lstUtenti.Find(n => nomeUtente == n.Name);
            ILibreriaItem it = lstElementi.Find(n => titoloLibro == n.Titolo);

            u.PrendiInPrestitoItem(it);
        }
    }
}
