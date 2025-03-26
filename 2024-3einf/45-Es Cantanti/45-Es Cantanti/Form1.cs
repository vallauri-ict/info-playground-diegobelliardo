using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _45_Es_Cantanti
{
    public partial class Form1 : Form
    {
        string[] cant = {
            "001|Freddie Mercury|Gruppo (Queen)|UK",
            "002|Elvis Presley|Solista|US",
            "003|Michael Jackson|Solista|US",
            "004|Madonna|Solista|US",
            "005|David Bowie|Solista|UK",
            "006|Bono|Gruppo (U2)|IE",
            "007|Kurt Cobain|Gruppo (Nirvana)|US"
        };

        string[] canz = {
            "Smells Like Teen Spirit|Grunge|007|7000000",
            "Bohemian Rhapsody|Rock|001|6000000",
            "We Will Rock You|Rock|001|4500000",
            "Can't Help Falling in Love|Pop|002|5000000",
            "Jailhouse Rock|Rock|002|4000000",
            "Billie Jean|Pop|003|10000000",
            "Thriller|Pop|003|9000000",
            "Like a Prayer|Pop|004|5000000",
            "Hung Up|Dance|004|4000000",
            "Heroes|Rock|005|3000000",
            "Space Oddity|Rock|005|3500000",
            "With or Without You|Rock|006|5000000",
            "One|Rock|006|3500000",
            "Come as You Are|Grunge|007|4500000",
            "Lithium|Grunge|007|3000000"
        };

        public struct canzone
        {
            public string titolo;
            public string genere;
            public string codCantante;
            public int copieVendute;
        }
        canzone[] canzoni = new canzone[30];
        canzone[] canzoniCantante = new canzone[30];

        public struct cantante
        {
            public string codice;
            public string nome;
            public string tipo;
            public string nazionalita;
        }
        cantante[] cantanti = new cantante[10];
        int nCantanti, nCanzoni;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nCantanti = cant.Length;
            nCanzoni = canz.Length;
            SettaDgv(dgvCanzoni);
            SettaDgv(dgvCantanti);
            SettaDgv(dgvCanzoniRis);
            CaricaStrutture();
        }

        private void CaricaStrutture()
        {
            for (int i = 0; i < nCantanti; i++)
            {
                string[] campi = cant[i].Split('|');
                cantanti[i].codice = campi[0];
                cantanti[i].nome = campi[1];
                cantanti[i].tipo = campi[2];
                cantanti[i].nazionalita = campi[3];
                dgvCantanti.Rows.Add(cantanti[i].codice, cantanti[i].nome, cantanti[i].tipo, cantanti[i].nazionalita);
                /**** OPPURE ****
                 * 
                 * dgvCantanti.Rows.Add();
                 * dgv.Rows[i].Cells[0].Value = cantanti[i].codice;
                 * dgv.Rows[i].Cells[1].Value = cantanti[i].nome;
                 * 
                 * *****************/
            }
            for (int i = 0; i < nCanzoni; i++)
            {
                string[] campi = canz[i].Split('|');
                canzoni[i].titolo = campi[0];
                canzoni[i].genere = campi[1];
                canzoni[i].codCantante = campi[2];
                canzoni[i].copieVendute = Convert.ToInt32(campi[3]);
                dgvCanzoni.Rows.Add(canzoni[i].titolo, canzoni[i].genere, canzoni[i].codCantante, canzoni[i].copieVendute);
            }

        }

        private void SettaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.ColumnHeadersVisible = true;
            IntestaTabella(dgv);
            dgv.RowHeadersVisible = true;
            dgv.ReadOnly = true;
            dgv.ClearSelection();
        }

        /// <summary>
        /// Ricevuto in ingresso il nome del cantante, 
        /// contare il numero totale di conzoni vendute, 
        /// visualizzandole in dgvCanzoniRis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCanzoniVendute_Click(object sender, EventArgs e)
        {
            string cantante;

            while ((cantante = Interaction.InputBox("Inserisci il cantante")) == "");
            string codice = CercaCodiceCantante(cantante);
            CaricaStrutturaCanzoniCantante(codice);
            VisualizzaCanzoniDgvCanzoniRis();
        }

        private void VisualizzaCanzoniDgvCanzoniRis()
        {
            int totaleCopie = 0;

            dgvCanzoniRis.Rows.Clear();
            for (int i = 0; i < canzoniCantante.Length; i++)
            {
                if (canzoniCantante[i].titolo != null)
                {
                    dgvCanzoniRis.Rows.Add(canzoniCantante[i].titolo, 
                                           canzoniCantante[i].genere, 
                                           canzoniCantante[i].codCantante, 
                                           canzoniCantante[i].copieVendute);
                    totaleCopie += canzoniCantante[i].copieVendute;
                }
            }
            MessageBox.Show("Totale copie vendute: " + totaleCopie);
        }

        private void CaricaStrutturaCanzoniCantante(string codice)
        {
            if (codice == null)
            {
                MessageBox.Show("Cantante non trovato");
                return;
            }

            int j = 0;

            for (int i = 0; i < canzoni.Length; i++)
            {
                if (canzoni[i].codCantante == codice)
                {
                    canzoniCantante[j].titolo = canzoni[i].titolo;
                    canzoniCantante[j].genere = canzoni[i].genere;
                    canzoniCantante[j].codCantante = canzoni[i].codCantante;
                    canzoniCantante[j].copieVendute = canzoni[i].copieVendute;
                    j++;
                }
            }
        }

        private string CercaCodiceCantante(string cantante)
        {
            for (int i = 0; i < cantanti.Length; i++)
            {
                if (cantanti[i].nome == cantante)
                {
                    return cantanti[i].codice;
                }
            }
            return null;
        }

        private void btnClassificaCantanti_Click(object sender, EventArgs e)
        {
            /* Dopo aver calcolato per ogni cantante il 
             * totale venduto delle loro canzoni, 
             * visualizzarne la classifica
             * */

            OrdinaPerCantante();
            LetturaRotturaCodice();
            

        }

        private void LetturaRotturaCodice()
        {
            int copieVendute=0,j=0;
            string[] codCantanti = new string[cantanti.Length];
            int[] totaliCopie = new int[cantanti.Length];

            for (int i = 0; i < canz.Length-1; i++)
            {
                if (canzoniCantante[i].codCantante == canzoniCantante[i+1].codCantante)
                {
                    copieVendute += canzoniCantante[i].copieVendute;
                }
                else  // Rottura di chiave
                {
                    copieVendute += canzoniCantante[i].copieVendute;
                    codCantanti[j]=canzoniCantante[i].codCantante;
                    totaliCopie[j]=copieVendute;
                    j++;
                    copieVendute = 0;
                }
            }
            copieVendute += canzoniCantante[canz.Length - 1].copieVendute;
            codCantanti[j] = canzoniCantante[canz.Length - 1].codCantante;
            totaliCopie[j] = copieVendute;
            Array.Resize(ref codCantanti,j);
            Array.Resize(ref totaliCopie, j);
            OrdinaVettori(codCantanti, totaliCopie);
            stampa(codCantanti, totaliCopie);
        }

        private void OrdinaVettori(string[] codCantanti, int[] totaliCopie)
        {
            int posMin;
            int ausT;
            string aus;

            for (int i = 0; i < codCantanti.Length-1; i++)
            {
                posMin = i;
                for (int j = 0; j < codCantanti.Length; j++)
                {
                    if (totaliCopie[posMin] < totaliCopie[j])
                    {
                        posMin = j;
                    }
                }
                if (posMin != i)
                {
                    aus = codCantanti[i];
                    codCantanti[i] = codCantanti[posMin]
                }
            }
        }

        private void stampa(string[] codCantanti, int[] totaliCopie)
        {
            throw new NotImplementedException();
        }

        private void OrdinaPerCantante()
        {
            for (int i = 0; i < canzoni.Length; i++)
            {
                canzoniCantante[i] = canzoni[i];
            }

            int posMin;
            canzone aus;

            for (int i = 0; i < canz.Length; i++)
            {
                posMin = i;
                for (int j = i+1; j < canz.Length; j++)
                {
                    if (canzoniCantante[posMin].codCantante.CompareTo(canzoniCantante[j].codCantante)>0)
                    {
                        posMin = j;
                    }
                }
                if (posMin!=i)
                {
                    aus = canzoniCantante[i];
                    canzoniCantante[i] = canzoniCantante[posMin];
                    canzoniCantante[posMin] = aus;
                }
            }
        }

        private void IntestaTabella(DataGridView dgv)
        {
            if(dgv.Name == "dgvCantanti")
            {
                dgv.Columns[0].Name = "Codice";
                dgv.Columns[1].Name = "Nome";
                dgv.Columns[2].Name = "Tipo";
                dgv.Columns[3].Name = "Nazionalità";
            }
            else
            {
                dgv.Columns[0].Name = "Titolo";
                dgv.Columns[1].Name = "Genere";
                dgv.Columns[2].Name = "Codice Cantante";
                dgv.Columns[3].Name = "Copie Vendute";
            }
        }
    }
}
