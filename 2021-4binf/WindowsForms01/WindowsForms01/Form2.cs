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
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        public Form2(TextBox txt)
        {
            InitializeComponent();
            this.txt = txt;
//            txt.Text = "Ciao da F2";
        }

        private void btnF2Leggi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt.Text);
        }

        private void btnInviaAForm1_Click(object sender, EventArgs e)
        {
            txt.Text = txtF2.Text;
        }

        private void btnF2ApriFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();
            this.AddOwnedForm(f);
            f.Show();
        }
    }
}
