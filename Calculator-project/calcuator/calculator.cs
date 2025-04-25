using System;

namespace Program
{
    class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the operation from the list below:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Addition: " + (number1 + number2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction: " + (number1 - number2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication: " + (number1 * number2));
                    break;
                case 4:
                    Console.WriteLine("Division: " + (number1 / number2));
                    break;
                case 5:
                    Console.WriteLine("Modulus: " + (number1 % number2));
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }
        }
    }
}