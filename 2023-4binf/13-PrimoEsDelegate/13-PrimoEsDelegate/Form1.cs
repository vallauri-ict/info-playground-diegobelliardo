using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_PrimoEsDelegate
{
    //Dichiarazione delegate che accetta 2 parametri
    //e restituisce un risultato
    public delegate int Operazione(int a, int b);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Dichiare le 3 funzioni che utilizzerò con il delegate
        public int Somma(int a, int b)
        {
            return a + b;
        }

        public int Prodotto(int a, int b)
        {
            return a * b;
        }

        public int Sottrazione(int a, int b)
        {
            return a - b;
        }

        public int Modulo(int a,int b, Operazione op)
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


        private void btnPiu_Click(object sender, EventArgs e)
        {
            //PRIMO METODO
            //Istanzio il delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma);

            //Richiamo il delegate che farà la somma
            MessageBox.Show("Somma= "+ op(10, 15)); 
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            //SECONDO METODO
            Operazione op = Prodotto;

            //Richiamo
            MessageBox.Show("Prodotto= "+op(10,15));
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            //SECONDO METODO
            Operazione op = Sottrazione;

            //Richiamo
            MessageBox.Show("Sottrazione= " + op(10, 15));
        }

        private void btnMeno2_Click(object sender, EventArgs e)
        {
            Operazione op = Sottrazione;

            MessageBox.Show("Modulo= "+Modulo(10,15,op));
        }
    
    }




}
