using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MioControllo
{
    public partial class UserCTextBox: UserControl
    {
        private bool numero = false;    // se true la textbox accetta solo numeri
        private string testo;           // testo della textbox
        private int cifreDecimali = 0;  // contiene il numero di cifre decimali (dopo la virgola)

        public bool Numero { get => numero; set => numero = value; }
        
        public string Testo { 
            get {
                testo = UcTextBox.Text;
                return testo;
            }
            set {
                testo = value;
                UcTextBox.Text = testo;
            }
        }
        public int CifreDecimali { 
            get => cifreDecimali;
            set {
                cifreDecimali = value;
                ReimpostaTesto();
            }
        }

        public UserCTextBox()
        {
            InitializeComponent();
        }

        private void ReimpostaTesto()
        {
            if (numero && Testo!="")
            {
                try
                {
                    // controllare che non ci sia più di 1 virgola
                    if (ContaVirgole(Testo) > 1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }

                    double numero = Math.Round(Convert.ToDouble(Testo), CifreDecimali);
                    Testo = numero.ToString();
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
                char c1 = testo[i];
                if (c==',')
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
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar==',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            ReimpostaTesto();
        }
    }
}
