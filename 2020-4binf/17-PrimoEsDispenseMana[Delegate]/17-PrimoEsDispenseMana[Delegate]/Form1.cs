using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_PrimoEsDispenseMana_Delegate_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            GestoreSalvataggio gest = new GestoreSalvataggio();

            gest.salvataggioEseguito += new salvataggioEseguitoEventHandler(MiaFunzione);
            gest.salvataggioEseguito += new salvataggioEseguitoEventHandler(MiaFunzione2);
            gest.SalvaSuFile(5);
        }

        private void MiaFunzione(int id)
        {
            MessageBox.Show("Elemento "+id+" salvato correttamente");
        }

        private void MiaFunzione2(int id)
        {
            MessageBox.Show("Secondo gestore di evento");
        }
    }
}
