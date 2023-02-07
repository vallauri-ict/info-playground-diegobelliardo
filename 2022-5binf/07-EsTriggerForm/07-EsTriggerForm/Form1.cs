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

namespace _07_EsTriggerForm
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\Piloti.mdf;Integrated Security=True;Connect Timeout=30";

        private BindingSource bindingSourceDriver = new BindingSource();
        private BindingSource bindingSourceStoricoCanc = new BindingSource();
        private BindingSource bindingSourceStoricoUpd = new BindingSource();
        private SqlDataAdapter dataAdapterDriver, dataAdapterStorico;
        private DataTable dtDriver, dtStorico;

        public Form1()
        {
            InitializeComponent();
//            MessageBox.Show("Stringa di connessione: "+CONNECTION_STRING);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopolaDgv();
        }

        private void PopolaDgv()
        {
            DataTable table;

            //******* DRIVER ********/
            dgvDriver.DataSource = bindingSourceDriver;
            QueryDriver("SELECT * FROM Driver");
            bindingSourceDriver.DataSource = dtDriver;

            //Resize del DGV
            dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //******* STORICO CANCELLAZIONI ********/
            dgvStoricoCancellazioni.DataSource=bindingSourceStoricoCanc;
            QueryStorico("SELECT * FROM StoricoCancellazioni");
            bindingSourceStoricoCanc.DataSource = dtStorico;

            //Resize
            dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //******* STORICO UPDATE ********/
            dgvStoricoUpdate.DataSource = bindingSourceStoricoUpd;
//            QueryUpdate("SELECT * FROM StoricoAggiornamenti");

        }

        private void QueryUpdate(string v)
        {
            throw new NotImplementedException();
        }

        private void dgvDriver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string pk = dgvDriver.Rows[e.RowIndex].Cells["number"].Value.ToString();
            MessageBox.Show(pk);
            string delete = "DELETE FROM Driver WHERE number=" + pk;
            QueryDriver(delete);
            PopolaDgv();
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            dgvDriver.EndEdit();
            dataAdapterDriver.Update(dtDriver);
            PopolaDgv();
        }

        private void QueryStorico(string sqlCommand)
        {
            try
            {
                // Creiamo un data adapter basato su una query
                dataAdapterStorico = new SqlDataAdapter(sqlCommand, CONNECTION_STRING);

                // Creiamo un command builder per generare SQL di update, inser, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterStorico);

                //Popoliamo il data Table associato al BindingSource
                dtStorico = new DataTable();
                dataAdapterStorico.Fill(dtStorico);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QueryDriver(string sqlCommand)
        {
            try
            {
                // Creiamo un data adapter basato su una query
                dataAdapterDriver = new SqlDataAdapter(sqlCommand,CONNECTION_STRING);

                // Creiamo un command builder per generare SQL di update, inser, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterDriver);

                //Popoliamo il data Table associato al BindingSource
                dtDriver = new DataTable();
                dataAdapterDriver.Fill(dtDriver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
