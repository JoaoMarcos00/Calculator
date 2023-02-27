using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;

            Console.WriteLine("Digite o primeiro número:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação (+, -, *, /):");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"O resultado de {num1} + {num2} é {result}");
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"O resultado de {num1} - {num2} é {result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"O resultado de {num1} * {num2} é {result}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"O resultado de {num1} / {num2} é {result}");
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero!");
                    }
                    break;

                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
