using System;

namespace Program
{
    class fizz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting of the range:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending of the range:");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FizzBuzz from " + start + " to " + end + ":");
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}