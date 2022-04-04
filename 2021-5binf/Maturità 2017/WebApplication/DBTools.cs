using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;


namespace WebApplication
{
    class DBTools
    {
        private string ConnectionString;

        public DBTools(string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\diego.belliardo\\Desktop\\info-playground-diegobelliardo\\2021-5binf\\Maturità 2017\\db.mdf\";Integrated Security=True;Connect Timeout=30")
        {
            ConnectionString = connStr;
        }

        public string ExecuteSqlScript(string sqlScriptPath)
        {
            string stOut = "";
            try
            {
                string scriptContent = File.ReadAllText(sqlScriptPath);
                using (SqlConnection dbConn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand dbCmd = new SqlCommand(scriptContent, dbConn))
                    {
                        dbConn.Open();
                        dbCmd.ExecuteNonQuery();
                    }
                }
                stOut = "Sql Script SUCCESS!";
            }
            catch (SqlException sqlExc)
            {
                stOut = "Error in SQL query: " + sqlExc.Message;
            }
            catch (System.Exception exc)
            {
                stOut = "Generic error: " + exc.Message;
            }
            return stOut;
        }

        public string GetTableList(string tableName)
        {
            string stOut = "";
            using (SqlConnection dbConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand dbCmd = new SqlCommand("SELECT * FROM " + tableName, dbConn))
                {
                    dbConn.Open();
                    using (SqlDataReader dbReader = dbCmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            for (int i = 0; i < dbReader.FieldCount; i++)
                            {
                                stOut += dbReader.GetValue(i) + " - ";
                            }
                            stOut = stOut.Remove(stOut.Length - 3) + "\n";
                        }
                    }
                }
            }
            return stOut;
        }

        public DataTable GetDataTable(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            adapter.Dispose();
            return table;
        }
    }
}
