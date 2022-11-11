using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_CollectionLibri
{
    public partial class Form1 : Form
    {
        List<Libro> listaLibri = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisciLibro_Click(object sender, EventArgs e)
        {
            Libro l = new Libro(txtTitolo.Text, txtAutore.Text);
            listaLibri.Add(l);
        }

        private void btnCercaTitoloLibro_Click(object sender, EventArgs e)
        {
            Libro ris = listaLibri.Find(bf => bf.titolo == txtTitolo.Text);
            MessageBox.Show("E' stato trovato il libro:\n"+ris.ToString());
        }
    }
}
