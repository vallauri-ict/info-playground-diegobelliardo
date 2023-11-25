using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsOOP01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mannaro m2 = new Mannaro();
            m2.punti = 10;
            double x = m2.Valore_Proprio();
            double y = m2.Valore_Padre();
            double z = m2.Valore();
        }
    }
}
