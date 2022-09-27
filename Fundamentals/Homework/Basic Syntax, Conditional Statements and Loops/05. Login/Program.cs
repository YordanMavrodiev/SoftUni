using System;
using System.Collections.Generic;
using System.IO;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass="";
            var penis = user.ToCharArray();
            Array.Reverse(penis);
            string password = string.Join("", penis);

            int times = 4;
            while (times!=0)
            {
                pass = Console.ReadLine();
               if (pass==password)
                {
                    Console.WriteLine("User "+ user+" logged in.");
                    break;
                }
                if (times == 1)
                {
                    Console.WriteLine("User " + user + " blocked!");
                    break;
                }
                else Console.WriteLine("Incorrect password. Try again.");
                times--;
            }
            
        }
    }
}
