using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = Calculator(num1, num2, operation);
            Console.WriteLine(result);

        }

        private static double Calculator(double num1, double num2,
            string operation)
        {
            if (operation == "+")
            {
                return Add(num1, num2);
            }
            else if (operation == "-")
            {
                return Subtract(num1, num2);
            }
            else if (operation == "*")
            {
                return Multiply(num1, num2);
            }
            else if (operation == "/")
            {
                return Divide(num1, num2);
            }

            return 0.0;
        }


        private static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

    }
}
