using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_ClasseIndexata
{
    public partial class Form1 : Form
    {
        MyIndexClass indexVect;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            indexVect = new MyIndexClass(Convert.ToInt32(txtElementi.Text));
            for (int i = 0; i < Convert.ToInt32(txtElementi.Text)-1; i++)
            {
                indexVect[i] = i.ToString();
            }
            MessageBox.Show("Oggetto creato correttamente");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < indexVect.length(); i++)
            {
                s += indexVect[i] + " - ";
            }
            MessageBox.Show("Elementi: "+s);
        }
    }
}
