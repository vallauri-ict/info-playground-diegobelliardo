using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacciaStrumenti
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
            Chitarra c = new Chitarra();

            cmp.AggiungiStrumento(c);
        }

        private void btnTromba_Click(object sender, EventArgs e)
        {
            Tromba t = new Tromba();

            cmp.AggiungiStrumento(t);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            cmp.Play();
        }
    }
}
