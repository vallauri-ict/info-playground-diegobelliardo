using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_OOP03
{
    public partial class Form1 : Form
    {
        private Studente studente;
        public Form1()
        {
            InitializeComponent();

            studente = new Studente();
            aggiornaInterfaccia();
        }

        private void aggiornaInterfaccia()
        {
            string nome, città;
            int[] voti;

            studente.Get(out nome, out città, out voti);

            labelNome.Text = "Nome: " + nome;
            labelCittà.Text = "Città: " + città;
            labelVoti.Text = "Voti: " + string.Join(", ", voti);
            labelMediaVoti.Text = "Media Voti: " + CalcolaMediaVoti(voti).ToString();
        }

        private float CalcolaMediaVoti(int[] voti)
        {
            if (voti.Length == 0)
            {
                return 0;
            }

            float sommaVoti = 0;
            foreach (int voto in voti)
            {
                sommaVoti += voto;
            }

            return sommaVoti / voti.Length;
        }

        private void buttonAssegnaVoti_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] nuoviVoti = new int[12];

            for (int i = 0; i < nuoviVoti.Length; i++)
            {
                nuoviVoti[i] = random.Next(0, 11);
            }

            studente.Set("nomeProva", "cittàProva", nuoviVoti);

            aggiornaInterfaccia();
        }
    }
}
