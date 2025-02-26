using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_Cambieri_Impossibile
{
    public partial class FormScrutinio: Form
    {
        public FormScrutinio()
        {
            InitializeComponent();
        }

        private void FormScrutinio_Load(object sender, EventArgs e)
        {
            SettaDgv(dgvScrutinio);
            clsScrutinio.CaricaVoti();
            /*  CaricaDgv(dgvScrutinio,clsScrutinio.voti,clsScrutinio.studenti,clsScrutinio.materie);   */
            CaricaDgvOttimizzato(dgvScrutinio, clsScrutinio.voti, clsScrutinio.studenti, clsScrutinio.materie);
            RidimensionaDgv(dgvScrutinio);
        }

        private void RidimensionaDgv(DataGridView dgv)
        {
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgv.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SettaDgv(DataGridView dgv)
        {
            dgv.ReadOnly=true;
            dgv.RowHeadersVisible = true;
            dgv.ColumnHeadersVisible = true;
            dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv.ClearSelection();
        }
        private void CaricaDgv(DataGridView dgv, int[,] voti, string[] studenti, string[]materie)
        {
            //nomi a sinistra
            dgv.ColumnCount = materie.Length;
            for (int i = 0; i < studenti.Length; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].HeaderCell.Value = studenti[i];
                
            }
            //matierie in alto
            for (int j = 0; j < materie.Length; j++)
            {
                dgv.Columns[j].HeaderCell.Value= materie[j] ;
            }
            //voti
            for (int i = 0; i < voti.GetLength(0); i++)
            {
                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = voti[i, j];
                    //oppure dgv[j,i].Value=voti[i,j];
                }
            }
        }
        private static void CaricaDgvOttimizzato (DataGridView dgv, int[,] voti, string[] studenti, string[] materie)
        {
            dgv.ColumnCount = materie.Length;
            for (int i = 0; i < studenti.Length; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].HeaderCell.Value = studenti[i];
                for (int j = 0; j < materie.Length; j++)
                {
                    if (i == 0)
                    {
                        dgv.Columns[j].HeaderCell.Value = materie[j];
                    }
                    dgv.Rows[i].Cells[j].Value = voti[i, j];
                }
            }
            
        }
        
    }
}
