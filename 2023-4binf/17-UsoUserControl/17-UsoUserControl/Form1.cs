using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_UsoUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtMiaTextBox.Pulisci();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore in Testo: "+txtMiaTextBox.Testo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImpostaProperty(false);
        }

        private void ImpostaProperty(bool numero)
        {
            txtMiaTextBox.Pulisci();
            nudCifreDecimali.Value = 0;
            chkNumeri.Checked = numero;
            txtMiaTextBox.Numero=numero;
            txtMiaTextBox.CifreDecimali = Convert.ToInt32(nudCifreDecimali.Value);   
        }
    }
}
