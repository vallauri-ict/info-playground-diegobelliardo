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
    public partial class Form1 : Form
    {
        //public static string macchina;
        //public static bool checkPelle;
        //public static bool checkStoffa;

        private Apri1 f1=null;

        public Form1()
        {
            InitializeComponent();
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1== null)
            {
                f1 = new Apri1();
                f1.MdiParent = this;
            }
            f1.Show();
            //macchina = null;
            //checkPelle = false;
            //checkStoffa = false;
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttsMacchina.Text = $"La tua auto e' {f1.macchina}";
            if (f1.macchina!=null && f1.checkPelle || f1.checkStoffa)
            {
                var f2 = new Apri2(f1);
                f2.MdiParent = this;
                f2.Show();
            }
            else
            {
                var modale = new Modale1();
                if(modale.ShowDialog() == DialogResult.OK)
                {
                    modale.Close();
                }
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var modale = new ModaleEsci();
            if(modale.ShowDialog() != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
