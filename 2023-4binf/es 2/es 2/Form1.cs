using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreaA_Click(object sender, EventArgs e)
        {
            if(lbl_CittaA.Text!="" && lbl_NomeA.Text!="")
            {
                Squadra squadra = new Squadra(lbl_NomeA.Text, lbl_CittaA.Text);
            }
            else
            {
                MessageBox.Show("inserire nome e città della squadra");
            }
            
            
        }

        private void creaB_Click(object sender, EventArgs e)
        {
            if (lbl_CittaB.Text != "" && lbl_NomeB.Text != "")
            {
                Squadra squadra = new Squadra(lbl_NomeA.Text, lbl_CittaA.Text);
            }
            else
            {
                MessageBox.Show("inserire nome e città della squadra");
            }
        }

        private void creaC_Click(object sender, EventArgs e)
        {
            if (lbl_CittaC.Text != "" && lbl_NomeC.Text != "")
            {
                Squadra squadra = new Squadra(lbl_NomeA.Text, lbl_CittaA.Text);
            }
            else
            {
                MessageBox.Show("inserire nome e città della squadra");
            }
        }
    }
}
