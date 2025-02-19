using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41_Tris
{
    public partial class Form1 : Form
    {
        char[,] trisT = new char[3, 3];
        const int NUM_RIGHE = 3;
        const int NUM_COLONNE = 3;
        // se turno % 2 == 0 --> X
        // se turno % 2 == 1 --> O
        int turno=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settaDgv();
        }

        private void settaDgv()
        {
            dgv.RowCount = NUM_RIGHE; dgv.ColumnCount = NUM_COLONNE;

            for (int i = 0; i < NUM_RIGHE; i++)
            {
                dgv.Rows[i].Height = dgv.Size.Height / NUM_RIGHE;
                dgv.Columns[i].Width = dgv.Size.Width / NUM_COLONNE;
            }
            
            // nascondo intestazioni di riga e colonna
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            // nascondo le scrollBars
            dgv.ScrollBars = ScrollBars.None;
            svuotaTris();
            visualizzaTris();
        }

        private void visualizzaTris()
        {
            for (int i = 0; i < NUM_RIGHE; i++)
            {
                for (int j = 0; j < NUM_COLONNE; j++)
                {
                    dgv.Rows[i].Cells[j].Value = trisT[i, j];
                }
            }
        }

        private void svuotaTris()
        {
            for (int i = 0;i < NUM_RIGHE; i++)
            {
                for(int j = 0;j < NUM_COLONNE; j++)
                {
                    trisT[i, j] = ' ';
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            char ris;
            //individuare riga e clonna della cella cliccata
            int i = dgv.CurrentCell.RowIndex;
            int j = dgv.CurrentCell.ColumnIndex;

            if (trisT[i,j]== ' ')
            {
                if (turno % 2 == 0)
                {
                    trisT[i, j] = 'X';
                }
                else
                    trisT[i,j] = 'O';
                turno++;
                dgv.Rows[i].Cells[j].Value = trisT[i,j];

                // controllo vittoria
                if (turno >= 5)
                    ris = chiVince(turno);
            }

        }

        private char chiVince(int turno)
        {
            char ch;
            ch = turno % 2 == 0 ? 'X' : 'O';
            if ((trisT[0, 0] == ch && trisT[0, 1] == ch && trisT[0, 2] == ch) ||
                (trisT[1, 0] == ch && trisT[1, 1] == ch && trisT[1, 2] == ch) ||
                (trisT[2, 0] == ch && trisT[2, 1] == ch && trisT[2, 2] == ch) ||
                (trisT[0, 0] == ch && trisT[1, 0] == ch && trisT[2, 0] == ch))
                return ch;
            else return '-';
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            svuotaTris();
            visualizzaTris();
            turno = 0;
        }
    }
}
