using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four numbers to find their average value:");
            Console.Write("Enter the first number:");
            string inputNumber1 = Console.ReadLine();
            Console.Write("Enter the second number:");
            string inputNumber2 = Console.ReadLine();
            Console.Write("Enter the third number:");
            string inputNumber3= Console.ReadLine();
            Console.Write("Enter the fourth number:");
            string inputNumber4 = Console.ReadLine();
            if ((!int.TryParse(inputNumber1, out int firstNumber)) || (!int.TryParse(inputNumber2, out int secondNumber)) ||
                (!int.TryParse(inputNumber3, out int thirdNumber)) || (!int.TryParse(inputNumber4, out int fourthNumber)))
            {
                Console.WriteLine("Invalid number. Try again...");
                return;
            }

            int averageNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            Console.WriteLine("The average of " + firstNumber + "," + secondNumber +
                "," + thirdNumber + " and " + fourthNumber + " is: " + averageNumber);
        }
    }
}
