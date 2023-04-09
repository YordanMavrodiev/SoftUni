using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {

        //public void Browse(string site)
        //{
        //    Console.WriteLine($"Browsing: {site}!");
        //}

        //public void Dial(string number)
        //{
        //    Console.WriteLine($"Calling... {number}");
        //}
        public void Browse(string url)
        {
            char[] chars = url.ToCharArray();
            for (int i = 0; i < chars.Count(); i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    Console.WriteLine("Invalid URL!");
                    return;
                }
            }
            Console.WriteLine($"Browsing: {url}!");
        }

        public void Dial(string phone)
        {
            char[] chars = phone.ToCharArray();
            for (int i = 0; i < chars.Count(); i++)
            {
                if (!char.IsDigit(chars[i]))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }
            Console.WriteLine($"Calling... {phone}");
        }

    }
}
