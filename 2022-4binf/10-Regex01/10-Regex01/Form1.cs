using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Regex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            Regex reg=new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");

            if (reg.IsMatch(txtStr.Text))
            {
                MessageBox.Show("La stringa "+ txtStr.Text+" è corretta");
            }
            else MessageBox.Show("La stringa " + txtStr.Text + " NON è corretta");
        }
    }
}
