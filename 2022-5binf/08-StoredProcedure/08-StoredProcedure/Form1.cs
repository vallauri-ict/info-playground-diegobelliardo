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

namespace _08_StoredProcedure
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory= Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + 
            projectDirectory + @"\DBBanche.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();

            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "ContaLeFiliali";

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter nomeBanca = new SqlParameter();
                nomeBanca.ParameterName = "nomeBanca";
                nomeBanca.Direction = ParameterDirection.Input;
                nomeBanca.DbType= DbType.String;
                nomeBanca.Size = 50;
                nomeBanca.Value = "CRF";
                cmd.Parameters.Add(nomeBanca);

                SqlParameter comune = new SqlParameter();
                comune.ParameterName = "comune";
                comune.Direction = ParameterDirection.Input;
                comune.Value = "Fossano";
                comune.DbType= DbType.String;
                comune.Size = 50;
                cmd.Parameters.Add(comune);

                cmd.CommandType = CommandType.StoredProcedure;

                int ris=cmd.ExecuteNonQuery();
                MessageBox.Show("Risultato ContaLeFiliali: "+ris);


                cmd.CommandText = "CercaFiliali";           // Ritorna una tabella
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string s = "";

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        s += reader.GetValue(i)+" ";
                    }
                    MessageBox.Show(s);
                }
            }
        }
    }
}
