using System;
using System.Data.SqlClient;

namespace OnlineRegisterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Online Register";
            char choise = ' ';

            do
            {
                Console.Clear();
                Console.WriteLine("\n*** ONLINE REGISTER BY VALLAURI ***\n");
                Console.WriteLine("1 - Student list");
                Console.WriteLine("2 - Class list");
                Console.WriteLine("3 -");
                Console.WriteLine("4 -");
                Console.WriteLine("5 -");
                Console.WriteLine("-------------------");
                Console.WriteLine("B - Backup Data");
                Console.WriteLine("T - Restore Data");
                Console.WriteLine("R - Reset Data");
                Console.WriteLine("-------------------");
                Console.WriteLine("X - Exit\n");

                choise = Console.ReadKey(true).KeyChar;

                switch (choise)
                {
                    case '1':
                        
                        StudentList();
                        Console.ReadKey(true);
                        break;
                    case '2':
                        Console.WriteLine("Call class list");
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("Work in progress");
                        Console.ReadKey(true);
                        break;
                }

            } while (choise !='x' && choise !='X');
        }

        public static void StudentList()
        {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fenic\Desktop\info-playground-diegobelliardo\2021-5binf\OnlineRegisterSolution\Data\OnlineRegister\Register.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection dbConn = new SqlConnection(connStr))
            {
                using (SqlCommand dbCmd=new SqlCommand("SELECT * FROM Student",dbConn))
                {
                    dbConn.Open();
                    using (SqlDataReader dbReader = dbCmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            Console.WriteLine(dbReader.GetString(1)+" - "+dbReader.GetString(2));
                        }
                    }
                }
                    



            }
        }
    }
}
