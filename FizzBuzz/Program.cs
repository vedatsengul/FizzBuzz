using FizzBuzz.Business;
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int start = 0;
            int end = 0;
            ValidateInput(input, out start, out end);

            var fizzBuzzBusiness = new FizzBuzzBusiness();

            Console.WriteLine(fizzBuzzBusiness.ProcessInputRange(start, end));
        }

        private static void ValidateInput(string input, out int start, out int end)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("Invalid Input");
            }

            var splittedInput = input.Trim().Split(' ');

            if (splittedInput.Length != 2)
            {
                throw new Exception("Invalid Input");
            }

            if (!int.TryParse(splittedInput[0], out start))
            {
                throw new Exception("Invalid Input");
            }

            if (!int.TryParse(splittedInput[1], out end))
            {
                throw new Exception("Invalid Input");
            }
        }
    }
}
