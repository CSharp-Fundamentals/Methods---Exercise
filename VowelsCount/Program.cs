using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int vowelsCount = VowelsCount(text);
            Console.WriteLine(vowelsCount);
        }
        static int VowelsCount(string text) {
            int vowelsCounter = 0;

            foreach (char letter in text)
            {
                if (letter=='a'||letter=='e'||
                    letter == 'i' || letter == 'o' ||
                    letter == 'u')
                {
                    vowelsCounter++;
                }
            }
            return vowelsCounter;
        }
    }
}
