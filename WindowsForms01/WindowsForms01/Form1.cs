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
            Form2 f2 = new Form2();
            f2.Text = "Form 2 da Design";
            f2.Show();

            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 da Design con parametro";
            f2b.Show();
        }

        private void btnApriF2b_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Form 2 Dinamica";
            f2b.Show();
        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(txtPassata);
            f2b.Text = "Form 2 con passaggio di TextBox";
            f2b.Show();
        }
    }
}
