using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> number = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] http = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < number.Count; i++)
            {

                
                    if (number[i].Length == 10)
                    {
                        Smartphone smartphone = new Smartphone();
                        smartphone.Dial(number[i]);
                    }
                
                    if (number[i].Length == 7)
                    {
                        StationaryPhone stationaryPhone = new StationaryPhone();
                        stationaryPhone.Dial(number[i]);
                    }
                
                
            }
            for (int i = 0; i < http.Length; i++)
            {

                
                
                    
                        Smartphone smartphone = new Smartphone();
                        smartphone.Browse(http[i]);
                    
                    

                
            }

        }
    }
}
