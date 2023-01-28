using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_PrimoEsDelegate
{
    //Dichiaro il delegate che accetta 2 parametri e restituisce un intero
    public delegate int Operazione(int a, int b);

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPiu_Click(object sender, EventArgs e)
        {
            Operazione op = new Operazione(Somma);

            MessageBox.Show("Somma="+op(10,5));
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            Operazione op = Prodotto;

            MessageBox.Show("Prodotto="+op(5,6));

        }
        private void btnMeno_Click(object sender, EventArgs e)
        {
            Operazione op = Sottrazione;
            MessageBox.Show("Sottrazione="+diff(10,8,op));
        }

        public int Somma(int a, int b)
        {
            return a + b;
        }

        public int diff(int a, int b, Operazione op)
        {
            if (a>=b)
            {
                return op(a, b);
            }
            else
            {
                return op(b, a);
            }
        }

        public int Sottrazione(int a, int b)
        {
            return a - b;
        }

        public int Prodotto(int a, int b)
        {
            return a * b;
        }

       
    }
}
