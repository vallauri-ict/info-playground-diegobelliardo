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

namespace RegEx01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$";
            Regex rgx = new Regex(pattern);
            string str = txtStr.Text;

            MessageBox.Show(str+"  "+rgx.IsMatch(str));

            MessageBox.Show(str + "  " +Regex.IsMatch(str,pattern));
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            string str = "One car red car blue car";
            string pattern= @"(\w+)\s+(car)";
            int count = 0;

            Regex reg = new Regex(pattern);
            Match m = reg.Match(str);
            
            while (m.Success)
            {
                MessageBox.Show("Trovato: gruppo "+(++count)+" Valore: "+m.Value+
                                " Alla posizione: "+m.Index);

                m = m.NextMatch();
            }
        }
    }
}
