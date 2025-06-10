using System;

namespace Coding.Excercise
{
    public class NumberChecker
    {
        public bool IsEven(int number)
        {
            return number %2 == 0;
        }


        public bool IsOdd(int number) 
        {
            return number %2 != 0;
        }


    }

    public class Program 
    {
        public static void Main(string[] args)

        {
            NumberChecker checker = new NumberChecker();

            Console.WriteLine("Let's check if a number is even or odd!");
            Console.WriteLine("Please enter an integer: ");

            string input = Console.ReadLine();

            int number;

            if (checker.IsEven(number))
            {
                Console.WriteLine($"\n Result: {} is an EVEN number.");
            }
            else
            {
                Console.WriteLine($"\n Result: {} is an ODD number.");
            }


        }
        else
        {
            Console.WriteLine("\n Error: That was not a valid integer. please enter valid integer.");

        }

        Console.WriteLine("\n Press any key to exit. ");

    }
}
