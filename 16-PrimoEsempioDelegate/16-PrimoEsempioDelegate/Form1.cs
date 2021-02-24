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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Dichiarazione del delegate che accetta 2 parametri interi
        //e restituisce un valore intero
        public delegate int Operazione(int a, int b);


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
    }
}
