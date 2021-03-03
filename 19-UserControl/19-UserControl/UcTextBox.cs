using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_UserControl
{
    public partial class UcTextBox : UserControl
    {

        private bool numero = false;  // se true la textbox accetta solo numeri
        private string testo;         // testo della textbox
        private int cifreDecimali = 0; //countiene il numero di cifre decimali (dopo la virgola)

        public bool Numero
        {
            get => numero;
            set => numero = value;
        }

        public string Testo
        {
            get => testo=txtTesto.Text;
            set
            {
                testo = value;
                txtTesto.Text = testo;
            } 
        }

        public int CifreDecimali
        {
            get => cifreDecimali;
            set
            {
                cifreDecimali = value;
                ReimpostaTesto();
            } 
        }

        public UcTextBox()
        {
            InitializeComponent();
        }


        private void ReimpostaTesto()
        {
            if (numero && Testo!="")
            {
                try
                {
                    //controllare che non ci siano più di 1 virgola
                    if (ContaVirgola(Testo)>1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }

                    //controllo dei decimali
                    double numero = Math.Round(Convert.ToDouble(Testo), CifreDecimali);
                    Testo = numero.ToString();

                    // Gestione degli 00 dopo la virgola in caso di numero intero


                }
                catch (Exception)
                {
                    throw new Exception("Valore non valido");
                }
            }
        }

        private int ContaVirgola(string t)
        {
            int count = 0;

            for (int i = 0; i < t.Length; i++)
            {
                char c = Convert.ToChar(t.Substring(i, 1));
                if (c == ',')
                {
                    count++;
                }
            }

            return count;
        }

        public void Pulisci()
        {
            Testo = "";
        }

        private void TxtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /*
        private void TxtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (numero)
            {                               //  char.IsPunctuation()
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar)))
                {
                    throw new NotImplementedException();
                }
            }
        }
        */
    }
}
