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
        int mosse;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SettaDgv();
            InizializzaCampo();
            //MostraDgv();
        }

        private void SettaDgv()
        {
            // imposto numero righe e colonne
            dgvCampoMinato.ColumnCount = DIM_CAMPO;
            dgvCampoMinato.RowCount = DIM_CAMPO;

            // imposto la griglia in sola lettura
            dgvCampoMinato.ReadOnly = true;

            // nascondo header di rige e colonna
            dgvCampoMinato.RowHeadersVisible = false;
            dgvCampoMinato.ColumnHeadersVisible = false;

            // evitare il ridimensionamento delle celle
            dgvCampoMinato.AllowUserToResizeColumns = false;
            dgvCampoMinato.AllowUserToResizeRows = false;

            // disabilito le scrollbars
            dgvCampoMinato.ScrollBars = ScrollBars.None;


            dgvCampoMinato.Width = 360;
            dgvCampoMinato.Height = 360;

            // imposto la dimensione delle celle
            for (int i = 0; i < DIM_CAMPO; i++)
            {
                dgvCampoMinato.Columns[i].Width = 
                        dgvCampoMinato.Height/DIM_CAMPO;
                dgvCampoMinato.Rows[i].Height = 
                        dgvCampoMinato.Width/DIM_CAMPO;
            }
            dgvCampoMinato.ClearSelection();
        }

        private void InizializzaCampo()
        {
            // Posizionamento delle bombe
            // 0 = no bombe intorno
            // -1 = bomba
            // 1-8 = numero di bombe intorno

            int x, y;

            ResetCampo();
            mosse = 0;
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

        private void ResetCampo()
        {
            for (int i = 0; i < DIM_CAMPO + 2; i++)
            {
                for (int j = 0; j < DIM_CAMPO + 2; j++)
                {
                    campo[i, j] = 0;
                    if (i < DIM_CAMPO && j < DIM_CAMPO)
                        dgvCampoMinato.Rows[i].Cells[j].Style.BackColor = Color.Empty;
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
            InizializzaCampo();
            ResetValueDGV();
            //MostraDgv();
            dgvCampoMinato.Enabled = true;
        }

        private void ResetValueDGV()
        {
            for (int i = 0; i < DIM_CAMPO; i++)
            {
                for (int j = 0; j < DIM_CAMPO; j++)
                {
                    dgvCampoMinato.Rows[i].Cells[j].Value = "";
                    dgvCampoMinato.Rows[i].Cells[j].Tag = null;
                }
            }
        }

        private void MostraDgv()
        {
            for (int i = 0; i < DIM_CAMPO; i++)
            {
                for (int j = 0; j < DIM_CAMPO; j++)
                {
                    dgvCampoMinato.Rows[i].Cells[j].Value =
                        campo[i + 1, j + 1];
                }
            }
        }

        private void dgvCampoMinato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            int colonna = e.ColumnIndex;
            int contenutoCella = campo[riga + 1, colonna + 1];

            switch (contenutoCella)
            {
                case -1:
                    dgvCampoMinato.Rows[riga].Cells[colonna].Style.BackColor = Color.Red;
                    dgvCampoMinato.ClearSelection();
                    MessageBox.Show("Hai perso!");
                    MostraDgv();
                    dgvCampoMinato.Enabled = false;
                    break;
                case 0:
                    // Per capire quando incrementare mosse posso:
                    // 1) fare un test su BackColor == Color.Empty
                    // OPPURE
                    // 2) Utilizzare il campo Tag dell'oggetto

                    if (dgvCampoMinato.Rows[riga].Cells[colonna].Tag == null)
                    {
                        mosse++;
                        dgvCampoMinato.Rows[riga].Cells[colonna].Tag = "1";
                        dgvCampoMinato.Rows[riga].Cells[colonna].Style.BackColor = Color.Green;
                    }
                    break;
                default:
                    dgvCampoMinato.Rows[riga].Cells[colonna].Value =
                        campo[riga + 1, colonna + 1];
                    if (dgvCampoMinato.Rows[riga].Cells[colonna].Tag == null)
                    {
                        mosse++;
                        dgvCampoMinato.Rows[riga].Cells[colonna].Tag = "1";
                        dgvCampoMinato.Rows[riga].Cells[colonna].Style.BackColor = Color.Yellow;
                    }
                    break;
            }
            dgvCampoMinato.ClearSelection();
            if (mosse == DIM_CAMPO * DIM_CAMPO - NUM_BOMBE)
            {
                MessageBox.Show("Hai vinto!");
                MostraDgv();
                dgvCampoMinato.Enabled = false;
            }
        }
    }
}
