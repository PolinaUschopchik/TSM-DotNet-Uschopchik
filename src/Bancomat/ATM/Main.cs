using System;
namespace Domashka
{
    public class MainFunction
    {
        public void Menu()
        {
            Console.WriteLine("What you want?\n\t1 - Put money\n\t2 - Take money");
            int op = Console.Read();
            switch (op)
            {
                case 1:
                    Console.WriteLine("How much do you want to put?");
                    decimal n = Console.Read();
                    put(n);
                    break;
                case 2:
                    Console.WriteLine("How much do you want to take?");
                    decimal m = Console.Read();
                    Account.Take(m);
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this application is like an ATM \nEnter how much money you have");
            decimal money = Console.Read();
            Account account = new Account(money);
            
            Console.ReadLine();
        }
    }
}
