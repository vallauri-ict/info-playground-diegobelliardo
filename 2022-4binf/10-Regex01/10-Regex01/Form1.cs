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
            //^[A-Z](?=[a-z]+).{3,}

            Regex reg =new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");

            if (reg.IsMatch(txtStr.Text))
            {
                MessageBox.Show("La stringa "+ txtStr.Text+" è corretta");
            }
            else MessageBox.Show("La stringa " + txtStr.Text + " NON è corretta");
        }

        private void btnOneCar_Click(object sender, EventArgs e)
        {
            string str = "One car red car blue car";
            string pattern= @"(\w+)\s+(car)";
            int count = 0;

            Regex reg = new Regex(pattern);
            Match m = reg.Match(str);
            /*
            while (m.Success)
            {
                MessageBox.Show("Trovat: gruppo "+(count++)+" Valore: "+
                    m.Value+" Alla posizione: "+m.Index);
                m = m.NextMatch();
            }*/

            while (m.Success)
            {
                for (int i = 1; i <= 2; i++)
                {
                    Group g = m.Groups[i];
                    MessageBox.Show("Gruppo "+i+" = "+g);
                    CaptureCollection c = g.Captures;
                    for (int j = 0; j < c.Count; j++)
                    {
                        Capture cap = c[j];
                        MessageBox.Show("Capture "+j+" = "+cap+" position= "+cap.Index);
                    }

                }
                m = m.NextMatch();
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string str = "123ABCDE456FGHIJKL789MNOPQ012";
            string pattern = @"\d+";

            Regex reg = new Regex(pattern);

            string[] s = reg.Split(str);

            for (int i = 0; i < s.Length; i++)
            {
                MessageBox.Show("Stringa "+(i+1)+": \""+s[i]+"\"");
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string str= "This is    text with   far    too   much " +
                        "whitespace.";
            string pattern = @"\s+";
            string replacement = " ";

            Regex reg = new Regex(pattern);
            string result = reg.Replace(str, replacement);

            MessageBox.Show("Stringa originale: \""+str+
                            "\"\nStringa modificata: \""+result+"\"");
        }
    }
}
