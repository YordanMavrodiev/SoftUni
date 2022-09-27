using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int endgame = a;
            int sum = 0;
            int uno = 1;
            for (int i = 1; i <= endgame.ToString().Length; i++)
            {
                for (int j = a % 10; j >=1 ; j--)
                {
                    uno =uno* j;
                    
                }
                a = a / 10;
                sum += uno;
                uno = 1;
            }
            if (endgame==sum)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
