using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoUcPersonalizzata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImpostaProperty(false);
        }

        private void ImpostaProperty(bool v)
        {
            try
            {
                txtMiaTextBox.Pulisci();
                nudCifreDecimali.Value = 0;
                chkNumeri.Checked = v;
                txtMiaTextBox.Numero = v;
                txtMiaTextBox.CifreDecimali = Convert.ToInt32(nudCifreDecimali.Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btbVisualizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore inserito: "+txtMiaTextBox.Testo);
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtMiaTextBox.Pulisci();
        }

        private void chkNumeri_CheckedChanged(object sender, EventArgs e)
        {
            ImpostaProperty(chkNumeri.Checked);
        }

        private void nudCifreDecimali_ValueChanged(object sender, EventArgs e)
        {
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
