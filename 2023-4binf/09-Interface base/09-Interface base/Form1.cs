using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Interface_base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quadrato_Click(object sender, EventArgs e)
        {
            Quadrato q = new Quadrato(5);

            MessageBox.Show("Area: "+q.Area(5,5)+"\nPerimetro: "+q.Perimetro());
        }

        private void triangolo_Click(object sender, EventArgs e)
        {
            Triangolo t = new Triangolo(4, 4, 4, 3);

            MessageBox.Show("Area: " + t.Area(4, 3) + "\nPerimetro: " + t.Perimetro());
        }
    }
}
