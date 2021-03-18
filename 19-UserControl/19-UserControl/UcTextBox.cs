using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_UserControl
{
    public partial class UcTextBox: UserControl
    {
        private bool numero = false;  // se true la textbox accetta solo numeri
        private string testo;         // testo della textbox
        private int cifreDecimali = 0; //countiene il numero di cifre decimali (dopo la virgola)

        public bool Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Testo
        {
            get
            {
                testo = txtTesto.Text;
                return testo;
            }
            set
            {
                testo = value;
                txtTesto.Text = testo;
            }
        }

        public int CifreDecimali
        {
            get { return cifreDecimali; }
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
            if (numero && Testo != "")
            {
                try
                {
                    //controllare che non ci siano più di 1 virgola
                    if (ContaVirgola(Testo) > 1)
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

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numero)
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    //throw new NotImplementedException();
                }
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            ReimpostaTesto();
        }
    }
}
