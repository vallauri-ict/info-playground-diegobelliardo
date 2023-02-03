using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_UsoControlloPersonalizzato
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

        private void ImpostaProperty(bool isNumero)
        {
            txtMiaTextBox.Pulisci();
            nudCifreDecimali.Value = 0;
            chkSoloNumeri.Checked = isNumero;
            txtMiaTextBox.Numero = isNumero;
            txtMiaTextBox.CifreDecimali = Convert.ToInt32(nudCifreDecimali.Value);
        }

        private void Visualizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore Inserito: "+txtMiaTextBox.Testo);
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtMiaTextBox.Pulisci();
        }

        private void nudCifreDecimali_ValueChanged(object sender, EventArgs e)
        {
            txtMiaTextBox.CifreDecimali=Convert.ToInt32(nudCifreDecimali.Value);
        }

        private void chkSoloNumeri_CheckedChanged(object sender, EventArgs e)
        {
            ImpostaProperty(chkSoloNumeri.Checked);
        }

        private void txtMiaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMiaTextBox_ErrorEvent(object sender, _15_ControlloPersonalizzato.ErrorEventArgs e)
        {
            MessageBox.Show(e.ErrorMessage);
        }
    }
}
