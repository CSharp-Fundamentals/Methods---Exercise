using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double firstFactorial = Factorial(first);
            double secondFactorial = Factorial(second);

            double diff = firstFactorial/ secondFactorial;
            Console.WriteLine($"{diff:F2}");
        }
        static double Factorial(int number)
        {
            double factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}