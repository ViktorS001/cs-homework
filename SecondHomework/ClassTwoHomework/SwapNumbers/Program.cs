using System;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            Console.Write("Input the First Number: ");
            string inputNumber1 = Console.ReadLine();
            Console.Write("Input the Second Number: ");
            string inputNumber2 = Console.ReadLine();
            if ((!int.TryParse(inputNumber1, out int firstNumber)) || (!int.TryParse(inputNumber2, out int secondNumber)))
            {
                Console.WriteLine("Invalid number. Try again...");
                return;
            }
            int temp;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + firstNumber);
            Console.WriteLine("Second Number: " + secondNumber);
           
        }
    }
}
