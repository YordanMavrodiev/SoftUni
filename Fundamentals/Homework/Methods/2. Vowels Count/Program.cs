using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word =  Console.ReadLine() ;

            Console.WriteLine(Vowels(word));

        }
        static int Vowels(string a)
            {
            var arr = a.ToCharArray();
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                arr[i]=char.ToLower(arr[i]);
                if (arr[i]=='a'|| arr[i] == 'o'|| arr[i] == 'i'|| arr[i] == 'u'|| arr[i] == 'e'|| arr[i] == 'y')
                {
                    count++;
                }
            }

            return count;
            }
    }
}
