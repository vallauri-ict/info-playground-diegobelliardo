using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_FormMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriFiglia1_Click(object sender, EventArgs e)
        {
            Figlia1 f1 = new Figlia1();
            f1.MdiParent = this;
            f1.Show();
            f1.Size = new Size(200, 150);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(0, 60);
            tsslInfo.Text = "Aperta finestra figlia 1";
        }

        private void btnFiglia2_Click(object sender, EventArgs e)
        {
            Figlia2 f2 = new Figlia2();
            f2.MdiParent = this;
            f2.Show();
            f2.Size = new Size(200, 150);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(205, 60);
            tsslInfo.Text = "Aperta finestra figlia 2";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tsslInfo.Text = "";
            ModaleEsci form = new ModaleEsci();
            if (form.ShowDialog() != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
