using System;

namespace _1._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            int thirdnumber = int.Parse(Console.ReadLine());
            int fourthnumber = int.Parse(Console.ReadLine());
            int add = firstnumber + secondnumber;
            int divide = add / thirdnumber;
            int multiply = divide * fourthnumber;
            Console.WriteLine(multiply);

        }
    }
}
