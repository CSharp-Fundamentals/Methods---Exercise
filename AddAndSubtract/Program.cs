using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = Add(first,second);
            int diff = Subtract(sum, third);

            Console.WriteLine(diff);
        }
        static int Add(int first, int second) {
            return first + second;
        }
        static int Subtract(int first, int second) {
            return  first-second;
        }
    }
}
