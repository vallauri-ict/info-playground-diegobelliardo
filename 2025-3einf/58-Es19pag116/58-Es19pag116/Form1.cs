using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58_Es19pag116
{
    public partial class Form1 : Form
    {
        string[] cantanti = {
            "Laura Pausini",
            "Laura Pausini",
            "Tiziano Ferro",
            "Tiziano Ferro",
            "Eros Ramazzotti",
            "Eros Ramazzotti",
            "Giorgia",
            "Giorgia",
            "Vasco Rossi",
            "Vasco Rossi"
        };

        string[] canzoni = {
            "La solitudine",
            "Strani amori",
            "Sere nere",
            "Non me lo so spiegare",
            "Più bella cosa",
            "Un'emozione per sempre",
            "Come saprei",
            "Gocce di memoria",
            "Albachiara",
            "Sally"
        };
        public Form1()
        {
            InitializeComponent();
            lstCanzoni.Items.AddRange(canzoni);
            lstCantanti.Items.AddRange(cantanti);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            if (txtCantante.Text != null && txtCantante.Text.Length>2)
            {
                int count = 0;

                for (int i = 0; i < cantanti.Length; i++)
                {
                    if (txtCantante.Text.CompareTo(cantanti[i]) == 0)
                    {
                        count++;
                    }
                }

                MessageBox.Show($"Sono presenti {count} canzoni di {txtCantante.Text}");
            }
            else MessageBox.Show("Devi inserire almeno 3 caratteri!",
                    "ATTENZIONE!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
