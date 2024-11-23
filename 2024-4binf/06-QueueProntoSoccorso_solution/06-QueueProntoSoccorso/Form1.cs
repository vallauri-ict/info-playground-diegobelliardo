using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_QueueProntoSoccorso
{
    public partial class Form1 : Form
    {
        Queue<Paziente> queRossa = new Queue<Paziente>();
        Queue<Paziente> queGialla = new Queue<Paziente>();
        Queue<Paziente> queVerde = new Queue<Paziente>();
        Queue<Paziente> queBianca = new Queue<Paziente>();

        Queue<Paziente>[] code = new Queue<Paziente>[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Paziente p = new Paziente(txtNome.Text, txtEta.Text, cmbColori.SelectedItem.ToString());
            switch (cmbColori.SelectedItem.ToString())
            {
                case "Rosso":
                    queRossa.Enqueue(p);
                    break;
                case "Giallo":
                    queRossa.Enqueue(p);
                    break;
                case "Verde":
                    queRossa.Enqueue(p);
                    break;
                case "Bianco":
                    queRossa.Enqueue(p);
                    break;
            }
        }

        private void btnProssimoPaziente_Click(object sender, EventArgs e)
        {
            if (queRossa.Count > 0)
            {
                Paziente p = queRossa.Dequeue();
                MessageBox.Show($"PAZIENTE\n{p}");
            }
            else
            {
                if (queGialla.Count > 0)
                {
                    Paziente p = queGialla.Dequeue();
                    MessageBox.Show($"PAZIENTE\n{p}");
                }
                else
                {
                    if (queVerde.Count > 0)
                    {
                        Paziente p = queVerde.Dequeue();
                        MessageBox.Show($"PAZIENTE\n{p}");
                    }
                    else
                    {
                        if (queBianca.Count > 0)
                        {
                            Paziente p = queBianca.Dequeue();
                            MessageBox.Show($"PAZIENTE\n{p}");
                        }
                    }
                }
            }
        }

        private void btnInserisci2_Click(object sender, EventArgs e)
        {

        }
    }
}
