using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_03_Squadre_di_Calcio
{
    public partial class frmSquadreCalcio : Form
    {
        Squadre sqA, sqB, sqC;

        public frmSquadreCalcio()
        {
            InitializeComponent();
        }

        private void frmSquadreCalcio_Load(object sender, EventArgs e)
        {
        }

        
        private void btnCreaA_Click(object sender, EventArgs e)
        {
            sqA = new Squadre("Atlante", "Monteacuto", 0, 0, 0);
            txtPrimaSquadra.Text = sqA.città;
            txtPrimoValore.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();
        }

        private void btnCreaB_Click(object sender, EventArgs e)
        {
            sqB = new Squadre("Macedonia", "Golfo Aranci", 0, 0, 0);
            txtSecondaSquadra.Text = sqB.città;
            txtSecondoValore.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();
        }

        private void btnVinceB_Click(object sender, EventArgs e)
        {
            sqB.vinte++;
            txtSecondoValore.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();
        }

        private void btnVinceC_Click(object sender, EventArgs e)
        {
            sqC.vinte++;
            txtTerzoValore.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();
        }

        private void btnPareggiaA_Click(object sender, EventArgs e)
        {
            sqA.pareggiate++;
            txtPrimoValore.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();
        }

        private void btnPareggiaB_Click(object sender, EventArgs e)
        {
            sqB.pareggiate++;
            txtSecondoValore.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();
        }

        private void btnPareggiaC_Click(object sender, EventArgs e)
        {
            sqC.pareggiate++;
            txtTerzoValore.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();
        }

        private void btnCreaC_Click(object sender, EventArgs e)
        {
            sqC = new Squadre("Virtus", "Città vecchia", 0, 0, 0);
            txtTerzaSquadra.Text = sqC.città;
            txtTerzoValore.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();
        }

        private void btnVinceA_Click(object sender, EventArgs e)
        {
            sqA.vinte++;
            txtPrimoValore.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();
        }
    }
}
 