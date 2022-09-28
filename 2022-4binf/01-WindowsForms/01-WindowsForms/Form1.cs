using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            F2 form2;
            form2 = new F2();
            form2.Text = "Sono la Form 2 - creata da Designer";
            form2.Show();
            

        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            Form f3;
            f3 = new Form();
            f3.Text = "Sono la Form 3 - creata da Codice";
            f3.Show();
        }

        private void btnF4Param_Click(object sender, EventArgs e)
        {
            F4 form4 = new F4(10);
            form4.Show();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            F5 form5 = new F5(txtMesaggio);
            form5.Show();
        }

        private void btnModale_Click(object sender, EventArgs e)
        {
            FormModale formModale = new FormModale();
            if (formModale.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Nome: "+ formModale.nome + "\nCognome: "+formModale.cognome);
            }
            else
                MessageBox.Show("Premuto pulsante Annulla");
        }
    }
}
