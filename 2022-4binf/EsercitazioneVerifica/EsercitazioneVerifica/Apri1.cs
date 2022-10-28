using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercitazioneVerifica
{
    public partial class Apri1 : Form
    {
        public bool checkPelle,checkStoffa;
        public string macchina;

        public Apri1()
        {
            InitializeComponent();
        }

        private void chkPelle_CheckedChanged(object sender, EventArgs e)
        {
            checkPelle = chkPelle.Checked;
        }

        private void chkStoffa_CheckedChanged(object sender, EventArgs e)
        {
            checkStoffa = chkStoffa.Checked;
        }

        private void cmbMacchina_SelectedIndexChanged(object sender, EventArgs e)
        {
            macchina = cmbMacchina.SelectedItem.ToString();
        }

        private void Apri1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form1.macchina = null;
            //Form1.checkStoffa = false;
            //Form1.checkPelle = false;
        }
    }
}
