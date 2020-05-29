using System;

namespace calendar
{
    class Program
    {
        static string[][] tasks = new string[12][];

        static void Menu()
        {
            Console.WriteLine("Choose what you want to do");
            Console.WriteLine("\tAdd a task\tEnter: 1");
            Console.WriteLine("\tDelete a task\tEnter: 2");
            Console.WriteLine("\tView a task\tEnter: 3");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                AddTask();
            }
            else if (choise == 2)
            {
                DeleteTask();
            }
            else if (choise == 3)
            {
                ViewTask();
            }
            else
            {
                Console.WriteLine("You entered something illegible");
                Menu();
            }
        }
        static int ChoiseMonth()
        {
            Console.WriteLine("Enter month: ");
            int enterMonth = Console.Read();

            return enterMonth;

        }
        static int ChoiseDay()
        {
            Console.WriteLine("Enter day: ");
            int enterDay = Console.Read();

            return enterDay;

        }
        static void AddTask()
        {
            int i = ChoiseMonth() - 1;
            int j = ChoiseDay() - 1;
            tasks[i][j] = Console.ReadLine();
        }
        static void DeleteTask()
        {
            int i = ChoiseMonth() - 1;
            int j = ChoiseDay() - 1;
            tasks[i][j] = null;
        }
        static void ViewTask()
        {
            int i = ChoiseMonth() - 1;
            int j = ChoiseDay() - 1;
            Console.WriteLine(tasks[i][j]);
        }

        //protected void IndexOutOfRangeException()//I didn’t understand what to do here
        //{

        //    if (i < 0 || j < 0)
        //    {
        //        try
        //        {
        //            Console.WriteLine("Wrong date");
        //        }
        //        finally
        //        {
        //            Console.WriteLine("Oops");
        //        }
        //    }
        //}

        static void ExitOrMenu()
        {
            int exit;
            Console.WriteLine("\tBack to menu\tEnter 1");
            Console.WriteLine("\tGo out\tEnter anything");
            exit = Console.Read();
            if (exit == 1)
            {
                Menu();
            }
            else
            {
                
            }
        }
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            string year = now.ToString("year");
            Console.WriteLine("Welcome to the calendar. Today is: "+ now.ToString("DD.MM.yyyy"));
            Menu();
        }
    }
}