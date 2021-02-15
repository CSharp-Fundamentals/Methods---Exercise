using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (IsTopInteger(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopInteger(int number)
        {
            return IsDivisibleByEight(number, 8) && ContainsOddDigit(number);
        }

        private static bool IsDivisibleByEight(int number, int divider)
        {
            int sum = 0;

            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }
            return sum % divider == 0;
        }

        private static bool ContainsOddDigit(int number)
        {
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
