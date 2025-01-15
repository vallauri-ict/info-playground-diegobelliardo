using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Interf_Ordinamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Persona[] vect=new Persona[] { new Persona("Luca","Fossano"),
                                            new Persona("Stefano","Fossano"),
                                            new Persona("Samuele","Savigliano")};
            Array.Sort(vect);
            string s = "";

            for (int i = 0; i < vect.Length; i++)
            {
                s+= (i+1)+"-"+vect[i].nome+"\n";
            }
            MessageBox.Show(s);
        }
    }
}
