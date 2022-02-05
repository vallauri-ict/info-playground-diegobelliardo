using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsSQL08_Trigger
{
    public partial class Form1 : Form
    {
        private static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diego.belliardo\Desktop\info-playground-diegobelliardo\2020-5binf\01-TriggerTest\DriverDB.mdf;Integrated Security = True; Connect Timeout = 30";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStoricCancellazioni_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                con.Open();
                string sql = "Cancellazioni";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlParameter data = new SqlParameter();
                    data.ParameterName = "Data";

                    DateTime d = dtpData.Value;

                    data.Value = d;
                    data.Direction = ParameterDirection.Input;
                    data.DbType = DbType.Date;
                    cmd.Parameters.Add(data);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string s = "";

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            s += reader.GetValue(i) + " ";
                        }
                        MessageBox.Show(s);
                    }
                }
            }
        }
    }
}
