using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47_PrimoEsFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaricaCombo("input.txt");
        }

        private void CaricaCombo(string inputFile)
        {
            cmbParole.Items.Clear();
            string[] parole = new string[100];

            parole = ClsFile.LeggiParoleNonRipetute(inputFile);

            int i=0;
            while (parole[i] != "")
            {
                cmbParole.Items.Add(parole[i]);
                i++;
            }
        }
    }
}
