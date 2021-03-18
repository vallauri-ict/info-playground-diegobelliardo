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

namespace EsStoredProcedure01
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DBBanche.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
            
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "CercaFiliali"; // Non ritorna nulla
                
                con.Open();
                
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlParameter nomeBanca = new SqlParameter();
                nomeBanca.ParameterName = "nomeBanca";
                nomeBanca.Direction = ParameterDirection.Input;
                nomeBanca.DbType = DbType.String;  // Tipo di dato nella S.P.
                nomeBanca.Size = 50;               // Dimensione del dato in caso di stringhe
                nomeBanca.Value = "CRF";
                cmd.Parameters.Add(nomeBanca);

                SqlParameter comune = new SqlParameter();
                comune.ParameterName = "comune";
                comune.Direction = ParameterDirection.Input;
                comune.DbType = DbType.String;  // Tipo di dato nella S.P.
                comune.Size = 50;               // Dimensione del dato in caso di stringhe
                comune.Value = "Genola";
                cmd.Parameters.Add(comune);

                cmd.CommandType = CommandType.StoredProcedure;

                int ris = cmd.ExecuteNonQuery();
                MessageBox.Show("Risultato: " + ris);

                
                
                
                cmd.CommandText = "CercaFiliali2";  // Ritorna una tabella

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
