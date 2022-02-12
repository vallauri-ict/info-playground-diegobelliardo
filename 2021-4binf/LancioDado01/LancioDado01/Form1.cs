using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LancioDado01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDado_Click(object sender, EventArgs e)
        {
            Dado d = new Dado();

            d.lancio();

            MessageBox.Show("Risultato: "+d.N);
        }

        private void btnMoneta_Click(object sender, EventArgs e)
        {
            Moneta m = new Moneta();

            m.lancio();
            MessageBox.Show("Moneta: " + ((m.V == 0)?"Testa":"Croce"));
        }

        private void btnDadoAstratto_Click(object sender, EventArgs e)
        {
            DadoAbs d = new DadoAbs();

            d.Lancia();
            MessageBox.Show("Risultato: " + d.X);
        }

        private void btnMonetaAstratto_Click(object sender, EventArgs e)
        {
            MonetaAbs m = new MonetaAbs();

            m.Lancia();
            MessageBox.Show("Moneta: " + ((m.X == 0) ? "Testa" : "Croce"));
        }
    }
}
