using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_UsoUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtMiaTextBox.Pulisci();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore del Testo: "+txtMiaTextBox.Testo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMiaTextBox.Pulisci();
            nudCifreDecimali.Value = 0;
            chkNumeri.Checked = false;
            txtMiaTextBox.Numero = chkNumeri.Checked;
            try
            {
                txtMiaTextBox.CifreDecimali = Convert.ToInt32(nudCifreDecimali.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
