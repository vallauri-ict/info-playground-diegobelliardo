using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP05_Dictionary
{
    public partial class Form1 : Form
    {
        public struct libro
        {
            public string titolo;
            public string autore;
        }

        int pos=0;
        Dictionary<int, libro> dicLibri = new Dictionary<int, libro>();
        Queue<libro> codaLibri = new Queue<libro>();
        Stack<libro> pilaLibri = new Stack<libro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungiLibro_Click(object sender, EventArgs e)
        {
            libro l;

            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            dicLibri.Add(++pos, l);
        }

        private void btnVisElm_Click(object sender, EventArgs e)
        {
            foreach(int key in dicLibri.Keys)
            {
                MessageBox.Show("Chiave: "+key);
            }

            foreach(libro l in dicLibri.Values)
            {
                MessageBox.Show("(Valore) Titolo del libro: "+l.titolo);
            }
        }

        private void btnVisIndiceLibro_Click(object sender, EventArgs e)
        {
            libro l = dicLibri[Convert.ToInt32(nudIndiceLibro.Value)];
            MessageBox.Show("Libro: "+l.titolo+"\nAutore: "+l.autore);
        }

        private void btnAggiungiCoda_Click(object sender, EventArgs e)
        {
            libro l;

            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            codaLibri.Enqueue(l);
        }

        private void btnAggiungiPila_Click(object sender, EventArgs e)
        {
            libro l;

            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            pilaLibri.Push(l);
        }

        private void btnEstraiCoda_Click(object sender, EventArgs e)
        {
            libro l = codaLibri.Dequeue();
            MessageBox.Show("Libro: "+l.titolo+"\nAutore: "+l.autore);
        }

        private void btnEstraiPila_Click(object sender, EventArgs e)
        {
            libro l = pilaLibri.Pop();
            MessageBox.Show("Libro: " + l.titolo + "\nAutore: " + l.autore);
        }
    }
}
