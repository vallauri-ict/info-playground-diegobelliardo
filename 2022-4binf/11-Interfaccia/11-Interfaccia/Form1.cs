using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Interfaccia
{
    public partial class Form1 : Form
    {
        Complesso cmp = new Complesso();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRumorista_Click(object sender, EventArgs e)
        {
            Rumorista r = new Rumorista();
            cmp.AggiungiRumorista(r);
        }

        private void btnChitarra_Click(object sender, EventArgs e)
        {
            Chitarra chitarra = new Chitarra();
            cmp.AggiungiStrumento(chitarra);
        }

        private void btnTromba_Click(object sender, EventArgs e)
        {
            Tromba tromba = new Tromba();
            cmp.AggiungiStrumento(tromba);
        }

        private void btnSuona_Click(object sender, EventArgs e)
        {
            cmp.Play();
        }

        private void btnStrumento_Click(object sender, EventArgs e)
        {
            Strumento strumento = new Strumento();
            cmp.AggiungiStrumento(strumento);
        }
    }
}
