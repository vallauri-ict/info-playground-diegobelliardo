using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_OOP01
{
    public partial class Form1 : Form
    {
        Rectangle r;
        public Form1()
        {
            InitializeComponent();
            //r = new Rectangle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreaRettangolo_Click(object sender, EventArgs e)
        {
            /*r.side1 = Convert.ToInt32(txtBase.Text);
            r.side2 = Convert.ToInt32(txtAltezza.Text);
            Rectangle t;
            t = r;
            MessageBox.Show("Base: "+r.side1+" Altezza: "+r.side2);
            MessageBox.Show("Per l'oggetto t\nBase: " + t.side1 + " Altezza: " + t.side2);
            t.side1 = 10;
            MessageBox.Show("Oggetto r dopo modifiche su t\nBase: " + r.side1 + " Altezza: " + r.side2);
            */
            r = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            r.colore = Color.White;
            MessageBox.Show(r.getSide());            
        }
    }
}
