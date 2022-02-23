using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Maturita2011
{
    public class DbTools
    {
        DataTable dt = new DataTable();
        private readonly string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["CONNECTIONSTRING"].ConnectionString;

        public DataTable GetDataTable(string sql)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd=new SqlCommand(sql,conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    
                    adapter.Fill(dt);
                    adapter.Dispose();
                }
            }
            return dt;
        }

        public List<string> GetDataList(string sqlQuery)
        {
            List<string> lstOut = new List<string>(); ;
            using (SqlConnection dbConn = new SqlConnection(CONNECTIONSTRING))
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