using System;

namespace Program
{
    class studentgrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the first student:");
            string student1 = Console.ReadLine();
            Console.WriteLine("Enter the grade of the first student:");
            int grade1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the second student:");
            string student2 = Console.ReadLine();
            Console.WriteLine("Enter the grade of the second student:");
            int grade2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the third student:");
            string student3 = Console.ReadLine();
            Console.WriteLine("Enter the grade of the third student:");
            int grade3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the fourth student:");
            string student4 = Console.ReadLine();
            Console.WriteLine("Enter the grade of the fourth student:");
            int grade4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the fifth student:");
            string student5 = Console.ReadLine();
            Console.WriteLine("Enter the grade of the fifth student:");
            int grade5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(student1 + "'s grade is " + grade1);
            Console.WriteLine(student2 + "'s grade is " + grade2);
            Console.WriteLine(student3 + "'s grade is " + grade3);
            Console.WriteLine(student4 + "'s grade is " + grade4);
            Console.WriteLine(student5 + "'s grade is " + grade5);

            int average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            Console.WriteLine("The average grade is " + average);

        }
    }
}