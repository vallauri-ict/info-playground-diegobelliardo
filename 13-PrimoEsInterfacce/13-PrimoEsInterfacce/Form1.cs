using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_PrimoEsInterfacce
{
    public partial class Form1 : Form
    {
        MyComponent con = new MyComponent();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            con.connetti("Componente 1");
        }

        private void btnDisconnetti_Click(object sender, EventArgs e)
        {
            con.disconnetti("Componente 1");
        }

        private void btnStato_Click(object sender, EventArgs e)
        {
            con.Stato();
        }
    }
}
