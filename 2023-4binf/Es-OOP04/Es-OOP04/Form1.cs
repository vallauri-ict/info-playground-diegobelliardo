using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_OOP04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        internal Mostro Clona_V(Mostro p) //rende un Mostro nuovo?
        {
            p = new Mostro("Valuex");
            p.nome = "Cambia";
            return p;
        }
        internal Mostro Clona_R(ref Mostro p) //rende un Mostro nuovo?
        {
            p = new Mostro("Referx");
            p.nome = "Cambia";
            return p;
        }
        internal Mostro Clona_O(out Mostro p) //rende un Mostro nuovo?
        {
            p = new Mostro("Resulx");
            p.nome = "Cambia";
            return p;
        }

        private void btnValore_Click(object sender, EventArgs e)
        {
            Mannaro x = new Mannaro("Valore");
            Mostro y;
            x.Rivela();
            y = Clona_V(x);
            x.Rivela();
            y.Rivela();
        }

        private void btnRiferimento_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            x.Rivela();
            y = Clona_R(ref x);
            x.Rivela();
            y.Rivela();
        }

        private void btnRisultato_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            x.Rivela();
            y = Clona_O(out x);
            x.Rivela();
            y.Rivela();
        }
    }
}
