using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_OOP01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            int lato1 = Convert.ToInt32(txtBase.Text);
            int lato2 = Convert.ToInt32(txtAltezza.Text);

            Rettangolo r = new Rettangolo(lato1, lato2);
            r.Lato1 = 0;
            int l = r.Lato1;
            MessageBox.Show("Area del rettangolo: "+r.Area());
        }

        private void btnCreaQuadrato_Click(object sender, EventArgs e)
        {
            int lato = Convert.ToInt32(txtLato.Text);

            Rettangolo r = new Rettangolo(lato);
            MessageBox.Show("Area del quadrato: " + r.Area());

        }

        private void btnCreaDefault_Click(object sender, EventArgs e)
        {
            Rettangolo r = new Rettangolo();
            MessageBox.Show("Area della figura default: " + r.Area());
        }
    }
}
