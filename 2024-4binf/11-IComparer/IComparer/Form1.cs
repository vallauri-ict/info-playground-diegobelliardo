using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Persona[] vect = new Persona[] { new Persona("Samuele", "Savigliano"),
                                             new Persona("Mario", "Busca"),
                                             new Persona("Luca", "Roccavignale")};

            // Array.Sort(vect, new Persona.confrontaNome());
            Array.Sort(vect, Persona.cmpNome());

            string s = "ORDINATO IN BASE AL NOME:\n";
            for (int i = 0; i < vect.Length; i++)
            {
                s += vect[i].ToString() + "\n";
            }
            MessageBox.Show(s);

            // Array.Sort(vect, new Persona.confrontaCitta());
            Array.Sort(vect, Persona.cmpCitta());

            s = "ORDINATO IN BASE ALLA CITTA':\n";
            for (int i = 0; i < vect.Length; i++)
            {
                s += vect[i].ToString() + "\n";
            }
            MessageBox.Show(s);
        }


    }
}
