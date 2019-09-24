using System;

namespace Practice
{
    class Fizzbuzz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                fizzBuzzCheck(i);
            }
        }

        static void fizzBuzzCheck(int number)
        {
            string output = null;
            if (number % 3 == 0)
            {
                output += "Fizz";
            }
            if (number % 5 == 0)
            {
                output += "Buzz";
            }
            Console.WriteLine(output ?? number.ToString());
        }
    }
}