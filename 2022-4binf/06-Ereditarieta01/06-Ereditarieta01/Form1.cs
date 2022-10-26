using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Ereditarieta01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            Mannaro m = new Mannaro(5);
            MessageBox.Show("I punti sono: "+m.punti);
            MessageBox.Show("Valore proprio: "+m.Valore_Proprio());
            MessageBox.Show("Valore Padre: "+m.Valore_Padre());
            MessageBox.Show("Valore Totale: " + m.ValoreTotale());
            m.Valore();
        }
    }
}
