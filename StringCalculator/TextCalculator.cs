using System;
using System.Linq;

namespace StringCalculator
{
    public class TextCalculator
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return "0";

            var numberList = numbers.Split(',');

            if (numberList[^1] == "")
                throw new InvalidOperationException("Missing number in last position.");

            var parsedNumbers = numberList.Select(n =>
            {
                if (!double.TryParse(n, out double result))
                    throw new InvalidOperationException($"Invalid number format: {n}");
                return result;
            }).ToList();

            var negativeNumbers = parsedNumbers.Where(n => n < 0).ToList();
            if (negativeNumbers.Any())
            {
                string negativeNumbersString = string.Join(", ", negativeNumbers);
                throw new InvalidOperationException($"Negative not allowed: {negativeNumbersString}");
            }

            return parsedNumbers.Sum().ToString();
        }
    }
}