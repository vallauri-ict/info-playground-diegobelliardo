﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_EreditarietaCollection
{
    public partial class Form1 : Form
    {
        List<Mostro> torma = new List<Mostro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungiMostro_Click(object sender, EventArgs e)
        {
            Mostro m = new Mostro();
            torma.Add(m);
        }

        private void btnAggiungiMannaro_Click(object sender, EventArgs e)
        {
            Mannaro m = new Mannaro();
            torma.Add(m);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (Mostro m in torma)
            {
                if (m is Mannaro)
                {
                    MessageBox.Show("Sono un Mannaro");
                }
                else if (m is Mostro)
                {
                    MessageBox.Show("Sono un Mostro");
                }
                else MessageBox.Show("Sono altro");
            }
        }
    }
}
