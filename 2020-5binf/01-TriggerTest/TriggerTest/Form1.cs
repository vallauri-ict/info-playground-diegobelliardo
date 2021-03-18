using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriggerTest
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DriverDB.mdf;Integrated Security=True;Connect Timeout=30";

        private BindingSource bindingSourceDriver = new BindingSource();
        private BindingSource bindingSourceStoricoCanc = new BindingSource();
        private BindingSource bindingSourceStoricoUpd = new BindingSource();
        private SqlDataAdapter dataAdapterDriver, dataAdapterStorico;
        private DataTable dtDriver, dtStorico;

        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Stringa di connessione:\n"+CONNECTION_STRING);
        }

        private void NonQuery(string selectCommand)
        {

            try
            {
                using (SqlConnection sc = new SqlConnection(CONNECTION_STRING))
                {
                    using (var cmd = sc.CreateCommand())
                    {
                        sc.Open();
                        cmd.CommandText = selectCommand;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private SqlDataReader GetData(string selectCommand)
        {
            try
            {
                var con = new SqlConnection(CONNECTION_STRING);
                var command = new SqlCommand(selectCommand, con);
                con.Open();
                var read = command.ExecuteReader();

                return read;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private void QueryDriver(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                dataAdapterDriver = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterDriver);

                // Populate a new data table and bind it to the BindingSource.
                dtDriver = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapterDriver.Fill(dtDriver);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QueryStorico(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                dataAdapterStorico = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterStorico);

                // Populate a new data table and bind it to the BindingSource.
                dtStorico = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapterStorico.Fill(dtStorico);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void PopulateDgv()
        {
            DataTable table;
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dgvDriver.DataSource = bindingSourceDriver;
            QueryDriver("SELECT * FROM Driver d");
            bindingSourceDriver.DataSource = dtDriver;

            //dgvDriver.DataSource = bindingSourceDriver;
            //SqlDataReader sqlDR = GetData("SELECT * FROM Driver");
            //DataTable dt = new DataTable();
            //dt.Load(sqlDR);
            //bindingSourceDriver.DataSource = dt;


            // Resize the DataGridView columns to fit the newly loaded content.
            dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvStoricoCancellazioni.DataSource = bindingSourceStoricoCanc;
            QueryStorico("SELECT * FROM StoricoCancellazioni");
            bindingSourceStoricoCanc.DataSource = dtStorico;
            // Resize the DataGridView columns to fit the newly loaded content.
            dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            dgvStoricoUpdate.DataSource = bindingSourceStoricoUpd;
            SqlDataReader sqlDR = GetData("SELECT * FROM StoricoAggiornamenti");
            DataTable dt = new DataTable();
            dt.Load(sqlDR);
            bindingSourceStoricoUpd.DataSource = dt;

            // Resize the DataGridView columns to fit the newly loaded content.
            dgvStoricoUpdate.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void OnDelete(object sender, MouseEventArgs e)
        {
            
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            dgvDriver.EndEdit();
            dataAdapterDriver.Update(dtDriver);
            MessageBox.Show("Aggiornato!");
            PopulateDgv();
        }

        private void OnCellDblClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show(dgvDriver.Rows[e.RowIndex].Cells["number"].Value.ToString());
            string delete = "Delete FROM Driver where number=" +
                            dgvDriver.Rows[e.RowIndex].Cells["number"].Value.ToString();
            MessageBox.Show(delete);
            QueryDriver(delete);

            PopulateDgv();
        }

        private void OnBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }
    }
}
