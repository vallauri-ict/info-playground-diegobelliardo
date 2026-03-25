using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _63_EsPag159
{
    public partial class Form1 : Form
    {
        struct Stundete
        {
            int matricola;
            string cognome;
            string nome;
            string dataNascita;
            string classe;
        }
        public Form1()
        {
            InitializeComponent();

            int nStudenti;
            string dato;
            do
            {
                dato = Interaction.InputBox("Inserisci numero studenti:");

            } while (!(int.TryParse(dato, out nStudenti)) || nStudenti<=0);

            //MessageBox.Show("Studenti: "+n);

            Stundete[] studenti = new Stundete[nStudenti];

            for (int i = 0; i < nStudenti; i++)
            {
                if (i==0)
                {
                    dato = Interaction.InputBox("Matricola studente:");
                }
                else
                {
                    do
                    {
                        dato = Interaction.InputBox("Matricola studente:");
                    }while()
                }
            }

        }
    }
}
