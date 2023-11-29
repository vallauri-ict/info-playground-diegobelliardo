using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_OOP04
{
    public partial class Form1 : Form
    {
        internal Mostro m1;
        internal Mannaro man;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostro_Click(object sender, EventArgs e)
        {
            m1=new Mostro();
            MessageBox.Show($"Valore: {m1.Valore()}\nVerso: {m1.Verso()}");
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            man=new Mannaro();
            MessageBox.Show($"Valore: {man.Valore()}\nVerso: {man.Verso()}");
            MessageBox.Show(man.Valore() + " " + man.Verso());
            
            man.Muta();
            MessageBox.Show($"Valore: {man.Valore()}\nVerso: {man.Verso()}");
            MessageBox.Show(man.Valore() + " " + man.Verso());
        }
    }
}
