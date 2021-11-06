using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP04_Ereditarieta02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostro_Click(object sender, EventArgs e)
        {
            Mostro m = new Mostro();
            MessageBox.Show("Mostro --> Verso: "+m.Verso()+
                " Punti: "+m.Valore());
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            Mannaro mn = new Mannaro();
            MessageBox.Show("Mannaro --> Verso: " + mn.Verso() +
                " Punti: " + mn.Valore());
            mn.Muta();
            MessageBox.Show("Mannaro --> Verso: " + mn.Verso() +
                " Punti: " + mn.Valore());
        }

        private void btnSpettro_Click(object sender, EventArgs e)
        {
            Spettro s = new Spettro();
            MessageBox.Show("Spettro --> Punti: "+s.Valore());
            Spettro s2 = new Spettro(50);
            MessageBox.Show("Spettro 50 --> Punti: " + s2.Valore());
        }
    }
}
