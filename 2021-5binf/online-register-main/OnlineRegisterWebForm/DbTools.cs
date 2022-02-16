using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace OnlineRegisterWebForm
{
    public class DbTools
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\data\onlineregister\register.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable GetDataTable(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            adapter.Dispose();
            return table;
        }

        public List<string> GetDataList(string sqlQuery)
        {
            List<string> lstOut = new List<string>(); ;
            using (SqlConnection dbConn = new SqlConnection(connectionString))
            using (SqlCommand dbCmd = new SqlCommand(sqlQuery, dbConn))
            {
                dbConn.Open();
                using (SqlDataReader dbReader = dbCmd.ExecuteReader())
                    while (dbReader.Read()) lstOut.Add(dbReader.GetString(0));
            }
            return lstOut;
        }

    }
}