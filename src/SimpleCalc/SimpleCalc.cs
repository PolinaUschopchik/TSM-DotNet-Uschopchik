using System;

namespace SimpleCalc
{
    class SimpleCalc
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter the symbol of operation: ");
            string op = Console.ReadLine();
            int res;
            switch (op)
            {
                case "+":
                    res = x + y;
                    Console.WriteLine("Result: " + res);
                    break;
                case "-":
                    res = x - y;
                    Console.WriteLine("Result: " + res);
                    break;
                case "*":
                    res = x * y;
                    Console.WriteLine("Result: " + res);
                    break;
                case "%":
                    float result = Convert.ToSingle(x + y);
                    Console.WriteLine("Result: " + result);
                    break;
                default:
                    Console.WriteLine("What is this? A don't know this operation!");
                    break;
            }
            Console.ReadLine();
        }
    }
}