﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Ereditarieta02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostro_Click(object sender, EventArgs e)
        {
            Mostro demone = new Mostro();
            MessageBox.Show("Punti: "+demone.Valore()+" Verso: "+demone.Verso());
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            Mannaro umano = new Mannaro();
            MessageBox.Show("Punti: " + umano.Valore() + " Verso: " + umano.Verso());
            umano.Muta();
            MessageBox.Show("Punti: " + umano.Valore() + " Verso: " + umano.Verso());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostro m1 = new Mostro();
            Mostro m2 = new Mostro();
            Mannaro lupo1 = new Mannaro();
            Mannaro lupo2 = new Mannaro();

            m1 = lupo1;

//            lupo2 = (Mannaro)m2;        //Errato
//            lupo2 = m2;                 //Errato


            m2 = new Mannaro();
   //         lupo1 = new Mostro();     //Errato

        }
    }
}
