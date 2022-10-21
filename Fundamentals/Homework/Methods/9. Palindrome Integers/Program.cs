using System;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            while (n != "END")
            {

                Console.WriteLine(IsItPalindrome(n));

                n = Console.ReadLine();
            }
        }
        static bool IsItPalindrome(string a)
        {
            return a[0] == a[a.Length - 1];

        }
    }
}
