using System;
using System.Text;

namespace FizzBuzz.Business
{
    public class FizzBuzzBusiness
    {
        public string ProcessInputRange(int start, int end)
        {
            StringBuilder result = new StringBuilder();

            for (int i = start; i <= end; i++)
            {
                if (i != start)
                {
                    result.Append(" ");
                }
                result.Append(ProcessSingleNumber(i));
            }

            return result.ToString();
        }

        private string ProcessSingleNumber(int number)
        {
            if (number.ToString().Contains("3"))
            {
                return "luck";
            }

            if (number % 15 == 0)
            {
                return "fizzbuzz";
            }

            if (number % 3 == 0)
            {
                return "fizz";
            }

            if (number % 5 == 0)
            {
                return "buzz";
            }

            return number.ToString();
        }
    }
}
