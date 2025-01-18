using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_UserControl
{
    public partial class ucTextBox: UserControl
    {
        private bool numero = false;    //se true la text box accetta solo numeri
        private string testo;           //testo della textBox
        private int cifreDecimali=0;      //contiene il numero di cifre decimali


        public bool Numero
        {
            get => numero;
            set
            {
                numero = value;
                ReimpostaTesto();
            }
        }
        public string Testo { 
            get { 
                testo = txtTextBox.Text;
                return testo;
            }
            set {
                testo = value;
                txtTextBox.Text = testo;
            }
        }
        public int CifreDecimali { 
            get => cifreDecimali; 
            set { 
                cifreDecimali = value;
                ReimpostaTesto();
            } 
        }
        public ucTextBox()
        {
            InitializeComponent();
        }

        private void ReimpostaTesto()
        {
            if (Numero && Testo!="")
            {
                try
                {
                    if (ContaVirgole(Testo) > 1)
                    {
                        MessageBox.Show("Ci sono troppe virgole");
                        Pulisci();
                    }
                    else
                    {
                        //controllo dei decimali
                        decimal numero = Math.Round(Convert.ToDecimal(Testo), CifreDecimali);
                        //Testo = numero.ToString();

                        Testo=numero.ToString("N"+CifreDecimali);
                        // Gestione degli 00 dopo la virgola in caso di numero intero
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Valore non valido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Pulisci();
                }
            }
        }

        private int ContaVirgole(string testo)
        {
            int cont = 0;
            for (int i = 0;i<testo.Length;i++)
            {
                char c = testo[i];
                if (c == ',')
                {
                    cont++;
                }
            }
            return cont;
        }

        public void Pulisci()
        {
            Testo = "";
        }

        private void txtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numero)
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar==',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTextBox_Leave(object sender, EventArgs e)
        {
            ReimpostaTesto();
        }
    }
}
