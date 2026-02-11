using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57_Es17Pag116
{
    public partial class FormCanzoni : Form
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
        public FormCanzoni()
        {
            InitializeComponent();
            lstCantanti.Items.AddRange(cantanti);
            lstCanzoni.Items.AddRange(canzoni);
        }

        private void btnCercaCanzoni_Click(object sender, EventArgs e)
        {
            string cantante=txtNomeCantante.Text;

            // toDo Ricerca CAnzoni e caricamento in ListBox
        }
    }
}
