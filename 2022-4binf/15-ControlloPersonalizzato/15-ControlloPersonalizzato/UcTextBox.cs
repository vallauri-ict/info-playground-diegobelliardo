using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_ControlloPersonalizzato
{
    public partial class UcTextBox: UserControl
    {
        private bool numero = false;     // se true txtbox accetta solo numeri
        private string testo;           // testo della textBox
        private int cifreDecimali = 0;  // contiene il numero di cifre decimali (dopo la virgola)

        public bool Numero { get => numero; set => numero = value; }
        public string Testo { 
            get
            {
                testo = txtTesto.Text;
                return testo;
            }
            set
            {
                testo=value;
                txtTesto.Text = testo;
            }
        }
        public int CifreDecimali
        {
            get { return cifreDecimali; }
            set
            {
                cifreDecimali = value;
                AggiornaTesto();
            }
        }

        public UcTextBox()
        {
            InitializeComponent();
        }

        private void AggiornaTesto()
        {
            if (Numero && Testo!="")
            {
                //controllo che non ci sia più di una virgola
                if (ContaVirgole(Testo)>1)
                {
                    throw new Exception("Ci sono troppe virgole");
                }
                try
                {
                    //controllo dei decimali
                    double numero = Math.Round(Convert.ToDouble(Testo), CifreDecimali);
                    Testo = numero.ToString();

                    string[] s = Testo.Split(',');
                    if (s[1]==null && cifreDecimali>0)
                    {

                    }
                    // Gestione degli 0 dopo la virgola in caso di numero intero
                }
                catch (Exception)
                {
                    throw new Exception("Valore non valido");
                }
            }
        }

        private int ContaVirgole(string testo)
        {
            if (testo != null)
                return testo.Split(',').Length - 1;
            else return 0;
        }

        public void Pulisci()
        {
            Testo = "";
        }

        private void txtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numero)
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar==',' || char.IsControl(e.KeyChar)))
                {
                    throw new Exception("Errore digitazione");
                }
            }
        }

        private void UcTextBox_Leave(object sender, EventArgs e)
        {
            AggiornaTesto();
        }

       
    }
}
