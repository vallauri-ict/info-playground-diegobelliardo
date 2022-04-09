using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ViaggiWeb
{
    public class DbTools
    {
        const string CONSTRDEFAULT = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diego.belliardo\Desktop\Esposito\Viaggi.mdf;Integrated Security=True;Connect Timeout=30";
        readonly string CONSTR;

        //const string SCRIPT_PATH = @"E:\informatica\5 superiore\informatica\Online register\OnlineRegisterClassLibrary\data\";
        static readonly string SCRIPT_PATH = Directory.GetCurrentDirectory() + @"\..\..\..\..\OnlineRegisterClassLibrary\data\"; //è una pecionata ma trova la cartella

        public DbTools(string conStr = CONSTRDEFAULT)
        {
            CONSTR = conStr;
        }

        public string[] GetTableList(string table)
        {
            using (SqlConnection dbCon = new SqlConnection(CONSTR))
            {
                using (SqlCommand dbCmd = new SqlCommand("SELECT * FROM " + table, dbCon))
                {
                    dbCon.Open();
                    using (SqlDataReader dbReader = dbCmd.ExecuteReader())
                    {
                        List<string> list = new List<string>();
                        while (dbReader.Read())
                        {
                            string newEl = "";
                            newEl += dbReader.GetValue(0).ToString();
                            for (int i = 1; i < dbReader.FieldCount; i++)
                            {
                                newEl += "|" + dbReader.GetValue(i).ToString();
                            }
                            list.Add(newEl);
                            //list += "\n" + dbReader.GetString(2) + " - " + dbReader.GetString(1);
                        }
                        dbCon.Close();
                        return list.ToArray();
                    }
                }
            }
        }

        public string ExecuteSqlScript(string script)
        {
            string stOut = "";
            try
            {
                string scriptContent = File.ReadAllText(SCRIPT_PATH + script);
                using (SqlConnection dbCon = new SqlConnection(CONSTR))
                {
                    using (SqlCommand dbCmd = new SqlCommand(scriptContent, dbCon))
                    {
                        dbCon.Open();
                        int nRow = dbCmd.ExecuteNonQuery();
                        dbCon.Close();
                        stOut = nRow.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                stOut = "Error while executing the sql script!\n" + ex.Message;
            }
            catch (Exception ex)
            {
                stOut = "An error has occurred:\n" + ex.Message;
            }
            return stOut;
        }

        public string ExecuteSqlQuery(string query)
        {
            string stOut = "";
            try
            {
                string scriptContent = query;
                using (SqlConnection dbCon = new SqlConnection(CONSTR))
                {
                    using (SqlCommand dbCmd = new SqlCommand(scriptContent, dbCon))
                    {
                        dbCon.Open();
                        int nRow = dbCmd.ExecuteNonQuery();
                        dbCon.Close();
                        stOut = nRow.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                stOut = "Error while executing the sql script!\n" + ex.Message;
            }
            catch (Exception ex)
            {
                stOut = "An error has occurred:\n" + ex.Message;
            }
            return stOut;
        }

        public List<string[]> ExecuteSelect(string script)
        {
            using (SqlConnection dbCon = new SqlConnection(CONSTR))
            {
                string scriptContent = File.ReadAllText(SCRIPT_PATH + script);
                using (SqlCommand dbCmd = new SqlCommand(scriptContent, dbCon))
                {
                    dbCon.Open();
                    using (SqlDataReader dbReader = dbCmd.ExecuteReader())
                    {
                        List<string[]> list = new List<string[]>();
                        while (dbReader.Read())
                        {
                            string[] newEl = new string[dbReader.FieldCount];
                            for (int i = 0; i < dbReader.FieldCount; i++)
                                newEl[i] = dbReader.GetValue(i).ToString();
                            list.Add(newEl);
                            //list += "\n" + dbReader.GetString(2) + " - " + dbReader.GetString(1);
                        }
                        dbCon.Close();
                        return list;
                    }
                }
            }
        }

        public DataTable GetDataTable(string query)
        {
            SqlConnection con = new SqlConnection(CONSTR);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            con.Close();

            return data;
        }
    }
}