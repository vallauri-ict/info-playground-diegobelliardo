using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Form2 f2;
            f2 = new Form2();
            f2.Text = "Form 2 creata da Designer";
            f2.Show();

            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 da Designer con paramentro";
            f2b.Show();

        }

        private void btnF2Controllo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtDaPassare);
            f2.Text = "Form 2 con passaggio di un TextBox";
            f2.Show();
        }

        private void btnFormModale_Click(object sender, EventArgs e)
        {
            FormModale frm = new FormModale();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Premuto pulsante OK\nNome: "+frm.nome+"\nEtà: "+frm.eta);
            }
            else MessageBox.Show("Premuto pulsante Annulla");
        }
    }
}
