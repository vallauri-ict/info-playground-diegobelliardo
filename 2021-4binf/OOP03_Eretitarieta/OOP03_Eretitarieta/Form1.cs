using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP03_Eretitarieta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaMannaro_Click(object sender, EventArgs e)
        {
            Mannaro m1 = new Mannaro("Mannaro");


        }
    }
}
