using System;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (!PassLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (SymbolContain(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (!DigitCount(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PassLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool SymbolContain(string password)
        {

            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }
            return false;
        }
        static bool DigitCount(string password)
        {
            int count = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
                if (count > 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
