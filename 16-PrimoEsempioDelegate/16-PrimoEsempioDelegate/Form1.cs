using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_PrimoEsempioDelegate
{
    //Dichiarazione del delegate che accetta 2 parametri interi
    //e restituisce un valore intero
    public delegate int Operazione(int a, int b);
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //dichiaro le 3 funzioni che utilizzerò con il delegate
        public int Somma(int x, int y)
        {
            return x + y;
        }

        public int Sottrazione(int x, int y)
        {
            return x - y;
        }

        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        public int dif(int a, int b, Operazione op)
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


        private void btnSomma_Click(object sender, EventArgs e)
        {
            //PRIMO METODO per usare un delegate
            //Istanzio il delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma);  //Somma è la "funzione" puntata dal delegate

            //Richiamo il delegate che eseguirà la funzione Somma
            MessageBox.Show("Somma= " + op(10, 15));
        }

        private void btnProdotto_Click(object sender, EventArgs e)
        {
            //SECONDO METODO Istanzio il delegato
            Operazione op = Prodotto;

            //Richiamo 
            MessageBox.Show("Prodotto= " + op(10, 15));
        }

        private void btnSottrazione_Click(object sender, EventArgs e)
        {
            /*
            Operazione op = Sottrazione;

            MessageBox.Show("Sottrazione= "+op(15,10));
            */

            //3° metodo
            //istanziamo il delegato
            Operazione op = Sottrazione;  //puntatore a sottrazione

            //richiamo dif passandogli come parametro il delegato
            MessageBox.Show("differenza = " + dif(10, 12, op).ToString());
        }
    }
}
