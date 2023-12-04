// See https://aka.ms/new-console-template for more information

using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "123456789";
            string specialChars = "!£$%^&*=+-@";

            Console.WriteLine("Please enter a password: ");
            string userPassword = Console.ReadLine();

            int score = 0;
            if (userPassword.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(userPassword, uppercase))
            {
                score++;
            }
            if (Tools.Contains(userPassword, lowercase))
            {
                score++;
            }
            if (Tools.Contains(userPassword, digits))
            {
                score++;
            }
            if (Tools.Contains(userPassword, specialChars))
            {
                score++;
            }
            Console.WriteLine(score);
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("You have an extremely strong password");
                    break;
                case 3:
                    Console.WriteLine("You have a strong password");
                    break;
                case 2:
                    Console.WriteLine("You have a medium password");
                    break;
                case 1:
                    Console.WriteLine("You will be hacked");
                    break;
                default:
                    Console.WriteLine("Password does not meet any standards");
                    break;
            }
        }
    }
}
public static class Tools
{
    public static bool Contains(string input, string characters)
    {
        foreach (char c in characters)
        {
            if (input.Contains(c))
            {
                return true;
            }
        }
        return false;
    }
}
