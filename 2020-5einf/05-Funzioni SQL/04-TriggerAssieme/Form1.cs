using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_TriggerAssieme
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\Clienti.mdf;Integrated Security=True;Connect Timeout=30";

        private BindingSource bsClienti = new BindingSource();
        private BindingSource bsStoricoCanc = new BindingSource();
        private BindingSource bsStoricoUpd = new BindingSource();
        private SqlDataAdapter daClienti, daStoricoCancellazioni, daStoricoAggiornamenti;
        private DataTable dtClienti, dtStoricoCancellazioni, dtStoricoAggiornamenti;

        public Form1()
        {
            InitializeComponent();
            PopulateDgv(0);
        }

        private void PopulateDgv(int table)
        {
            switch (table)
            {
                case 0:
                    // Clienti
                    dgvClienti.DataSource = bsClienti;
                    Queryable("SELECT * FROM Clienti", out daClienti);

                    if (daClienti != null)
                    {
                        dtClienti = new DataTable();
                        daClienti.Fill(dtClienti);
                        bsClienti.DataSource = dtClienti;
                    }
                    dgvClienti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    //Cancellazioni
                    dgvStoricoCancellazioni.DataSource = bsStoricoCanc;
                    Queryable("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);

                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCanc.DataSource = dtStoricoCancellazioni;
                    }
                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                    //Aggiornamenti
                    dgvStoricoAggiornamenti.DataSource = bsStoricoUpd;
                    Queryable("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);

                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoUpd.DataSource = dtStoricoAggiornamenti;
                    }
                    dgvStoricoAggiornamenti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                    break;

                case 1:
                    dgvClienti.DataSource = bsClienti;
                    Queryable("SELECT * FROM Clienti", out daClienti);

                    if (daClienti!= null)
                    {
                        dtClienti = new DataTable();
                        daClienti.Fill(dtClienti);
                        bsClienti.DataSource = dtClienti;
                    }
                    dgvClienti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;

                case 2:
                    dgvStoricoCancellazioni.DataSource = bsStoricoCanc;
                    Queryable("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);

                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCanc.DataSource = dtStoricoCancellazioni;
                    }
                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;

                case 3:
                    dgvStoricoAggiornamenti.DataSource = bsStoricoUpd;
                    Queryable("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);

                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoUpd.DataSource = dtStoricoAggiornamenti;
                    }
                    dgvStoricoAggiornamenti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
            }
        }

        private void Queryable(string selectCommand, out SqlDataAdapter da)
        {
            da = null;
            try
            {
                // Crea un nuovo Data Adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                // Creo il command builder per generare update, insert, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
