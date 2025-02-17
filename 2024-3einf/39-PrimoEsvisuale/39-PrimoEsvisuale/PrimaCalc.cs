using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_PrimoEsvisuale
{
    public partial class PrimaCalc : Form
    {
        public PrimaCalc()
        {
            InitializeComponent();
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            lblRisultato.Text = (Convert.ToDouble(txtOp1.Text) + Convert.ToDouble(txtOp2.Text)).ToString();
        }

        private void btnSottrazione_Click(object sender, EventArgs e)
        {
            lblRisultato.Text = (Convert.ToDouble(txtOp1.Text) - Convert.ToDouble(txtOp2.Text)).ToString();
        }

        private void btnMoltiplicazione_Click(object sender, EventArgs e)
        {
            lblRisultato.Text = (Convert.ToDouble(txtOp1.Text) * Convert.ToDouble(txtOp2.Text)).ToString();
        }

        private void btnDivisione_Click(object sender, EventArgs e)
        {
            lblRisultato.Text = (Convert.ToDouble(txtOp1.Text) / Convert.ToDouble(txtOp2.Text)).ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOp1.Text = "";
            txtOp2.Text = "";
            lblRisultato.Text = "-------------";
        }
    }
}
