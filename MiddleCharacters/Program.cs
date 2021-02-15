using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string middle = MiddleChar(text);
            Console.WriteLine(middle);
        }
        static string MiddleChar(string text) {
            int mid = text.Length / 2;
            string trim = String.Empty;
            if (text.Length%2==0)
            {
                trim = text.Substring(mid-1,2);
            }
            else
            {
                trim = text.Substring(mid,1);
            }
            return trim;
        }
    }
}
