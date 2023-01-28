using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_SecondoEsDelegateDispense
{
    public partial class Form1 : Form
    {
        private Counter cnt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            try
            {
                cnt = new Counter(Convert.ToInt32(txtValoreSoglia.Text));
                cnt.OverMax += gestioneMaxValue;
                cnt.OverMax += gestioneMaxValue2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ATTENZIONE!!");
            }
        }

        private void gestioneMaxValue2(object sender, OverMaxEventArgs e)
        {
            MessageBox.Show("Secondo gestore evento");
        }

        private void gestioneMaxValue(object sender, OverMaxEventArgs e)
        {
            MessageBox.Show("Raggiunto il valore: "+e.ValoreSoglia);
        }

        private void btnIncrementa_Click(object sender, EventArgs e)
        {
            cnt.Increment();
        }
    }
}
