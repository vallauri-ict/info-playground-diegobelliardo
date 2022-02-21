using System;
using OnlineRegisterClassLibrary;

namespace OnlineRegisterConsole
{
    class Program
    {
        const string SCRIPT_PATH = @"C:\data\onlineregister\";
        static DbTools db = new DbTools(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\data\onlineregister\register.mdf;Integrated Security=True;Connect Timeout=30");
        
        static void Main(string[] args)
        {
            Console.Title = "Online Register";
            char choice = ' ';
            do
            {
                Console.WriteLine("*** ONLINE REGISTER BY VALLAURI ***\n");
                Console.WriteLine("1 - Initialize Student");
                Console.WriteLine("2 - Initialize Teacher");
                Console.WriteLine("3 - Initialize Subject");
                Console.WriteLine("4 - Initialize Class");
                Console.WriteLine("5 - Initialize Mark");
                Console.WriteLine("6 - Add References");
                Console.WriteLine("----------------");
                Console.WriteLine("9 - View Data");
                Console.WriteLine("----------------");
                Console.WriteLine("B - Backup Data");
                Console.WriteLine("T - Restore Data");
                Console.WriteLine("R - Reset Data");
                Console.WriteLine("Z - Zap Data (DANGEROUS!)");
                Console.WriteLine("----------------");
                Console.WriteLine("X - EXIT\n");
                choice = Console.ReadKey(true).KeyChar;
                switch (choice)
                {
                    case '1':
                        Initialize("Student");
                        break;
                    case '2':
                        Initialize("Teacher");
                        break;
                    case '3':
                        Initialize("Subject");
                        break;
                    case '4':
                        Initialize("Class");
                        break;
                    case '5':
                        Initialize("Mark");
                        break;
                    case '6':
                        AddReferences();
                        break;
                    case '9':
                        ViewData("Student");
                        ViewData("Teacher");
                        ViewData("Subject");
                        ViewData("Class");
                        ViewData("Mark");
                        ViewData("ClassTeacherSubject");
                        ViewData("MarkClassTeacherSubject");
                        break;
                    case 'R':
                    case 'r':
                        ResetData();
                        break;
                    case 'Z':
                    case 'z':
                        ZapData();
                        break;
                    default:
                        Console.WriteLine("Work in progress");
                        break;
                }
            } while (choice != 'X' && choice != 'x');
        }

        private static void Initialize(string tableName)
        {
            Console.Write("\n*** INITIALIZE " + tableName.ToUpper() + " TABLE ***\n");
            Console.WriteLine(db.ExecuteSqlScript(SCRIPT_PATH + tableName + "CreateTable.sql"));
            Console.Write(db.ExecuteSqlScript(SCRIPT_PATH + tableName + "Insert.sql"));
            Console.Write("\n****************\n\n");
            System.Threading.Thread.Sleep(2000);
            // Console.Clear();
        }

        private static void AddReferences()
        {
            Console.Write("\n*** SET REFERENCES ***\n");
            Console.WriteLine(db.ExecuteSqlScript(SCRIPT_PATH + "AddReferences.sql"));
            Console.WriteLine(db.ExecuteSqlScript(SCRIPT_PATH + "ReferencesInsert.sql"));
            Console.Write("\n****************\n\n");
            System.Threading.Thread.Sleep(2000);
            // Console.Clear();
        }

        public static void ViewData(string tableName)
        {
            try
            {
                Console.Write("\n*** " + tableName.ToUpper() + " ***\n");
                Console.Write(db.GetTableList(tableName));
                Console.Write("****************\n\n");
            }
            catch (Exception)
            {
                Console.WriteLine("\n*** PROBLEM WITH THE DATA ***\n\n");
            }
        }

        private static void ResetData()
        {
            Console.Write("\n*** RESET THE DB DATA ***\n");
            ZapData();
            Initialize("Student");
            Initialize("Teacher");
            Initialize("Subject");
            Initialize("Class");
            Initialize("Mark");
            AddReferences();
        }

        private static void ZapData()
        {
            Console.Write("\n*** ZAP ALL TABLES ***\n");
            Console.WriteLine(db.ExecuteSqlScript(SCRIPT_PATH + "DropReferences.sql"));
            Console.WriteLine(db.ExecuteSqlScript(SCRIPT_PATH + "ZapData.sql"));
            Console.Write("\n****************\n\n");
            System.Threading.Thread.Sleep(2000);
            // Console.Clear();
        }
    }
}
