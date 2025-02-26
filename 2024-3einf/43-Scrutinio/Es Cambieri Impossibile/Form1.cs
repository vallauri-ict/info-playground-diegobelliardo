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
            ClsScrutinio.CaricaVoti(4,10);
            /*  CaricaDgv(dgvScrutinio,clsScrutinio.voti,clsScrutinio.studenti,clsScrutinio.materie);   */
            CaricaDgvOttimizzato(dgvScrutinio, ClsScrutinio.voti, ClsScrutinio.studenti, ClsScrutinio.materie);
            RidimensionaDgv(dgvScrutinio);
            RiempiCombo(cmbStudente,ClsScrutinio.studenti);
            RiempiCombo(cmbMateria, ClsScrutinio.materie);
        }

        private void RiempiCombo(ComboBox cmbStudente, string[] studenti)
        {
            for (int i = 0; i<studenti.Length; i++)
            {
                cmbStudente.Items.Add(studenti[i]);
            }
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
                    if (voti[i,j] >= 6)
                    {
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Green;
                    }
                    else if (voti[i,j] < 5)
                    {
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.DarkOrange;
                    }
                }
            }
            
        }

        private void btnContaEsiti_Click(object sender, EventArgs e)
        {
            int nPromossi = 0, nBocciati = 0, nRimandati = 0;

            ClsScrutinio.contaEsiti(ref nPromossi, ref nBocciati, ref nRimandati);
            if(rdbBocciati.Checked)
            {
                MessageBox.Show($"Ci sono {nBocciati} bocciati");
            }
            else if(rdbRimandati.Checked)
            {
                MessageBox.Show($"Ci sono {nRimandati} rimandati");
            }
            else MessageBox.Show($"Ci sono {nPromossi} promossi");
        }

        private void cmbStudente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string studenteSelezionato = cmbStudente.SelectedItem.ToString();
            int sommaVoti = 0, contaInsufficienze = 0;
            string elencoMatInsufficienti = "";

            for( int i = 0;i<ClsScrutinio.materie.Length;i++)
            {
                int voto = ClsScrutinio.voti[cmbStudente.SelectedIndex, i];
                sommaVoti += voto;

                if(voto < 6)
                {
                    contaInsufficienze++;
                    elencoMatInsufficienti += ClsScrutinio.materie[i] + " ";
                }
            }

            string risultato;
            if (contaInsufficienze > 3)
            {
                risultato = "BOCCIATO";
            }
            else if (contaInsufficienze == 0)
            {
                risultato = "PROMOSSO";
            }
            else risultato = "RIMANDATO";

            double mediaVoti = (double)sommaVoti / ClsScrutinio.materie.Length;

            MessageBox.Show($"{studenteSelezionato}\n{risultato}\n{elencoMatInsufficienti}" +
                $"\nMEDIA: {mediaVoti}");
        }
    }
}
