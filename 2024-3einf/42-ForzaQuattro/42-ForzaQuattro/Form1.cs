using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42_ForzaQuattro
{
    public partial class Form1 : Form
    {
        private const int NUM_COL=7;
        private const int NUM_ROW = 6;
        char[,] f4 = new char[NUM_ROW, NUM_COL];

        int turno;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setdgv();
        }

        private void Setdgv()
        {
            dgvGioco.RowCount = NUM_ROW; dgvGioco.ColumnCount = NUM_COL;

            for (int i = 0; i < NUM_ROW; i++)
            {
                dgvGioco.Rows[i].Height = dgvGioco.Size.Height / NUM_ROW;
                dgvGioco.Columns[i].Width = dgvGioco.Size.Width / NUM_COL;
            }

            // nascondo intestazioni di riga e colonna
            dgvGioco.RowHeadersVisible = false;
            dgvGioco.ColumnHeadersVisible = false;
            // nascondo le scrollBars
            dgvGioco.ScrollBars = ScrollBars.None;
            dgvGioco.AllowUserToResizeColumns = false;
            dgvGioco.AllowUserToResizeRows = false;
            dgvGioco.ReadOnly = true;

            svuotaF4();
            visualizzaF4();
        }

        private void visualizzaF4()
        {
            for (int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < NUM_COL; j++)
                {
                    dgvGioco.Rows[i].Cells[j].Style.BackColor = 
                        f4[i, j] == 'R'? Color.Red :
                        f4[i,j] == 'G'? Color.Yellow:Color.Transparent;
                }
            }
        }

        private void svuotaF4()
        {
            for (int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < NUM_COL; j++)
                {
                    f4[i, j] = ' ';
                }
            }
        }

        private void dgvGioco_SelectionChanged(object sender, EventArgs e)
        {
            dgvGioco.ClearSelection();
        }
    }
}
