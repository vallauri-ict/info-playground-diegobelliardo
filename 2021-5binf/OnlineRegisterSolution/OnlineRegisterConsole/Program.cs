using System;
using System.Data.SqlClient;
using OnlineRegisterClassLibrary;

namespace OnlineRegisterConsole
{
    class Program
    {
        private const string scriptPath =
            @"C:\Users\fenic\Desktop\info-playground-diegobelliardo\2021-5binf\OnlineRegisterSolution\Data\OnlineRegister\";
        private static dbTools db =
            new dbTools(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fenic\Desktop\info-playground-diegobelliardo\2021-5binf\OnlineRegisterSolution\Data\OnlineRegister\Register.mdf;Integrated Security=True;Connect Timeout=30");
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
                        Console.Write("\n*** STUDENT LIST ***\n");
                        Console.Write(db.getTableList("Student"));
                        Console.Write("************************\n");
                        Console.ReadKey(true);
                        break;
                    case '2':
                        Console.WriteLine("Call class list");
                        Console.ReadKey(true);
                        break;
                    case 't':
                    case 'T':
                        InitializzeStudent();
                        break;
                    case 'x':
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("Work in progress");
                        Console.ReadKey(true);
                        break;
                }

            } while (choise !='x' && choise !='X');
        }

        private static void InitializzeStudent()
        {
            Console.Write("\n*** INITIALIZZE STUDENT TABLE ***\n");
            Console.Write(db.executeSqlScript(scriptPath+ "Student.sql"));
            Console.Write("");
            Console.ReadKey(true);
        }
    }
}
