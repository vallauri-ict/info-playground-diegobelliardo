using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_PrimoEsDispenseDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Fattura f = new Fattura();

            f.salvataggioEseguito += MiaFunzione;
            f.salvataggioEseguito += new salvataggioEseguitoEventHandler(MiaFunzione2);

            f.SalvaSuFile();
        }

        private void MiaFunzione2(int id)
        {
            MessageBox.Show("Secondo gestore di evento!");
        }

        private void MiaFunzione(int id)
        {
            MessageBox.Show("Salvataggio Fattura "+id+" AVVENTO!");
        }
    }
}
