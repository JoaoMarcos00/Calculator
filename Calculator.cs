using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operation (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }

            Console.WriteLine("The result is: " + result);
        }
    }
}
