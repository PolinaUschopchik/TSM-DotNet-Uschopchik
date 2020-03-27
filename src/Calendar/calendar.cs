using System;

namespace calendar
{
    class Program
	{
        string[] tasks = new string[7];
        enum Week : int 
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        static void Menu()
		{
            Console.WriteLine("Choose what you want to do");
            Console.WriteLine("\tAdd a task\tEnter: 1");
            Console.WriteLine("\tDelete a task\tEnter: 2");
            Console.WriteLine("\tView a task\tEnter: 3");
            int choise = Console.Read();
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
        static void ChoiseDay()
        {
            Week day;
            string enterDay;
            Console.WriteLine("Enter day");
            enterDay = Console.ReadLine();
            switch (enterDay)
            {
                case "Mon":
                case "Monday":
                case "1":
                    day = Week.Monday;
                    break;
                case "Tue":
                case "Tuesday":
                case "2":
                    day = Week.Tuesday;
                    break;
                case "Wed":
                case "Wednesday":
                case "3":
                    day = Week.Wednesday;
                    break;
                case "Thu":
                case "Thursday":
                case "4":
                    day = Week.Thursday;
                    break;
                case "Fri":
                case "Friday":
                case "5":
                    day = Week.Friday;
                    break;
                case "Sat":
                case "Saturday":
                case "6":
                    day = Week.Saturday;
                    break;
                case "Sun":
                case "Sunday":
                case "7":
                    day = Week.Sunday;
                    break;
            }
            
        }
        static void AddTask()
        {
            ChoiseDay();
            tasks[day] = Console.ReadLine();

        }
        static void DeleteTask()
        {
            ChoiseDay();
            tasks[day] = null;
        }
        static void ViewTask()
        {
            ChoiseDay();
            Console.WriteLine(tasks[day]);
        }
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
            
            Console.WriteLine("Welcome to the calendar");
            Menu();
		}
	}
}