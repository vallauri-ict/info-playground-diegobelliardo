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
    public partial class Apri2 : Form
    {
        private string macchina;
        private bool verificaStoffa;
        private bool verificaPelle;
        public Apri2()
        {
            InitializeComponent();
        }
        public Apri2(string macchina, bool chkStoffa,bool chkPelle)
        {
            InitializeComponent();
            this.macchina = macchina;
            this.verificaStoffa = chkStoffa;
            this.verificaPelle = chkPelle;
        }

        public Apri2(Apri1 f1)
        {
            InitializeComponent();
            this.macchina = f1.macchina;
            this.verificaStoffa = f1.checkStoffa;
            this.verificaPelle = f1.checkPelle;
        }

        private void Apri2_Load(object sender, EventArgs e)
        {
            if (verificaPelle)
            {
                lblFormattazione.Text = $"Hai selezionato una {macchina} con sedili in pelle"; 
            }
            else if (verificaStoffa)
            {
                lblFormattazione.Text = $"Hai selezionato una {macchina} con sedili in stoffa";
            }
        }
    }
}
