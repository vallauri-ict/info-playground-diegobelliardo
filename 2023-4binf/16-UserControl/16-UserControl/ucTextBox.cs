using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_UserControl
{
    public partial class ucTextBox: UserControl
    {
        private bool numero = false;    // se true la text box accetta solo numeri
        private string testo;           // testo della textBox
        private int cifreDecimali = 0;  // contiene in numero di cifre decimali


        public bool Numero { get => numero; set => numero = value; }
        public string Testo { get => testo; set => testo = value; }
        public int CifreDecimali {
            get { return cifreDecimali; }
            set
            {
                cifreDecimali = value;
                ReimpostaTesto();
            }
        }

        private void ReimpostaTesto()
        {
            if (numero && Testo != "")
            {
                try
                {
                    if (ContaVirgole(Testo) > 1)
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

        private int ContaVirgole(string testo)
        {
            int count = 0;
            for (int i = 0; i < testo.Length; i++)
            {
                char c = Convert.ToChar(testo.Substring(i, 1));
                if (c == ',')
                {
                    count++;
                }
            }
            return count;
        }

        public ucTextBox()
        {
            InitializeComponent();
        }

        public void Pulisci()
        {
            Testo = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            ReimpostaTesto();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numero)
            {
                if ((char.IsDigit(e.KeyChar) || e.KeyChar==',' || char.IsControl(e.KeyChar)))
                {

                }
            }
        }
    }
}
