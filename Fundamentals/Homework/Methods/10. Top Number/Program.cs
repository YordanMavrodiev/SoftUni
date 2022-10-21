using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumber(n);

        }
        static void TopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                bool isit=false;
                char[] arr = i.ToString().ToCharArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (arr[j]%2!=0)
                    {
                        isit = true;
                    }
                }
                if (sum%8==0&& isit)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        
        
        }
    }
}
