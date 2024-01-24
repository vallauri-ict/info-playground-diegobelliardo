using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_ClasseAstratta
{
    public partial class Form1 : Form
    {
        private ElencoStudenti studenti = new ElencoStudenti();
        private ElencoCalciatori calciatori = new ElencoCalciatori();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSStudenti_Click(object sender, EventArgs e)
        {
            studenti.print();
            MessageBox.Show(studenti.ritornoStampa());
        }

        private void btnSCalciatori_Click(object sender, EventArgs e)
        {
            calciatori.print();
            MessageBox.Show(calciatori.ritornoStampa());
        }
    }
}
