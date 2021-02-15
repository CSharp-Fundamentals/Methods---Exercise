using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int min = SmallestInteger(first, second, third);
            Console.WriteLine(min);
        }
        static int SmallestInteger(int first, int second, int third)
        {
            int min = Math.Min(Math.Min(first, second), third);
            return min;
        }
    }
}
