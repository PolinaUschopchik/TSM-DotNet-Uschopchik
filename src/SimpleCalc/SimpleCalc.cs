using System;

namespace SimpleCalc
{
    class SimpleCalc
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int x = Console.ReadLine();
            Console.Write("Enter the second number: ");
            int y = Console.ReadLine();
            Console.Write("Enter the symbol of operation: ");
            char op = Console.ReadLine();
            switch (op)
            {
                case '+':
                    int res = x + y;
                    Console.WriteLine("Result: " + res);
                    break;
                case '-':
                    int res = x - y;
                    Console.WriteLine("Result: " + res);
                    break;
                case '*':
                    int res = x * y;
                    Console.WriteLine("Result: " + res);
                    break;
                case '%':
                    float res = Convert.ToSingle(x + y);
                    Console.WriteLine("Result: " + res);
                    break;
                default:
                    Console.WriteLine("What is this? A don't know this operation!");
                    break;
            }

        }
    }
}