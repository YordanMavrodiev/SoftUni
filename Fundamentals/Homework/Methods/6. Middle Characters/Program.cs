using System;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();
            Console.WriteLine(Characters(arr));
        }
        static string Characters(char[] a)
        {
            string end="";
            if (a.Length % 2 == 0)
            {
                int first = a.Length / 2;
                end = a[first-1].ToString() + a[first].ToString();
                return end;
            }
            else 
            {
                int ahg = (a.Length - 1) / 2 +1;
                end = a[ahg-1].ToString();
            }
            
            return end;
        }
    }
}
