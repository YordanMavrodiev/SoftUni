using System;

namespace _4._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            char[] password = pass.ToCharArray();
            if (Characters(password)&&LetterDigit(password)&&Digit(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (!Characters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!LetterDigit(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!Digit(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static bool Characters(char[] a)
        {
            if (a.Length>=6&&a.Length<=10)
            {
                return true;
            }
            else return false;
        }
        static bool LetterDigit(char[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (!char.IsLetterOrDigit(a[i]))
                {
                    return false;
                }
                
            }
            return true;
        }
        static bool Digit(char[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i]))
                {
                    count++;
                }

            }
            if (count>=2)
            {
                return true;
            }
            else return false;
        }
    }
}
