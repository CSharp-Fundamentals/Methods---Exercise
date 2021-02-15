using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintMatrix(size);
        }

        static void PrintMatrix(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(size+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
