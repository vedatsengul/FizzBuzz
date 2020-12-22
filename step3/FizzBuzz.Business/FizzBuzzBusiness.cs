using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Business
{
    public class FizzBuzzBusiness
    {
        private const string _FIZZ = "fizz";
        private const string _BUZZ = "buzz";
        private const string _FIZZBUZZ = "fizzbuzz";
        private const string _LUCK = "luck";
        private const string _NUMBER = "number";
        public string ProcessInputRange(int start, int end)
        {
            Dictionary<string, int> statistics = new Dictionary<string, int>();
            statistics.Add(_LUCK, 0);
            statistics.Add(_FIZZBUZZ, 0);
            statistics.Add(_FIZZ, 0);
            statistics.Add(_BUZZ, 0);
            statistics.Add(_NUMBER, 0);

            StringBuilder result = new StringBuilder();

            for (int i = start; i <= end; i++)
            {
                if (i != start)
                {
                    result.Append(" ");
                }

                var processResult = ProcessSingleNumber(i);
                if (statistics.ContainsKey(processResult))
                {
                    statistics[processResult]++;
                }
                else
                {
                    statistics[_NUMBER]++;
                }

                result.Append(processResult);
            }

            result.AppendLine();
            result.AppendLine(_FIZZ + ": " + statistics[_FIZZ]);
            result.AppendLine(_BUZZ + ": " + statistics[_BUZZ]);
            result.AppendLine(_FIZZBUZZ + ": " + statistics[_FIZZBUZZ]);
            result.AppendLine(_LUCK + ": " + statistics[_LUCK]);
            result.Append(_NUMBER + ": " + statistics[_NUMBER]);

            return result.ToString();
        }

        private string ProcessSingleNumber(int number)
        {
            if (number.ToString().Contains("3"))
            {
                return _LUCK;
            }

            if (number % 15 == 0)
            {
                return _FIZZBUZZ;
            }

            if (number % 3 == 0)
            {
                return _FIZZ;
            }

            if (number % 5 == 0)
            {
                return _BUZZ;
            }

            return number.ToString();
        }
    }
}
