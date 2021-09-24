using System;
using System.Data.SqlClient;
using System.IO;

namespace OnlineRegisterClassLibrary
{
    public class dbTools
    {
        private string connStr = "";

        public dbTools(string connStr)
        {
            this.connStr = connStr;
        }

        public string executeSqlScript(string path)
        {
            string stOut = "Sql Script SUCCESS";
            string scriptContent = File.ReadAllText(path);
            //scriptContent = scriptContent.Replace("\r\n", "");
            try
            {
                using (SqlConnection dbConn = new SqlConnection(connStr))
                {
                    using (SqlCommand dbCmd = new SqlCommand(scriptContent, dbConn))
                    {
                        dbConn.Open();
                        dbCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                stOut = "ERROR in SQL query: " + ex.Message;
            }
            catch (Exception ex)
            {
                stOut = "ERROR generic: "+ex.Message;
            }

            
            return stOut;
        }
        public string getTableList(string tableName)
        {
            string res = "";
            using (SqlConnection dbConn = new SqlConnection(connStr))
            {
                using (SqlCommand dbCmd = new SqlCommand("SELECT * FROM "+tableName, dbConn))
                {
                    dbConn.Open();
                    using (SqlDataReader dbReader = dbCmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            res += dbReader.GetString(1) + " - " + dbReader.GetString(2) + "\n";
//                            Console.WriteLine(dbReader.GetString(1) + " - " + dbReader.GetString(2));
                        }
                    }
                }


            }

            return res;
        }


    }
}
