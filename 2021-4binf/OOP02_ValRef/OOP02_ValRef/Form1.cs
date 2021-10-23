using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP02_ValRef
{
    public partial class Form1 : Form
    {
        Persona abele = new Persona(); //abele punta a una persona appena creata

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            
            abele.eta = 17;
            MessageBox.Show("Età prima del richiamo a Compleanno:\n"+abele.eta);
            Compleanno(abele);
            MessageBox.Show("Età DOPO il richiamo a Compleanno:\n" + abele.eta);
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            abele.eta = 54;
            MessageBox.Show("Età prima del richiamo a Supplenza:\n" + abele.eta);
            Supplenza(ref abele);
            MessageBox.Show("Età prima DOPO il richiamo a Supplenza:\n" + abele.eta);
        }

        private void Compleanno(Persona p)
        {
            p.eta++;
        }

        private void Supplenza(ref Persona p)
        {
            p = new Persona();
            p.eta = 27;
        }

        
    }
}
