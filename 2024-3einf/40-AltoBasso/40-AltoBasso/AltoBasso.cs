using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40_AltoBasso
{
    public partial class Form1 : Form
    {
        const int NUMEROTENTATIVIBASE = 5;
        const int NUMEROTENTATIVIINTERMEDIO = 10;
        const int NUMEROTENTATIVIAVANZATO = 20;

        const int maxNumBase = 100;
        const int maxNumIntermedio = 500;
        const int maxNumAvanzato = 1000;

        Random rnd = new Random();
        int numeroSegreto;
        int tentativiRimasti;

        public Form1()
        {
            InitializeComponent();
            btnIndovina.Enabled = false;
            txtNumero.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbBase_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBase.Checked)
            {

            }

        }
    }
}
