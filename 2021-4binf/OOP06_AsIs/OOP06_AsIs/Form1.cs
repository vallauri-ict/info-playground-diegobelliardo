using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP06_AsIs
{
    public partial class Form1 : Form
    {
        Random casuale = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneraMostro_Click(object sender, EventArgs e)
        {
            Mostro guardiano;
            if (casuale.Next(2) == 0)
            {
                guardiano = new Mannaro();
            }
            else
            {
                guardiano = new Zombi();
            }

            if (guardiano is Mannaro)
            {
                //Mannaro M = guardiano; NON FUNZIONA PERCHE' A TEMPO DI COMPILAZIONE NON SI SA COSA SIA

                MessageBox.Show("Verso come Mannaro: " + (guardiano as Mannaro).Verso());
                // IN ALTERNATIVA:
//                MessageBox.Show("Verso come Mannaro: " + ((Mannaro)guardiano).Verso());
            }
            else if (guardiano is Zombi)
            {
                MessageBox.Show("Verso come Zombi: " + (guardiano as Zombi).Verso());
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                (sender as Button).Text = "Cliccato";
            }
            if (sender is Label)
            {
                (sender as Label).BackColor = Color.Red;
            }
        }
    }
}
