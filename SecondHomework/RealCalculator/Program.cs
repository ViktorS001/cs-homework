using System;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            Console.Write("Enter the first number:");
            string inputNumber1 = Console.ReadLine();
            Console.Write("Enter the second number:");
            string inputNumber2 = Console.ReadLine();
            if ((!decimal.TryParse(inputNumber1, out decimal firstNumber)) || (!decimal.TryParse(inputNumber2, out decimal secondNumber)))
            {
                Console.WriteLine("Invalid number. Try again...");
                return;
            }
            Console.WriteLine("Enter the mathematical operation");
            string inputOperation = Console.ReadLine();
            switch (inputOperation)
            {
                case "+": 
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
            }
        }
    }
}
