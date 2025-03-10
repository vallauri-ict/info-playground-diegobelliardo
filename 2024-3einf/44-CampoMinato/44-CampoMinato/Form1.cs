using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44_CampoMinato
{
    public partial class Form1 : Form
    {
        const int DIM_CAMPO = 9;
        const int NUM_BOMBE = 10;
        Random rnd = new Random();
        int[,] campo = new int[DIM_CAMPO+2, DIM_CAMPO+2];


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InizializzaCampo();
            SettaDgv();
        }

        private void SettaDgv()
        {
            // imposto numero righe e colonne
            dgvCampoMinato.ColumnCount = DIM_CAMPO;
            dgvCampoMinato.RowCount = DIM_CAMPO;


        }

        private void InizializzaCampo()
        {
            // Posizionamento delle bombe
            // 0 = no bombe intorno
            // -1 = bomba
            // 1-8 = numero di bombe intorno

            int x, y;

            for (int i = 0; i < NUM_BOMBE; i++)
            {
                do
                {
                    x = rnd.Next(1, DIM_CAMPO+1);
                    y = rnd.Next(1, DIM_CAMPO+1);
                } while (campo[x, y] == -1);
                campo[x, y] = -1;
            }
            for (int i = 1; i <= DIM_CAMPO; i++)
            {
                for (int j = 1; j <= DIM_CAMPO; j++)
                {
                    if (campo[i, j] != -1)
                    {
                        campo[i, j] = ContaBombeVicino(i, j);
                    }
                }
            }

        }

        private int ContaBombeVicino(int i, int j)
        {
            int contatore = 0;
            for (int x = i - 1; x <= i + 1; x++)
            {
                for (int y = j - 1; y <= j + 1; y++)
                {
                    if (campo[x, y] == -1)
                    {
                        contatore++;
                    }
                }
            }
            return contatore;
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {

        }

    }
}
